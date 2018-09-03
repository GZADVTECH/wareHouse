using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wareHouse
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //数据是否填写完整
            if (string.IsNullOrEmpty(txtUid.Text))
            {
                MessageBox.Show("账号不允许为空！", "系统提示", MessageBoxButtons.OK);
                txtUid.Focus();
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("密码不允许为空！", "系统提示", MessageBoxButtons.OK);
                txtPwd.Focus();
            }

        }
    }
}
