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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace wareHouse
{
    public partial class frmProcurement : Form
    {
        private static string PID;//内部编号
        private static string USERID;//用户ID
        private static string USERNAME;//用户姓名
        private static string CHECK;//是否审核
        /// <summary>
        /// 是否保存成功
        /// </summary>
        bool Status = false;
        Dictionary<string, object> dictionary;
        public frmProcurement()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 重载构造函数，获取登录信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userId">用户编号</param>
        public frmProcurement(string userName,string userId)
        {
            InitializeComponent();
            USERNAME = userName;
            USERID = userId;
        }

        private void frmProcurement_Load(object sender, EventArgs e)
        {
            UserName.Text = USERNAME;
            //txtAmount.Text = "0";//总金额默认为0
            dgvProcurement.AllowUserToAddRows = false;
            Getsupplier();//获取供应商
            Inventory();//获取产品
            SaleBing();//获取折扣
            GetClient();//获取客户
        }
        /// <summary>
        /// 获取供应商信息
        /// </summary>
        private void Getsupplier()
        {
            dictionary = new Dictionary<string, object>();
            dictionary.Add("supplierNumber",0);
            dictionary.Add("type", 1);
            cbbSupplierName.DataSource = BLL.GetSupplier(dictionary);
            cbbSupplierName.DisplayMember = "supplierName";
            cbbSupplierName.ValueMember = "supplierNumber";
        }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        private void GetClient()
        {
            cbbClient.DisplayMember = "customerName";
            cbbClient.ValueMember = "customerNumber";
            dictionary = new Dictionary<string, object>();
            dictionary.Add("customerNumber",null);
            dictionary.Add("type", 1);
            cbbClient.DataSource = BLL.GetCustomer(dictionary);
        }
        /// <summary>
        /// 新建按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否新建？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Clear(groupBox2);//清空基础信息框
                Clear(groupBox3);//清空采购货物框
                toolStripButton2.Enabled = true;
            }
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
                    if (item.Name == "txtunitPrice")
                        continue;
                    if (item.Name == "txtAmount")
                    {
                        item.Text = "0";
                        continue;
                    }
                    if (item.Name=="txtsellPrice")
                        continue;
                    item.Text = string.Empty;
                }
                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    cb.Checked = false;
                }
                //if (item is ComboBox)
                //{
                //    ComboBox cbb = item as ComboBox;
                //    cbb.SelectedIndex = -1;
                //}
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
                UserName.Text = USERNAME;//采购员填写
            }
        }
        /// <summary>
        /// 检查信息,并且保存
        /// </summary>
        private void Inspect()
        {
            int errorcount = 0;
            foreach (Control item in groupBox2.Controls)
            {
                if (item.Name=="txtorderid")
                {
                    continue;
                }
                if (string.IsNullOrEmpty(item.Text.Trim()))
                    errorcount++;
            }
            if (errorcount > 0)
            {
                MessageBox.Show("请将基础信息填写完整！", "系统提示");
                return;
            }
            if (dgvProcurement.Rows.Count > 0)
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("internalOrderNumber", txtPID.Text);
                if (BLL.QueryPID(dictionary) <= 0)
                {
                    //插入数据
                    dictionary = new Dictionary<string, object>();
                    dictionary.Add("internalOrderNumber", txtPID.Text);
                    dictionary.Add("officialOrderNumber", txtorderid.Text);
                    dictionary.Add("operatorID", USERID);
                    dictionary.Add("customerID", dtpBuy.Value);
                    dictionary.Add("arrivalTime", dtpArrival.Value);
                    dictionary.Add("creationTime", cbbClient.SelectedValue.ToString());
                    //dictionary.Add("auditStatus",0);
                    //dictionary.Add("completeState",0);
                    dictionary.Add("type",1);
                    int procurement = BLL.ExecuteProcurement(dictionary);
                    if (procurement > 0)
                    {
                        for (int i = 0; i < dgvProcurement.Rows.Count; i++)
                        {
                            DataGridViewRow dgvr = dgvProcurement.Rows[i];
                            dictionary = new Dictionary<string, object>();
                            dictionary.Add("internalOrderNumber", txtPID.Text);
                            dictionary.Add("productID", dgvr.Cells["proID"].Value.ToString());
                            dictionary.Add("supportingProducts",Convert.ToBoolean(dgvr.Cells["parts"].Value));
                            dictionary.Add("supplierNumber",Convert.ToInt32(dgvr.Cells["supID"].Value.ToString()));
                            dictionary.Add("purchaseQuantity",Convert.ToInt32(dgvr.Cells["amount"].Value.ToString()));
                            dictionary.Add("invoice", Convert.ToBoolean(dgvr.Cells["ischeck"].Value));
                            dictionary.Add("purchaseRemark", rtbRemark.Text);
                            dictionary.Add("type",1);
                            int procargo = BLL.InsProcargo(dictionary);
                        }
                        MessageBox.Show("操作成功！请等待审核。。。", "系统提示");
                        PID = txtPID.Text;
                        Clear(groupBox2);
                        Clear(groupBox3);
                        Status = true;
                    }
                }
                else
                {
                    MessageBox.Show("该内部订单号已存在！", "系统提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("货物为空！", "系统提示");
                return;
            }
        }
        /// <summary>
        /// 保存操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("是否保存？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Inspect();
            }
        }
        /// <summary>
        /// 产品名称获取
        /// </summary>
        private void Inventory()
        {
            dictionary = new Dictionary<string, object>();
            dictionary.Add("inventoryNumber",null);
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
            cbbName.DisplayMember = "Value";
            cbbName.ValueMember = "Key";
            BindingSource bs = new BindingSource();
            bs.DataSource = modeldictionary;
            cbbName.DataSource = bs;
        }
        /// <summary>
        /// 折扣率
        /// </summary>
        private void SaleBing()
        {
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
            cbbSale.DataSource = bs;
            cbbSale.DisplayMember = "Key";
            cbbSale.ValueMember = "Value";
        }
        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text.Trim()))
                    {
                        MessageBox.Show("请填写完整！", "系统提示");
                        return;
                    }
                }
            }

            //判断是否存在某一条数据与之相同
            int index = -1;
            foreach (DataGridViewRow item in dgvProcurement.Rows)
            {
                if (item.Cells["proID"].Value.ToString()==cbbName.SelectedValue.ToString())
                {
                    index = item.Index;
                    break;
                }
            }
            if (index == -1)
            {
                //-1：不存在相同数据，添加数据
                DataGridViewRow dgvr = new DataGridViewRow();
                string[] items = new string[] { cbbName.SelectedValue.ToString(), cbbSupplierName.SelectedValue.ToString(), cbbName.Text, txtNumber.Text, cbbSupplierName.Text, cbbSale.SelectedValue.ToString(),cbParts.Checked.ToString(),cbcheck.Checked.ToString(),rtbRemark.Text };
                for (int i = 0; i < items.Count(); i++)
                {
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    txtcell.Value = items[i];
                    dgvr.Cells.Add(txtcell);
                }
                dgvProcurement.Rows.Add(dgvr);
                txtNumber.Text = string.Empty;
            }
            else
            {
                //如果相同则只需要增加数量或者修改单价
                DataGridViewRow dr = dgvProcurement.Rows[index];
                int amount = Convert.ToInt32(dr.Cells["amount"].Value);
                amount+= Convert.ToInt32(txtNumber.Text);
                dr.Cells["amount"].Value = amount;
                txtNumber.Text = string.Empty;
            }
        }
        /// <summary>
        /// 打印采购单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (Status)
            {
                if (Convert.ToBoolean(CHECK) == false)
                {
                    MessageBox.Show("该订单尚未审核，无法打印", "系统提示");
                    return;
                }
                frmReport report = new frmReport(PID,0);
                report.Show();
            }
            else
            {
                MessageBox.Show("文档尚未保存，无法打印采购订单！", "系统提示");
                return;
            }
        }
        ///// <summary>
        ///// 返回总金额
        ///// </summary>
        //private void setAmount()
        //{
        //    double allamount = 0;
        //    for (int i = 0; i < dgvProcurement.Rows.Count; i++)
        //    {
        //        double money = Convert.ToDouble(Decimal.Parse(dgvProcurement.Rows[i].Cells["unitprice"].Value.ToString(), System.Globalization.NumberStyles.Currency));
        //        int amount = Convert.ToInt32(dgvProcurement.Rows[i].Cells["amount"].Value);
        //        double discount = Convert.ToDouble(dgvProcurement.Rows[i].Cells["discount"].Value);
        //        allamount += (money * amount * discount);
        //    }
        //    txtAmount.Text = string.Format("{0:C2}",Decimal.Parse(allamount.ToString()));
        //}
        ///// <summary>
        ///// 单元格内容发生改变时，重新计算总金额
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void dgvProcurement_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        setAmount();
        //    }
        //    catch (Exception)
        //    {
        //        return;
        //    }
        //}
        /// <summary>
        /// 通过编号查询详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSelect_Click(object sender, EventArgs e)
        {
            //查询操作
            if (string.IsNullOrEmpty(tstxtPID.Text.Trim()))
            {
                MessageBox.Show("请输入查询编号", "系统提示");
                return;
            }
            dictionary = new Dictionary<string, object>();
            dictionary.Add("internalOrderNumber", tstxtPID.Text);
            dictionary.Add("type", 3);
            DataTable dt = BLL.QueryProcurement(dictionary);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                CHECK = dr["auditStatus"].ToString();
                txtPID.Text = dr["internalOrderNumber"].ToString();
                txtorderid.Text = dr["officialOrderNumber"].ToString();
                UserName.Text = dr["operatorID"].ToString();
                cbbClient.Text = dr["customerID"].ToString();
                dtpBuy.Value = Convert.ToDateTime(dr["creationTime"]);
                dtpArrival.Value = Convert.ToDateTime(dr["arrivalTime"]);
                //将数据添加到DataGridView中
                //清空DataGridView中的数据
                dgvProcurement.Rows.Clear();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    dr = dt.Rows[j];
                    DataGridViewRow selectdgvr = new DataGridViewRow();
                    string[] items = new string[] { dr["productID"].ToString(), dr["supplierNumber"].ToString(), dr["productName"].ToString()+"("+ dr["PNID"].ToString()+")"
                        , dr["supplierName"].ToString(), dr["discount"].ToString(), dr["isParts"].ToString(), (dr["isInvoice"]).ToString(),dr["purchaseRemark"].ToString() } ;
                    for (int i = 0; i < items.Count(); i++)
                    {
                        DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                        txtcell.Value = items[i];
                        selectdgvr.Cells.Add(txtcell);
                    }
                    dgvProcurement.Rows.Add(selectdgvr);
                }
                //不允许保存
                toolStripButton2.Enabled = false;
                PID = tstxtPID.Text;
                Status = true;
            }
            else
            {
                tstxtPID.SelectAll();
                MessageBox.Show("查无此订单号！", "系统提示");
                return;
            }
        }
        /// <summary>
        /// 打印收货通知单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Status)
            {
                if (Convert.ToBoolean(CHECK)==false)
                {
                    MessageBox.Show("该订单尚未审核，无法打印","系统提示");
                    return;
                }
                frmReport report = new frmReport(PID,1);
                report.Show();
            }
            else
            {
                MessageBox.Show("文档尚未保存，无法打印！", "系统提示");
                return;
            }
        }
        /// <summary>
        /// 允许Enter
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
        /// <summary>
        /// 不允许输入特殊符号，除了退格键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NaturalKeyPress(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0' || e.KeyChar <= 'z' && e.KeyChar >= 'a' || e.KeyChar <= 'Z' && e.KeyChar >= 'A' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        /// <summary>
        /// 当销售价格输入完毕之后自动转化为￥形式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSellPrice_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                tb.Text = string.Format("{0:C2}", Convert.ToDecimal(tb.Text));
            }
            catch (Exception)
            {
                return;
            }
        }
        /// <summary>
        /// 文本框只允许输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyPress(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0' || e.KeyChar == '.' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtSellPrice_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                tb.Text = Decimal.Parse(tb.Text, System.Globalization.NumberStyles.Currency).ToString();
            }
            catch
            {
                tb.Text = "0";
            }
        }

        private void txtPID_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.Text = tb.Text.Trim().ToUpper();
        }
    }
}
