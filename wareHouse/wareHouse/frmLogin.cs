using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHBLL;
using WHMODELS;

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
            DataTable i = BLL.GetLogin(txtUid.Text, txtPwd.Text);
            if (i.Rows.Count > 0)
            {
                //存储ID，姓名及权限
                userMessage um = new userMessage();
                um.userID = i.Rows[0]["userID"].ToString();
                um.userName = i.Rows[0]["userName"].ToString();
                um.userLimit = Convert.ToInt32(i.Rows[0]["userLimit"]);
                //进入主页面
                frmMainWindow mw = new frmMainWindow(um);
                mw.Show();
                this.Hide();
            }
            else
                MessageBox.Show("登录失败！");
        }
    }
}
