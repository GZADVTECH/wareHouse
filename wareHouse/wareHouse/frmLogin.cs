using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
                return;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("密码不允许为空！", "系统提示", MessageBoxButtons.OK);
                txtPwd.Focus();
                return;
            }
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("", txtUid.Text);
            dictionary.Add("", txtPwd.Text);
            dictionary.Add("type", 2);
            DataTable i = BLL.VerificationLogin(dictionary);
            if (i.Rows.Count > 0)
            {
                //将登录成功的用户名登记到文本框中，方便下次输入
                string s = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                string path = s + "user.dll";
                if (File.Exists(path))//判断文件是否存在
                {
                    if (!this.txtUid.AutoCompleteCustomSource.Contains(this.txtUid.Text))//判断记录是否存在
                    {
                        StreamWriter sw = new StreamWriter(path, true);//不覆盖以前存入的记录
                        sw.WriteLine(this.txtUid.Text.Trim());//存入记录
                        sw.Close();
                        if (!this.txtUid.AutoCompleteCustomSource.Contains(this.txtUid.Text))
                        {
                            this.txtUid.AutoCompleteCustomSource.Add(this.txtUid.Text);
                        }
                    }
                }
                //存储ID，姓名及权限
                userMessage um = new userMessage();
                um.userID = i.Rows[0]["loginNumber"].ToString();
                um.userName = i.Rows[0]["userName"].ToString();
                um.userLimit = Convert.ToInt32(i.Rows[0]["userRights"]);
                //进入主页面
                frmMainWindow mw = new frmMainWindow(um);
                mw.Show();
                this.Hide();
            }
            else
            {
                txtPwd.SelectAll();
                MessageBox.Show("登录失败！");
            }
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSelf self = new frmSelf();
            self.ShowDialog();
        }
        /// <summary>
        /// 默认加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //将登录成功的用户名登记到文本框中，方便下次输入
            string s = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string path = s + "user.dll";
            if (File.Exists(path))//判断文件是否存在
            {
                StreamReader sr = new StreamReader(path, true);
                string str = sr.ReadLine();
                txtUid.Text = str;
                this.txtUid.AutoCompleteCustomSource.Add(str);
                sr.Close();
            }
        }
        /// <summary>
        /// 账号输入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUid_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string path = s + "user.dll";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path, true);
                string str = sr.ReadLine();
                while (str != null)//判断不为空行
                {
                    if (!this.txtUid.AutoCompleteCustomSource.Contains(str))
                    {
                        this.txtUid.AutoCompleteCustomSource.Add(str);
                    }
                    str = sr.ReadLine();
                }
                sr.Close();
            }
        }
    }
}
