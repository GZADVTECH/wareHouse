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
        int index = 0;//序号
        public frmDelivery()
        {
            InitializeComponent();
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
            DataTable dt = BLL.QueryContractOrder(tstxtPID.Text);
            if (dt.Rows.Count!=0)
            {
                txtContract.Text = dt.Rows[0]["contractOrder"].ToString();
                cbbClientName.SelectedValue = dt.Rows[0]["clientID"].ToString();
                foreach (DataRow dr in dt.Rows)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    //////////////////////////未完成///////////////////////////////
                }
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
                if (item.Cells["proID"].Value.ToString() == cbbPNID.SelectedValue.ToString())
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
                string[] items = new string[] { (++index).ToString(),cbbPNID.SelectedValue.ToString(), cbbproName.Text, cbbPNID.Text, txtNumber.Text,txtPrice.Text,cbbSale.SelectedValue.ToString(),(str*strs*strss).ToString() };
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
                int str = Convert.ToInt32(txtNumber.Text);
                double strs = Convert.ToDouble(Decimal.Parse(txtPrice.Text.ToString(), System.Globalization.NumberStyles.Currency));
                float strss = Convert.ToSingle(cbbSale.SelectedValue);
                //如果相同则只需要增加数量或者修改单价
                DataGridViewRow dr = dgvPro.Rows[index];
                int amount = Convert.ToInt32(dr.Cells["amount"].Value);
                amount += Convert.ToInt32(txtNumber.Text);
                dr.Cells["amount"].Value = amount;
                double subtotal=Convert.ToDouble(dr.Cells["subtotal"].Value);
                subtotal += (str * strs * strss);
                dr.Cells["subtotal"].Value = subtotal;
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
            cbb.DisplayMember = "cName";
            cbb.ValueMember = "autoID";
            cbb.DataSource = BLL.GetClient(0, "", "", "");
        }
        /// <summary>
        /// 产品名称获取
        /// </summary>
        private void Inventory(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            cbb.DisplayMember = "productName";
            cbb.DataSource = BLL.GetInventory(4, new string[] { "", "", "", "", "", "", "" });
        }
        private void frmDelivery_Load(object sender, EventArgs e)
        {
            SaleBing(cbbSale);//折扣绑定
            cbbSale.SelectedIndex = 0;
            GetClient(cbbClientName);//客户绑定
            cbbClientName.SelectedIndex = 0;
            Inventory(cbbproName);//产品名称绑定
            cbbPNID.SelectedIndex = 0;
            cbbCtrackingName.SelectedIndex = 0;//快递公司默认显示第一个

            dgvPro.AutoGenerateColumns = false;
            dgvPro.AllowUserToAddRows = false;
        }
        /// <summary>
        /// 选中规格显示价格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbPNID_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //查询价格之后更新
                string[] data = new string[] { "", cbbproName.Text, cbbPNID.Text, "", "", "", "" };
                txtPrice.Text = string.Format("{0:C2}", Convert.ToDecimal(BLL.GetInventory(5, data).Rows[0]["sellPrice"].ToString()));
            }
            catch (Exception)
            {
                txtPrice.Text = "0";
            }
        }
        /// <summary>
        /// 选中名称修改规格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbproName_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbPNID.DisplayMember = "PNID";
            cbbPNID.ValueMember = "productID";
            string[] data = new string[] { "", cbbproName.Text, "", "", "", "", "" };
            cbbPNID.DataSource = BLL.GetInventory(0, data);
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
                string[] data = new string[] { "", dgvr.Cells["name"].Value.ToString(), dgvr.Cells["pnid"].Value.ToString(), "", "", "", "" };
                DataTable dt = BLL.GetInventory(5, data);
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

        }
        /// <summary>
        /// 新建清空信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_Click(object sender, EventArgs e)
        {
            Clear(groupBox2);
            txtNumber.Text = string.Empty;
        }

        private void dgvPro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dgvc = dgvPro[e.ColumnIndex, e.RowIndex];
            string num = dgvc.Value.ToString();
            if (Convert.ToInt32(dgvc.Value)<=0)
            {
                MessageBox.Show("数量不允许小于等于零", "系统提示");
                dgvc.Value = num;
            }
            else
            {
                int amount = Convert.ToInt32(dgvPro["amount", e.RowIndex].Value);
                float sale = Convert.ToSingle(dgvPro["sale", e.RowIndex].Value);
                double sellprice = Convert.ToDouble(Decimal.Parse(dgvPro["sellprice", e.RowIndex].Value.ToString(),System.Globalization.NumberStyles.Currency));
                dgvPro["subtotal", e.RowIndex].Value = amount * sale * sellprice;
            }
        }
    }
}
