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
    public partial class frmClient : Form
    {
        private string ID;
        private string NAME;
        public frmClient(string id,string name)
        {
            InitializeComponent();
            this.ID = id;
            this.NAME = name;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("customerNumber", null);
            dictionary.Add("type", 1);
            ClientData(dictionary);
            rdbMan.Checked=true;

        }

        private void ClientData(Dictionary<string,object> dictionary)
        {
            dgvClient.AutoGenerateColumns = false;//不自动生成列
            dgvClient.AllowUserToAddRows = false;//最后一行不添加空白行
            dgvClient.DataSource = WHBLL.BLL.GetCustomer(dictionary);
            //dgvClient.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;//选中全行
        }
        /// <summary>
        /// 选中添加入客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClient.SelectedRows[0].Index<0)
                return;
            int index = dgvClient.SelectedRows[0].Index;
            txtID.Text = dgvClient.Rows[index].Cells["autoID"].Value.ToString();
            txtCName.Text = dgvClient.Rows[index].Cells["cName"].Value.ToString();
            txtCWay.Text = dgvClient.Rows[index].Cells["cway"].Value.ToString();
            rtbAddress.Text = dgvClient.Rows[index].Cells["cAddress"].Value.ToString();
            txtCompany.Text= dgvClient.Rows[index].Cells["Company"].Value.ToString();
            rtbRemark.Text= dgvClient.Rows[index].Cells["Remark"].Value.ToString();
            if (Convert.ToBoolean(dgvClient.Rows[index].Cells["customerGender"].Value))
                rdbMan.Checked = true;
            else
                rdbWoman.Checked = true;
        }
        /// <summary>
        /// 清空客户信息表单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        /// <summary>
        /// 清空
        /// </summary>
        private void Clear()
        {
            txtID.Text = string.Empty;
            txtCName.Text = string.Empty;
            txtCWay.Text = string.Empty;
            rtbAddress.Text = string.Empty;
            txtCompany.Text = string.Empty;
            rtbRemark.Text = string.Empty;
            rdbMan.Checked = true;
        }
        /// <summary>
        /// 提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //检验是否填写完整
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name=="txtID")
                        continue;
                    if (control.Name == "rtbRemark")
                        continue;
                    if (string.IsNullOrEmpty(control.Text.Trim()))
                    {
                        MessageBox.Show("请将数据填写完整！", "系统提示");
                        return;
                    }
                }
            }
            int id;
            if (string.IsNullOrEmpty(txtID.Text))
                id = 0;
            else
                id = Convert.ToInt32(txtID.Text);
            if (MessageBox.Show("是否提交？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("customerNumber",txtID.Text);
                dictionary.Add("customerName",txtCName.Text);
                dictionary.Add("customerGender",(rdbMan.Checked)?1:0);
                dictionary.Add("customerCompany",txtCompany.Text);
                dictionary.Add("customerContactinfo",txtCWay.Text);
                dictionary.Add("customerContactAddress",rtbAddress.Text);
                dictionary.Add("customerRemark",rtbRemark.Text);
                dictionary.Add("customerStatus",1);
                dictionary.Add("customerOperatorID",ID);
                dictionary.Add("type",1);
                int dt = WHBLL.BLL.ExecuteCustomer(dictionary);
                if (dt>0)
                {
                    MessageBox.Show("操作成功!");
                    dictionary = new Dictionary<string, object>();
                    dictionary.Add("customerNumber", null);
                    dictionary.Add("type", 1);
                    ClientData(dictionary);
                    Clear();
                }
                else
                    MessageBox.Show("操作失败！");
            }
        }
    }
}
