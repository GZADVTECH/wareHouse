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
        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            ClientData();
        }

        private void ClientData()
        {
            dgvClient.DataSource = WHBLL.BLL.GetClient(0, "", "", "");
            dgvClient.AutoGenerateColumns = false;//不自动生成列
            dgvClient.AllowUserToAddRows = false;//最后一行不添加空白行
            //dgvClient.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;//选中全行
        }
        /// <summary>
        /// 选中添加入客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvClient.SelectedRows[0].Index;
            txtID.Text = dgvClient.Rows[index].Cells["autoID"].Value.ToString();
            txtCName.Text = dgvClient.Rows[index].Cells["cName"].Value.ToString();
            txtCWay.Text = dgvClient.Rows[index].Cells["cway"].Value.ToString();
            rtbAddress.Text = dgvClient.Rows[index].Cells["cAddress"].Value.ToString();
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
        }
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSC_Click(object sender, EventArgs e)
        {
            DataTable dt = WHBLL.BLL.GetClient(0, txtSCName.Text, "", "");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该客户不存在");
            }
            else
            {
                txtID.Text = dt.Rows[0]["autoID"].ToString();
                txtCName.Text = dt.Rows[0]["cName"].ToString();
                txtCWay.Text = dt.Rows[0]["cway"].ToString();
                rtbAddress.Text = dt.Rows[0]["cAddress"].ToString();
            }
        }
        /// <summary>
        /// 提交按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCName.Text))
            {
                MessageBox.Show("客户姓名不允许为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtCWay.Text))
            {
                MessageBox.Show("联系方式不允许为空！");
                return;
            }
            if (string.IsNullOrEmpty(rtbAddress.Text))
            {
                MessageBox.Show("联系地址不允许为空！");
                return;
            }
            int id;
            if (string.IsNullOrEmpty(txtID.Text))
                id = 0;
            else
                id = Convert.ToInt32(txtID.Text);
            if (MessageBox.Show("是否提交？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataTable dt = WHBLL.BLL.GetClient(id, txtCName.Text, txtCWay.Text, rtbAddress.Text);
                if (dt != null)
                {
                    MessageBox.Show("操作成功!");
                    ClientData();
                    Clear();
                }
                else
                    MessageBox.Show("操作失败！");
            }
        }
    }
}
