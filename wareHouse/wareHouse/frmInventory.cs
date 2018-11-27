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
    public partial class frmInventory : Form
    {
        Dictionary<string, object> dictionary;
        private string USERID;
        DataTable dt;
        public frmInventory(string userid)
        {
            InitializeComponent();
            this.USERID = userid;
        }
        /// <summary>
        /// 双击单元格，将单元格行中的数据传递到产品信息操作框中进行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //对应框绑定对应值
            DataGridViewRow dgvr = dgvInventory.SelectedRows[0];
            txtinventoryNumber.Text = dgvr.Cells["inventoryNumber"].Value.ToString();
            txtPID.Text = dgvr.Cells["productID"].Value.ToString() ;
            cbbPName.Text = dgvr.Cells["productName"].Value.ToString();
            txtPNID.Text = dgvr.Cells["model"].Value.ToString();
            txtPrice.Text = dgvr.Cells["purchasePrice"].Value.ToString();
            cbpurchase.Checked = Convert.ToBoolean(dgvr.Cells["purchaseincludeTax"].Value);
            txtSalePrice.Text = dgvr.Cells["salesPrice"].Value.ToString();
            cbsale.Checked = Convert.ToBoolean(dgvr.Cells["salesincludeTax"].Value);
            txtNum.Text = dgvr.Cells["inventoryQuantity"].Value.ToString();
            cbbUnit.Text = dgvr.Cells["unit"].Value.ToString();
        }
        /// <summary>
        /// 新建时清空输入的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_Click(object sender, EventArgs e)
        {
            Clear(this);// 清空窗体控件
            Clear(groupBox1);//清空产品信息框
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
                //if (item is DataGridView)
                //{
                //    DataGridView dgv = item as DataGridView;
                //    dgv.Rows.Clear();
                //}
                //默认操作
            }
        }
        /// <summary>
        /// 窗体加载默认操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInventory_Load(object sender, EventArgs e)
        {
            //默认加载所有库存信息
            GetInventory();
            //默认操作
            cbbUnit.SelectedIndex = 0;
            dgvInventory.AllowUserToAddRows = false;
            //自动编入库存编号
            txtinventoryNumber.Text = string.Format("{0:000}", dgvInventory.Rows.Count+1);
            //添加产品名称选项
            Dictionary<string, char> PItems = new Dictionary<string, char>();
            PItems.Add("扫描器", 'C');
            PItems.Add("打印头", 'D');
            PItems.Add("打印机", 'A');
            PItems.Add("连接线", 'L');
            PItems.Add("配件", 'P');
            PItems.Add("维修", 'W');
            PItems.Add("借货", 'J');
            PItems.Add("赠送", 'Z');
            PItems.Add("其他", 'B');
            BindingSource bs = new BindingSource();
            bs.DataSource = PItems;
            cbbPName.DisplayMember = "Key";
            cbbPName.ValueMember = "Value";
            cbbPName.DataSource = bs;
        }
        /// <summary>
        /// 加载库存信息
        /// </summary>
        private void GetInventory()
        {
            dictionary = new Dictionary<string, object>();
            dictionary.Add("inventoryNumber", null);
            dictionary.Add("productID", null);
            dictionary.Add("productName", null);
            dictionary.Add("model", null);
            dictionary.Add("type", 1);
            dt = BLL.GetStock(dictionary);
            dgvInventory.AutoGenerateColumns = false;
            dgvInventory.DataSource = dt;
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认提交？","系统提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                //存在个数
                int exist = 0;
                //存在位置
                int selectedindex=0;
                //验证是否填写完整
                foreach (Control item in groupBox1.Controls)
                {
                    if (string.IsNullOrEmpty(item.Text.Trim()))
                    {
                        MessageBox.Show("请把信息填写完整！", "系统提示");
                        return;
                    }
                }
                //判断产品编号是否存在
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    if (row.Cells["productID"].Value.ToString().Trim()==txtPID.Text.Trim().ToString())
                    {
                        exist++;
                        selectedindex = row.Index;
                    }
                }
                if (exist > 0)
                {
                    //确认后更新数据
                    dictionary = new Dictionary<string, object>();
                    dictionary.Add("inventoryNumber",txtinventoryNumber.Text);
                    dictionary.Add("productID",txtPID.Text);
                    dictionary.Add("productName",cbbPName.Text);
                    dictionary.Add("model",txtPNID.Text);
                    dictionary.Add("purchasePrice",txtPrice.Text);
                    dictionary.Add("purchaseincludeTax",cbpurchase.Checked);
                    dictionary.Add("salesPrice",txtSalePrice.Text);
                    dictionary.Add("salesincludeTax",cbsale.Checked);
                    dictionary.Add("unit",cbbUnit.Text);
                    dictionary.Add("inventoryQuantity",txtNum.Text);
                    dictionary.Add("lastWarehousing",DateTime.Now);
                    dictionary.Add("stockOperatorID",USERID);
                    dictionary.Add("type",2);
                    int updateindex = BLL.ExecuteStock(dictionary);
                    if (updateindex > 0)
                    {
                        MessageBox.Show("修改成功！", "系统提示");
                        DataGridViewRow dgvr = dgvInventory.Rows[selectedindex];
                        string[] item = new string[] { "inventoryNumber", "productID", "productName", "model", "purchasePrice", "purchaseincludeTax", "salesPrice", "salesincludeTax", "unit", "inventoryQuantity" };
                        for (int i = 0; i < dgvr.Cells.Count; i++)
                        {
                            DataGridViewTextBoxCell dgtb = (DataGridViewTextBoxCell)dgvr.Cells[i];
                            dgtb.Value = dictionary[item[i]].ToString();
                        }
                    }
                    //清空产品信息操作框信息
                    Clear(groupBox1);
                }
                else
                {
                    //确认后添加数据
                    dictionary = new Dictionary<string, object>();
                    dictionary.Add("inventoryNumber", txtinventoryNumber.Text);
                    dictionary.Add("productID", txtPID.Text);
                    dictionary.Add("productName", cbbPName.Text);
                    dictionary.Add("model", txtPNID.Text);
                    dictionary.Add("purchasePrice", txtPrice.Text);
                    dictionary.Add("purchaseincludeTax", cbpurchase.Checked);
                    dictionary.Add("salesPrice", txtSalePrice.Text);
                    dictionary.Add("salesincludeTax", cbsale.Checked);
                    dictionary.Add("unit", cbbUnit.Text);
                    dictionary.Add("inventoryQuantity", txtNum.Text);
                    dictionary.Add("lastWarehousing", DateTime.Now);
                    dictionary.Add("stockOperatorID", USERID);
                    dictionary.Add("type", 1);
                    int index = BLL.InsInventory(dictionary);
                    if (index > 0)
                    {
                        MessageBox.Show("添加成功！", "系统提示");

                        //将添加成功的数据显示到DataGridView中
                        //DataGridViewRow dgvr = new DataGridViewRow();
                        //string[] item = new string[] { "inventoryNumber", "productID", "productName", "model", "purchasePrice", "purchaseincludeTax", "salesPrice", "salesincludeTax", "unit", "inventoryQuantity" };
                        //foreach (string items in item)
                        //{
                        //    DataGridViewTextBoxCell dgvc = new DataGridViewTextBoxCell();
                        //    dgvc.Value = dictionary[items];
                        //    dgvr.Cells.Add(dgvc);
                        //}
                        //dgvInventory.Rows.Add(dgvr);
                        GetInventory();

                        //清空产品信息操作框信息
                        Clear(groupBox1);
                    }
                }
            }
        }
        /// <summary>
        /// 快速查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string Message = ttxtID.Text;//存储查询数据
            if (string.IsNullOrEmpty(Message))
            {
                GetInventory();
            }
            else
            {
                //获取全部数据
                GetInventory();
                List<DataGridViewRow> num = new List<DataGridViewRow>();
                //将数据进行分析
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    if (!(row.Cells["productID"].Value.ToString().Trim().Contains(ttxtID.Text.Trim())||row.Cells["productName"].Value.ToString().Trim().Contains(ttxtID.Text.Trim())))
                    {
                        num.Add(row);
                    }
                }
                //通过分析数据查询相对应的数据
                foreach (DataGridViewRow item in num)
                {
                    dgvInventory.Rows.Remove(item);
                }
                //返回数据
                //错误处理

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport(2);
            report.Show();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0'||e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0' || e.KeyChar == 8||e.KeyChar=='.')
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
                TextBox tb = (TextBox)sender;
            try
            {
                Double db = Convert.ToDouble(tb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("输入不正确！", "系统提示");
                tb.Text = string.Empty;
                return;
            }
        }
        /// <summary>
        /// 输入内容快捷查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttxtID_KeyPress(object sender, KeyPressEventArgs e)
        {//回车键进行查询
            if (e.KeyChar==13)
            {
                toolStripButton2_Click(sender, e);
            }
        }
        /// <summary>
        /// 选中之后自动编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbPName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPName.SelectedIndex < 0)
                return;
            int num = 0;//存储出现数字
            //循环遍历DataGridView表格
            for (int i = 0; i < dgvInventory.Rows.Count; i++)
            {
                if (dgvInventory.Rows[i].Cells["productID"].Value.ToString().Contains(cbbPName.SelectedValue.ToString()))
                    num++;
            }
            //选定之后自动添加编号
            txtPID.Text = cbbPName.SelectedValue.ToString() + string.Format("{0:000}",++num);
        }
    }
}
