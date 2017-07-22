using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus_RTU_test
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            modbus = new ModbusClient();
            modbus.ReceivedData += modbus_ReceivedData;
        }
        private ModbusClient modbus;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //防止出现  线程间操作无效   ,调试完注释掉

            ListInit();

        }

        void modbus_ReceivedData(string str)
        {
            rtbResult.Text += str + "\n";
            rtbResult.Select(rtbResult.TextLength, 0);   //跳到末尾
            rtbResult.ScrollToCaret();

            if (str == "CRC_Error") return;

            int start = int.Parse(txtStart.Text);
            int valueLen = Convert.ToInt32(str.Substring(4, 2), 16);
            Dictionary<string, string> dicValue = new Dictionary<string, string>();
            switch (str.Substring(2, 2))
            {
                case "01":
                case "02":
                    for (int i = 0; i < valueLen; i++)
                    {
                        byte dataByte = Convert.ToByte(str.Substring(6 + i * 2, 2), 16);
                        for (int j = 0; j < 8; j++)
                        {
                            if (i * 8 + j < int.Parse(txtCount.Text))
                                dicValue.Add(string.Format("{0:D2}", (i * 8 + j + start - 1) / 8) + ":" + (j + start - 1) % 8, "[" + (CommonTools.GetBit(dataByte, j) ? "ON" : "OFF") + "]");
                        }
                    }
                    break;
                case "03":
                case "04":
                    for (int i = 0; i < valueLen / 2; i++)
                    {
                        dicValue.Add(string.Format("{0:D4}", i + start), "[" + str.Substring(6 + i * 4, 4) + "]");
                    }
                    break;
            }

            showValue(dicValue);
        }

        private void showValue(Dictionary<string, string> dicValue)
        {
            if (dicValue.Count <= 0) return;
            int lines = 8;
            StringBuilder[] lineBuilders = new StringBuilder[lines];
            for (int i = 0; i < lines; i++)
            {
                lineBuilders[i] = new StringBuilder();
            }
            int indexLine = 0;
            foreach (var pair in dicValue)
            {
                lineBuilders[indexLine].Append(pair.Key + "\t" + pair.Value + "\t\t");
                indexLine++;
                if (indexLine >= lines) indexLine = 0;
            }
            StringBuilder valueBuilder = new StringBuilder();
            foreach (var builder in lineBuilders)
            {
                valueBuilder.AppendLine(builder.ToString());
            }
            rtbValue.Text = valueBuilder.ToString();
        }


        private void ListInit()
        {
            lblState.Text = "连接未打开";
            //连接设置列表

            //串口
            cmbPort_DropDown(null, null);

            //波特率
            cmbBaudRate.Items.Add("2400");
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("19200");
            cmbBaudRate.Items.Add("38400");
            cmbBaudRate.Items.Add("57600");
            cmbBaudRate.Items.Add("115200");
            cmbBaudRate.SelectedIndex = 1;

            //数据位
            cmbDataBits.Items.Add("7");
            cmbDataBits.Items.Add("8");
            cmbDataBits.SelectedIndex = 1;

            //停止位
            cmbStopBit.Items.Add("1");
            cmbStopBit.Items.Add("2");
            cmbStopBit.SelectedIndex = 0;

            //校验位
            cmbParity.Items.Add("无");
            cmbParity.Items.Add("奇校验");
            cmbParity.Items.Add("偶校验");
            cmbParity.SelectedIndex = 0;

            //功能
            cmbFunction.Items.AddRange(new ComboxItem[]
            {
                new ComboxItem("读取输出点状态","01"),
                new ComboxItem("读取输入点状态","02"),
                new ComboxItem("读取寄存器数值","03"),
                new ComboxItem("读取模拟量输入","04"),
            }
                );
            cmbFunction.SelectedIndex = 0;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            modbus.Close();
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            if (btnOpenCom.Text == "打开连接")
            {
                if (modbus.Open(cmbPort.Text, int.Parse(cmbBaudRate.Text), int.Parse(cmbDataBits.Text),
                    (Parity)cmbParity.SelectedIndex, (StopBits)int.Parse(cmbStopBit.Text), -1, -1))
                {
                    lblState.Text = modbus.PortName + "端口已经打开";
                    gBoxCOM.Enabled = false;
                    btnOpenCom.Text = "断开连接";
                    btnOpenCom.BackColor = Color.Plum;

                    timer1.Start();
                    btnOffTimer.Text = "停止刷新";
                }
            }
            else
            {
                timer1.Stop();
                btnOffTimer.Text = "自动刷新";
                CommonTools.Delay(1000);
                if (modbus.Close())
                {
                    lblState.Text = "连接未打开";
                    gBoxCOM.Enabled = true;
                    btnOpenCom.Text = "打开连接";
                    btnOpenCom.BackColor = Color.Lime;
                }
            }

        }

        private void btnOffTimer_Click(object sender, EventArgs e)
        {
            if (btnOffTimer.Text == "停止刷新")
            {
                timer1.Stop();
                btnOffTimer.Text = "自动刷新";
            }
            else
            {
                if (modbus.IsOpen)
                {
                    timer1.Start();
                    btnOffTimer.Text = "停止刷新";
                }
                else
                {
                    btnOpenCom_Click(null, null);
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTime.Text))
            {
                timer1.Interval = 1000 * int.Parse(txtTime.Text.Trim());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSendStr.Text =
                CommonTools.ToHexString(modbus.GetFromPLC(Convert.ToByte(((ComboxItem)(cmbFunction.SelectedItem)).Value),
                    int.Parse(txtAddress.Text, NumberStyles.HexNumber), int.Parse(txtStart.Text, NumberStyles.HexNumber), int.Parse(txtCount.Text)));
        }

        private void rtbResult_DoubleClick(object sender, EventArgs e)
        {
            rtbResult.Clear();
        }

        private void rtbValue_DoubleClick(object sender, EventArgs e)
        {
            rtbValue.Clear();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCount.Text) || txtCount.Text == "0") txtCount.Text = "1";
            if (int.Parse(txtCount.Text) > 120) txtCount.Text = "120";
        }

        private void cmbPort_DropDown(object sender, EventArgs e)
        {
            //串口
            string[] ports = SerialPort.GetPortNames();
            cmbPort.Items.Clear();
            if (ports.Length > 0)
            {
                foreach (string port in ports)
                {
                    cmbPort.Items.Add(port);
                }
                cmbPort.SelectedIndex = 0;
            }
        }

        private void btnWriteValue_Click(object sender, EventArgs e)
        {
            FrmWritedata frm = new FrmWritedata();
            frm.WriteVData += (address, start, value) =>
            {
                if (modbus.IsOpen)
                {
                    modbus.WriteVByte(int.Parse(address, NumberStyles.HexNumber), int.Parse(start, NumberStyles.HexNumber), Convert.ToInt16(value, 16));
                }
                else
                {
                    MessageBox.Show("连接未打开！");
                }
            };
            frm.ShowDialog();

        }

        //void frm_WriteVData(string address, string start, string value)
        //{
        //    if (modbus.IsOpen)
        //    {
        //        modbus.WriteVByte(int.Parse(address), int.Parse(start), Convert.ToInt16(value, 16));
        //    }
        //    else
        //    {
        //        MessageBox.Show("连接未打开！");
        //    }
        //}

        private void menuSaveTxt_Click(object sender, EventArgs e)
        {
            //var rtb = (RichTextBox)(contextMenuStrip1.SourceControl);
            var rtb = (RichTextBox) (((ContextMenuStrip)((ToolStripMenuItem)sender).GetCurrentParent()).SourceControl);
            if (rtb.Text == "")
                return;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = saveFileDialog1.ShowDialog();
            if ( result== DialogResult.Cancel)
                return;
            string FileName = saveFileDialog1.FileName;

            if (result == DialogResult.OK && FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                rtb.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("文件已成功保存");
            }
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.DrawString(e.ToolTipText,e.Font,Brushes.Red,new Point(2,2));
        }

    }
}
