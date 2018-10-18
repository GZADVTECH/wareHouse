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
    public partial class frmDelivery : Form
    {
        bool STATE = false;//是否允许打印送货单
        private string ID;//ID
        private string NAME;//NAME
        Dictionary<string, object> dictionary;
        DataTable dt;
        public frmDelivery()
        {
            InitializeComponent();
        }
        public frmDelivery(string id,string name)
        {
            InitializeComponent();
            this.ID = id;
            this.NAME = name;
        }
        /// <summary>
        /// 打印送货单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport(3);
            report.ShowDialog();
        }
        /// <summary>
        /// 查询合同订单号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSelect_Click(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, object>();
            dictionary.Add("officialOrderNumber", tstxtPID.Text);
             dt = BLL.QueryContractOrder(dictionary);
            if (dt.Rows.Count!=0)
            {
                txtContract.Text = dt.Rows[0]["officialOrderNumber"].ToString();
                cbbClientName.SelectedValue = dt.Rows[0]["customerinfo"].ToString();
                foreach (DataRow dr in dt.Rows)
                {
                    int index = 0;//序号
                    dgvPro.Rows.Clear();//清空DataGridView的数据
                    DataGridViewRow dgvr = new DataGridViewRow();
                    string allprice = (Convert.ToDouble(dr["inventoryQuantity"].ToString()) * Convert.ToDouble(dr["salesPrice"].ToString()) * Convert.ToDouble(string.IsNullOrEmpty(dr["outgoingDiscount"].ToString()) ? "1" : dr["outgoingDiscount"].ToString())).ToString();
                    string[] item = new string[] { (++index).ToString(), dr["productID"].ToString(),dr["productName"].ToString(), dr["model"].ToString(), dr["inventoryQuantity"].ToString(), dr["salesPrice"].ToString(), dr["salesincludeTax"].ToString(), string.IsNullOrEmpty(dr["outgoingDiscount"].ToString()) ? "1" : dr["outgoingDiscount"].ToString(),allprice  };
                    for (int i = 0; i < item.Count(); i++)
                    {
                        DataGridViewTextBoxCell dgvtbc = new DataGridViewTextBoxCell();
                        dgvtbc.Value = item[i];
                        dgvr.Cells.Add(dgvtbc);
                    }
                    dgvPro.Rows.Add(dgvr);
                }
            }
            else
            {
                MessageBox.Show("查无此合同订单号详细信息，请核对之后重试！", "系统提示");
                return;
            }
        }
        /// <summary>
        /// 回车查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tstxtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tsbtnSelect_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //判断数据是否输入完整
            if (string.IsNullOrEmpty(txtNumber.Text.Trim())||txtNumber.Text=="0")
            {
                MessageBox.Show("请填写完整", "系统提示");
                return;
            }
            //判断是否存在某一条数据与之相同
            int index = -1;
            foreach (DataGridViewRow item in dgvPro.Rows)
            {
                if (item.Cells["productID"].Value.ToString() == cbbproName.SelectedValue.ToString())
                {
                    index = item.Index;
                    break;
                }
            }
            if (index == -1)
            {
                int str = Convert.ToInt32(txtNumber.Text);
                double strs =Convert.ToDouble(Decimal.Parse(txtPrice.Text.ToString(), System.Globalization.NumberStyles.Currency));
                float strss=Convert.ToSingle(cbbSale.SelectedValue);
                //-1：不存在相同数据，添加数据
                DataGridViewRow dgvr = new DataGridViewRow();
                string[] items = new string[] { (++index).ToString(),cbbproName.SelectedValue.ToString(), cbbproName.Text, txtNumber.Text,txtPrice.Text,cbTax.Checked.ToString(),cbbSale.SelectedValue.ToString(),(str*strs*strss).ToString() };
                for (int i = 0; i < items.Count(); i++)
                {
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    txtcell.Value = items[i];
                    dgvr.Cells.Add(txtcell);
                }
                dgvPro.Rows.Add(dgvr);
            }
            else
            {
                //如果相同则只需要增加数量或者修改单价或者修改折扣
                DataGridViewRow dr = dgvPro.Rows[index];
                int amount = Convert.ToInt32(dr.Cells["amount"].Value);
                amount += Convert.ToInt32(txtNumber.Text);
                dr.Cells["amount"].Value = amount;
                dr.Cells["sale"].Value=cbbSale.SelectedValue;
                int str = Convert.ToInt32(dr.Cells["amount"].Value);
                double strs = Convert.ToDouble(Decimal.Parse(dr.Cells["sellprice"].Value.ToString(), System.Globalization.NumberStyles.Currency));
                float strss = Convert.ToSingle(dr.Cells["sale"].Value.ToString());
                double subtotal = str * strs * strss;
                dr.Cells["subtotal"].Value = string.Format("{0:N2}", subtotal) ;
            }
        }
        /// <summary>
        /// 只允许输入数字和空格键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// 折扣率
        /// </summary>
        private void SaleBing(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            Dictionary<string, double> percent = new Dictionary<string, double>();
            percent.Add("100%", 1);
            percent.Add("90%", 0.9);
            percent.Add("80%", 0.8);
            percent.Add("70%", 0.7);
            percent.Add("60%", 0.6);
            percent.Add("50%", 0.5);
            percent.Add("40%", 0.4);
            percent.Add("30%", 0.3);
            percent.Add("20%", 0.2);
            percent.Add("10%", 0.1);

            BindingSource bs = new BindingSource();
            bs.DataSource = percent;
            cbb.DataSource = bs;
            cbb.DisplayMember = "Key";
            cbb.ValueMember = "Value";
        }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        private void GetClient(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            cbb.DisplayMember = "customerName";
            cbb.ValueMember = "customerNumber";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("customerNumber", null);
            dictionary.Add("type", 1);
            cbb.DataSource = BLL.GetCustomer(dictionary);
        }
        /// <summary>
        /// 产品名称获取
        /// </summary>
        private void Inventory(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("inventoryNumber",null);
            dictionary.Add("productID",null);
            dictionary.Add("productName",null);
            dictionary.Add("model",null);
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
        /// 默认加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDelivery_Load(object sender, EventArgs e)
        {
            txtName.Text = NAME;//发货人名称

            SaleBing(cbbSale);//折扣绑定
            cbbSale.SelectedIndex = 0;
            GetClient(cbbClientName);//客户绑定
            cbbClientName.SelectedIndex = 0;
            Inventory(cbbproName);//产品名称绑定
            cbbCtrackingName.SelectedIndex = 0;//快递公司默认显示第一个

            dgvPro.AutoGenerateColumns = false;
            dgvPro.AllowUserToAddRows = false;
        }
        /// <summary>
        /// 清空信息
        /// </summary>
        private void Clear(Control contrl)
        {
            foreach (Control item in contrl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    cb.Checked = false;
                }
                if (item is ComboBox)
                {
                    ComboBox cbb = item as ComboBox;
                    cbb.SelectedIndex = 0;
                }
                if (item is DateTimePicker)
                {
                    DateTimePicker dtp = item as DateTimePicker;
                    dtp.Value = DateTime.Now;
                }
                if (item is DataGridView)
                {
                    DataGridView dgv = item as DataGridView;
                    dgv.Rows.Clear();
                }
                //默认操作
            }
        }
        /// <summary>
        /// 保存操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSave_Click(object sender, EventArgs e)
        {
            //验证是否填写完整
            int errorcount = 0;
            foreach (Control item in groupBox2.Controls)
            {
                if (item.Name == "txtRemark") continue;
                if (string.IsNullOrEmpty(item.Text))
                    errorcount++;
            }
            if (errorcount!=0)
            {
                MessageBox.Show("请将数据填写完整", "系统提示");
                return;
            }
            if (dgvPro.Rows.Count<=0)
            {
                MessageBox.Show("货物信息不明确", "系统提示");
                return;
            }
            //验证成功查询是否有库存
            string message="";
            foreach (DataGridViewRow dgvr in dgvPro.Rows)
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("inventoryNumber",null);
                dictionary.Add("productID",dgvr.Cells["proID"].Value.ToString());
                dictionary.Add("productName", null);
                dictionary.Add("model", null);
                dictionary.Add("type",3);
                DataTable dt = BLL.GetStock(dictionary);
                int quantity = int.Parse(dt.Rows[0]["quantity"].ToString());
                if (int.Parse(dgvr.Cells["amount"].Value.ToString())>quantity)
                {
                    message += string.Format("{0}({1})库存只剩下{2}{3}\n", dgvr.Cells["name"].Value.ToString(), dgvr.Cells["pnid"].Value.ToString(), dt.Rows[0]["quantity"].ToString(), dt.Rows[0]["unit"].ToString());
                }
            }
            if (message.Length!=0)
            {
                message += "库存不足，无法下单";
                MessageBox.Show(message, "系统提示");
                return;
            }
            else
            {
                int error = 0;//错误次数
                string port = "";//未成功记录的数据
                foreach (DataGridViewRow dr in dgvPro.Rows)
                {
                    dictionary = new Dictionary<string, object>();
                    dictionary.Add("officialOrderNumber", txtContract.Text);
                    dictionary.Add("outgoingcustomerID", cbbClientName.SelectedValue.ToString());
                    dictionary.Add("outgoingproductID", dr.Cells["proID"].Value.ToString());
                    dictionary.Add("outgoingQuantity", dr.Cells["amount"].Value.ToString());
                    dictionary.Add("outgoingDiscount", dr.Cells["sale"].Value.ToString());
                    dictionary.Add("includeTax", dr.Cells["tax"].Value.ToString());
                    dictionary.Add("deliveryExpressnumber", txtCtrackingID.Text);
                    dictionary.Add("deliveryExpressCompany", cbbCtrackingName.SelectedText);
                    dictionary.Add("deliveryTime",DateTime.Now);
                    dictionary.Add("outgoingOperatorID",ID);
                    dictionary.Add("outgoingRemark",txtRemark.Text);
                    dictionary.Add("outgoingState",0);
                    dictionary.Add("type",1);
                    if(BLL.ExecuteDelivery(dictionary) > 0)
                    {
                        error++;
                    }
                    else
                    {
                        port += dr.Cells["autoid"].ToString()+",";
                    }
                }
                if (error>0)
                {
                    MessageBox.Show("提交成功！", "系统提示");
                }
                if (port.Length>0)
                {
                    port.Remove(port.Length - 1, 1);
                    MessageBox.Show(string.Format("以下序号：\n{0}\n提交失败！",port), "系统提示");
                    return;
                }
            }
        }
        /// <summary>
        /// 新建清空信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否新建？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Clear(groupBox2);
                txtNumber.Text = string.Empty;
                dgvPro.Rows.Clear();
            }
        }
        /// <summary>
        /// 输入结束验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dgvc = dgvPro[e.ColumnIndex, e.RowIndex];
            if (Convert.ToDouble(dgvc.Value)<=0)
            {
                MessageBox.Show("数量不允许小于等于零", "系统提示");return;
            }
            else
            {
                int amount = Convert.ToInt32(dgvPro["amount", e.RowIndex].Value);
                float sale = Convert.ToSingle(dgvPro["sale", e.RowIndex].Value);
                double sellprice = Convert.ToDouble(Decimal.Parse(dgvPro["sellprice", e.RowIndex].Value.ToString(),System.Globalization.NumberStyles.Currency));
                dgvPro["subtotal", e.RowIndex].Value = string.Format("{0:N2}",amount * sale * sellprice);
            }
        }
        /// <summary>
        /// 自动转化为大写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContract_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Text = tb.Text.ToUpper();
        }
        /// <summary>
        /// 选择之后显示该价格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbproName_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
