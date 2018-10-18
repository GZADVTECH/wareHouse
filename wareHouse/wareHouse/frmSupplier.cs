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
    public partial class frmSupplier : Form
    {
        private string USERID;
        public frmSupplier(string userid)
        {
            InitializeComponent();
            this.USERID = userid;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            GetSupplier();
        }
        /// <summary>
        /// 获取供应商信息
        /// </summary>
        private void GetSupplier()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("supplierNumber", null);
            dictionary.Add("type", 1);
            DataTable dt = WHBLL.BLL.GetSupplier(dictionary);//获取供应商信息
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.AllowUserToAddRows = false;
            dgvSupplier.DataSource = dt;//绑定
        }
        /// <summary>
        /// 提交操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定提交？","系统提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                //验证
                foreach (Control control in groupBox1.Controls)
                {
                    if (control.Name == "txtID" || control.Name == "txtRemark")
                        continue;
                    if (control is TextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text.Trim()))
                        {
                            MessageBox.Show("请将信息填写完整！", "系统提示");
                            return;
                        }
                    }
                }
                //执行操作
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("supplierNumber", string.IsNullOrEmpty(txtID.Text.Trim()) ? 0 : Convert.ToInt32(txtID.Text.Trim()));
                dictionary.Add("supplierName", txtName.Text.Trim());
                dictionary.Add("supplierInfo", txtMessage.Text.Trim());
                dictionary.Add("supplierRemark", txtRemark.Text.Trim());
                dictionary.Add("supplierIperatorID", USERID);
                dictionary.Add("type", string.IsNullOrEmpty(txtID.Text.Trim()) ? 1 : 2);
                if (WHBLL.BLL.ExecuteSupplier(dictionary) > 0)
                {
                    MessageBox.Show("操作成功！", "系统提示");
                    //更新查询
                    GetSupplier();
                    //清空内容
                    foreach (Control control in groupBox1.Controls)
                    {
                        if (control is TextBox)
                            control.Text = string.Empty;
                    }
                }
            }
        }
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 停止供应ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WHBLL.BLL.ChangeStatus(Convert.ToInt32(dgvSupplier.SelectedRows[0].Cells["supplierNumber"].Value)) > 0)
            {
                MessageBox.Show("操作成功", "系统提示");
                //更新内容
                dgvSupplier.Rows.RemoveAt(dgvSupplier.SelectedRows[0].Index);
            }
        }
    }
}
