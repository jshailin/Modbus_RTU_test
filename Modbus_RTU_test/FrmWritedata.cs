using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus_RTU_test
{
    public partial class FrmWritedata : Form
    {
        public FrmWritedata()
        {
            InitializeComponent();
        }

        public event Action<string, string, string> WriteVData; 
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Uri.IsHexDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnWriteValue_Click(object sender, EventArgs e)
        {
            #region 判断是否有数据
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("从站地址不能为空");
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStart.Text))
            {
                MessageBox.Show("数据地址不能为空");
                txtStart.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("十六进制数据不能为空");
                txtValue.Focus();
                return;
            } 
            #endregion
            WriteVData(txtAddress.Text, txtStart.Text, txtValue.Text);
        }

    }
}
