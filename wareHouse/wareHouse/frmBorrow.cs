using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHBLL;

namespace wareHouse
{
    public partial class frmBorrow : Form
    {
        /// <summary>
        /// 全局Dictionary
        /// </summary>
        Dictionary<string, object> dictionary;
        /// <summary>
        /// 用户ID
        /// </summary>
        string USERID;
        public frmBorrow(string userid)
        {
            InitializeComponent();
            this.USERID = userid;
        }
        /// <summary>
        /// 新建清空所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if(item is ComboBox)
                {
                    ComboBox cbb = (ComboBox)item;
                    cbb.SelectedIndex = 0;
                }
                if (item is RichTextBox)
                    item.Text = string.Empty;
                if(item is ListBox)
                {
                    ListBox lb = (ListBox)item;
                    lb.Items.Clear();
                }
                if(item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    cb.Checked = false;
                }
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSave_Click(object sender, EventArgs e)
        {
            //验证
            if (cbbproname.SelectedValue==null)
            {
                MessageBox.Show("请选择产品！", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                MessageBox.Show("请输入数量！", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(txtBorrower.Text.Trim()))
            {
                MessageBox.Show("请输入借货人！", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(dtpBorrowTime.Text.Trim()))
            {
                MessageBox.Show("借出时间不正确！", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(dtpReturnTime.Text.Trim()))
            {
                MessageBox.Show("归还时间不正确！", "系统提示");
                return;
            }
            if (lbSNCode.SelectedItems.Count!=Convert.ToInt32(txtQuantity.Text))
            {
                MessageBox.Show("请选择相应数量的SN码！", "系统提示");
                return;
            }
            //验证是否存在
            if (string.IsNullOrEmpty(txtNumber.Text.Trim()))
            {
                //新建
                string SNCodes="";
                foreach (var item in lbSNCode.SelectedItems)
                    SNCodes = item + ",";
                dictionary = new Dictionary<string, object>();
                dictionary.Add("borrowNumber",null);
                dictionary.Add("borrowProductID",cbbproname.SelectedValue);
                dictionary.Add("borrowSNCode", SNCodes);
                dictionary.Add("borrowQuantity",txtQuantity.Text);
                dictionary.Add("borrower",txtBorrower.Text);
                dictionary.Add("borrowOperatorID",USERID);
                dictionary.Add("borrowTime",dtpBorrowTime.Value);
                dictionary.Add("borrowReturnTime",dtpReturnTime.Value);
                dictionary.Add("IsReturn",cbReturn.Checked);
                dictionary.Add("borrowRemark",rtbRemark.Text);
                dictionary.Add("borrowStatus", cbReturn.Checked ? 1 : 0);
                dictionary.Add("type",1);
                if (BLL.ExecuteBorrow(dictionary)>0)
                {
                    MessageBox.Show("新建成功！", "系统提示");
                    //更新数据
                    tsbNew_Click(sender, e);

                    dictionary = new Dictionary<string, object>();
                    dictionary.Add("borrownumber", null);
                    dictionary.Add("type", 1);
                    dgvBorrow.DataSource = BLL.GetBorrow(dictionary);
                }
            }
            else
            {
                //更改
                string SNCodes = "";
                foreach (var item in lbSNCode.SelectedItems)
                    SNCodes = item + ",";
                dictionary = new Dictionary<string, object>();
                dictionary.Add("borrowNumber", null);
                dictionary.Add("borrowProductID", cbbproname.SelectedValue);
                dictionary.Add("borrowSNCode", SNCodes);
                dictionary.Add("borrowQuantity", txtQuantity.Text);
                dictionary.Add("borrower", txtBorrower.Text);
                dictionary.Add("borrowOperatorID", USERID);
                dictionary.Add("borrowTime", dtpBorrowTime.Value);
                dictionary.Add("borrowReturnTime", dtpReturnTime.Value);
                dictionary.Add("IsReturn", cbReturn.Checked);
                dictionary.Add("borrowRemark", rtbRemark.Text);
                dictionary.Add("borrowStatus", cbReturn.Checked?1:0);
                dictionary.Add("type", 2);
                if (BLL.ExecuteBorrow(dictionary) > 0)
                {
                    MessageBox.Show("更新成功！", "系统提示");
                    //更新数据
                    tsbNew_Click(sender, e);

                    dictionary = new Dictionary<string, object>();
                    dictionary.Add("borrownumber", null);
                    dictionary.Add("type", 1);
                    dgvBorrow.DataSource = BLL.GetBorrow(dictionary);
                }
            }
        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            Inventory(cbbproname);//绑定产品名称及规格型号
            dictionary = new Dictionary<string, object>();
            dictionary.Add("borrownumber",null);
            dictionary.Add("type", 1);
            dgvBorrow.DataSource = BLL.GetBorrow(dictionary);
        }

        /// <summary>
        /// 产品名称获取
        /// </summary>
        private void Inventory(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("inventoryNumber", null);
            dictionary.Add("productID", null);
            dictionary.Add("productName", null);
            dictionary.Add("model", null);
            dictionary.Add("type", 5);
            DataTable dt = BLL.GetStock(dictionary);
            Dictionary<string, string> modeldictionary = new Dictionary<string, string>();
            foreach (DataRow item in dt.Rows)
            {
                modeldictionary.Add(item["productID"].ToString(), string.Format(item["productName"].ToString() + "(" + item["model"].ToString() + ")"));
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = modeldictionary;
            cbb.DisplayMember = "Value";
            cbb.ValueMember = "Key";
            cbb.DataSource = bs;
        }
        /// <summary>
        /// 当产品编号改变时SN码也随之改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbproname_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbproname.SelectedValue!=null)
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("productID", cbbproname.SelectedValue);
                dictionary.Add("SNCode", null);
                dictionary.Add("type", 3);
                lbSNCode.DataSource = BLL.QuerySNID(dictionary);
                lbSNCode.DisplayMember = "SNCode";
                lbSNCode.ValueMember = "serialNumber";
            }
        }
        /// <summary>
        /// 选中添加详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBorrow.SelectedRows[0].Index < 0)
                return;
            txtNumber.Text = dgvBorrow.SelectedRows[0].Cells["borrowNumber"].Value.ToString();//借货编号
            txtQuantity.Text = dgvBorrow.SelectedRows[0].Cells["borrowQuantity"].Value.ToString();//借货数量
            txtBorrower.Text = dgvBorrow.SelectedRows[0].Cells["borrower"].Value.ToString();//借货人
            dtpBorrowTime.Text = dgvBorrow.SelectedRows[0].Cells["borrowTime"].Value.ToString();//借货时间
            dtpReturnTime.Text = dgvBorrow.SelectedRows[0].Cells["borrowReturnTime"].Value.ToString();//归还时间
            rtbRemark.Text = dgvBorrow.SelectedRows[0].Cells["borrowRemark"].Value.ToString();//备注
            cbbproname.SelectedValue = dgvBorrow.SelectedRows[0].Cells["borrowProductID"].Value;//产品名称
            cbReturn.Checked = Convert.ToBoolean(dgvBorrow.SelectedRows[0].Cells["IsReturn"].Value);//是否归还
            string[] SNCodessubstring = dgvBorrow.SelectedRows[0].Cells["borrowSNCode"].Value.ToString().Split(',');
            foreach (string item in SNCodessubstring)
                lbSNCode.SelectedItem = item;

        }
    }
}
