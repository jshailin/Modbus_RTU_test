namespace Modbus_RTU_test
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gBoxCOM = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStopBit = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.btnOffTimer = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSendStr = new System.Windows.Forms.TextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSaveTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbValue = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWriteValue = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gBoxCOM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gBoxCOM
            // 
            this.gBoxCOM.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gBoxCOM.Controls.Add(this.label5);
            this.gBoxCOM.Controls.Add(this.cmbStopBit);
            this.gBoxCOM.Controls.Add(this.cmbParity);
            this.gBoxCOM.Controls.Add(this.label4);
            this.gBoxCOM.Controls.Add(this.cmbDataBits);
            this.gBoxCOM.Controls.Add(this.label3);
            this.gBoxCOM.Controls.Add(this.cmbBaudRate);
            this.gBoxCOM.Controls.Add(this.label2);
            this.gBoxCOM.Controls.Add(this.cmbPort);
            this.gBoxCOM.Controls.Add(this.label1);
            this.gBoxCOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxCOM.Location = new System.Drawing.Point(0, 0);
            this.gBoxCOM.Name = "gBoxCOM";
            this.gBoxCOM.Size = new System.Drawing.Size(785, 65);
            this.gBoxCOM.TabIndex = 1;
            this.gBoxCOM.TabStop = false;
            this.gBoxCOM.Text = "连接设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "校验方式";
            // 
            // cmbStopBit
            // 
            this.cmbStopBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBit.FormattingEnabled = true;
            this.cmbStopBit.Location = new System.Drawing.Point(564, 26);
            this.cmbStopBit.Name = "cmbStopBit";
            this.cmbStopBit.Size = new System.Drawing.Size(54, 29);
            this.cmbStopBit.TabIndex = 8;
            // 
            // cmbParity
            // 
            this.cmbParity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(700, 26);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(73, 29);
            this.cmbParity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "停止位";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(440, 26);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(54, 29);
            this.cmbDataBits.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(258, 26);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(105, 29);
            this.cmbBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // cmbPort
            // 
            this.cmbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(61, 26);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 29);
            this.cmbPort.TabIndex = 1;
            this.cmbPort.DropDown += new System.EventHandler(this.cmbPort_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.BackColor = System.Drawing.Color.Lime;
            this.btnOpenCom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenCom.Location = new System.Drawing.Point(581, 71);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(93, 35);
            this.btnOpenCom.TabIndex = 2;
            this.btnOpenCom.Text = "打开连接";
            this.btnOpenCom.UseVisualStyleBackColor = false;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // btnOffTimer
            // 
            this.btnOffTimer.Location = new System.Drawing.Point(680, 71);
            this.btnOffTimer.Name = "btnOffTimer";
            this.btnOffTimer.Size = new System.Drawing.Size(93, 35);
            this.btnOffTimer.TabIndex = 3;
            this.btnOffTimer.Text = "自动刷新";
            this.btnOffTimer.UseVisualStyleBackColor = true;
            this.btnOffTimer.Click += new System.EventHandler(this.btnOffTimer_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(12, 71);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(55, 21);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "label6";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtSendStr);
            this.panel1.Controls.Add(this.rtbResult);
            this.panel1.Controls.Add(this.rtbValue);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbFunction);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 390);
            this.panel1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 361);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(592, 29);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "测试用程序。如有问题，E-mail to :  jshailin@sina.com";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(542, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "请求帧:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(13, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(534, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "左框为取得的数据，右框为响应帧；双击可清除内容，右键可保存成TXT。";
            // 
            // txtSendStr
            // 
            this.txtSendStr.BackColor = System.Drawing.Color.Silver;
            this.txtSendStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSendStr.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSendStr.ForeColor = System.Drawing.Color.Red;
            this.txtSendStr.Location = new System.Drawing.Point(610, 41);
            this.txtSendStr.Name = "txtSendStr";
            this.txtSendStr.ReadOnly = true;
            this.txtSendStr.Size = new System.Drawing.Size(163, 26);
            this.txtSendStr.TabIndex = 13;
            // 
            // rtbResult
            // 
            this.rtbResult.BackColor = System.Drawing.Color.Silver;
            this.rtbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbResult.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbResult.Location = new System.Drawing.Point(610, 73);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbResult.Size = new System.Drawing.Size(163, 305);
            this.rtbResult.TabIndex = 12;
            this.rtbResult.Text = "";
            this.rtbResult.DoubleClick += new System.EventHandler(this.rtbResult_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveTxt});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // menuSaveTxt
            // 
            this.menuSaveTxt.Name = "menuSaveTxt";
            this.menuSaveTxt.Size = new System.Drawing.Size(169, 22);
            this.menuSaveTxt.Text = "保存成文本文件...";
            this.menuSaveTxt.Click += new System.EventHandler(this.menuSaveTxt_Click);
            // 
            // rtbValue
            // 
            this.rtbValue.BackColor = System.Drawing.Color.Silver;
            this.rtbValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbValue.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbValue.Location = new System.Drawing.Point(12, 73);
            this.rtbValue.Name = "rtbValue";
            this.rtbValue.ReadOnly = true;
            this.rtbValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbValue.Size = new System.Drawing.Size(592, 285);
            this.rtbValue.TabIndex = 6;
            this.rtbValue.Text = "";
            this.rtbValue.WordWrap = false;
            this.rtbValue.DoubleClick += new System.EventHandler(this.rtbValue_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(747, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "秒";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTime.Location = new System.Drawing.Point(700, 6);
            this.txtTime.MaxLength = 4;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(41, 29);
            this.txtTime.TabIndex = 10;
            this.txtTime.Text = "1";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtTime.Leave += new System.EventHandler(this.txtTime_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(620, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "刷新时间";
            // 
            // cmbFunction
            // 
            this.cmbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunction.FormattingEnabled = true;
            this.cmbFunction.Location = new System.Drawing.Point(216, 6);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(136, 29);
            this.cmbFunction.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "协议功能";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCount.Location = new System.Drawing.Point(553, 6);
            this.txtCount.MaxLength = 4;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(61, 29);
            this.txtCount.TabIndex = 6;
            this.txtCount.Text = "1";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "位数";
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStart.Location = new System.Drawing.Point(438, 6);
            this.txtStart.MaxLength = 4;
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(61, 29);
            this.txtStart.TabIndex = 4;
            this.txtStart.Text = "0";
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtStart, "此地址为设备地址，MODBUS地址要加一");
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "起始地址";
            this.toolTip1.SetToolTip(this.label7, "此地址为设备地址，MODBUS地址要加一");
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(92, 6);
            this.txtAddress.MaxLength = 3;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(38, 29);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "1";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "从站地址";
            // 
            // btnWriteValue
            // 
            this.btnWriteValue.Location = new System.Drawing.Point(465, 71);
            this.btnWriteValue.Name = "btnWriteValue";
            this.btnWriteValue.Size = new System.Drawing.Size(93, 35);
            this.btnWriteValue.TabIndex = 18;
            this.btnWriteValue.Text = "写入V区";
            this.btnWriteValue.UseVisualStyleBackColor = true;
            this.btnWriteValue.Click += new System.EventHandler(this.btnWriteValue_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Red;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 502);
            this.Controls.Add(this.btnWriteValue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnOffTimer);
            this.Controls.Add(this.btnOpenCom);
            this.Controls.Add(this.gBoxCOM);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Modbus_RTU测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gBoxCOM.ResumeLayout(false);
            this.gBoxCOM.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gBoxCOM;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStopBit;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Button btnOffTimer;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.RichTextBox rtbValue;
        private System.Windows.Forms.TextBox txtSendStr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSaveTxt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

