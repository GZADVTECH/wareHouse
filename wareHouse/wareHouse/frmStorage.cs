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
    public partial class frmStorage : Form
    {
        //数量
        int amount = 0;
        public frmStorage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 新建按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否新建？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clear(groupBox1);//清空单据信息框
                Clear(this);//清空窗体所有控件
                tstxtPID.Text = string.Empty;//查询输入框清空
                dgvPro.AllowUserToAddRows = false;//不允许自动生成行
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
            }
        }
        /// <summary>
        /// 导入Excel文件输入S/N码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDou_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "选择Excel文件";
            openFileDialog1.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
        }
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSelect_Click(object sender, EventArgs e)
        {
            //清空DataGridView
            dgvPro.Rows.Clear();
            //查询数据
            DataTable dt = BLL.QueryProcurement(tstxtPID.Text);
            if (dt.Rows.Count > 0)
            {
                txtPID.Text = dt.Rows[0]["pID"].ToString();
                dtparrive.Text = dt.Rows[0]["arrivalDate"].ToString();

                int index = 1;

                //收货人绑定数据
                consigneeID.ValueMember = "userID";
                consigneeID.DisplayMember = "userName";
                consigneeID.DataSource = BLL.GetUser(0);
                consigneeID.DefaultCellStyle.NullValue = ((System.Data.DataRowView)consigneeID.Items[0])[consigneeID.DisplayMember].ToString();
                //收发票人绑定数据
                checktaker.ValueMember = "userID";
                checktaker.DisplayMember = "userName";
                checktaker.DataSource = BLL.GetUser(0);
                checktaker.DefaultCellStyle.NullValue = ((System.Data.DataRowView)checktaker.Items[0])[consigneeID.DisplayMember].ToString();
                foreach (DataRow item in dt.Rows)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    dgvr.CreateCells(dgvPro);//根据dgvPro创建模板
                    string[] data = new string[]
                    {
                        index++.ToString(),item["productID"].ToString(),item["productName"].ToString(),item["PNID"].ToString(),item["supperName"].ToString(),"0",item["amount"].ToString(),Convert.ToBoolean(item["isTax"])==true?"是":"否"
                    };
                    int[] count = new int[] { 0, 1, 4, 5, 6, 7, 8, 9 };
                    int order = 0;
                    foreach (int number in count)
                    {
                        dgvr.Cells[number].Value = data[order++].ToString();
                    }
                    dgvPro.Rows.Add(dgvr);
                }
            }
            else
            {
                MessageBox.Show("查无此订单号！", "系统提示");
                return;
            }

        }
        /// <summary>
        /// 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgvPro.Columns[e.ColumnIndex].Name == "plus")
            {
                amount = Convert.ToInt32(dgvPro.Rows[index].Cells["Num"].Value);
                if (Convert.ToInt32(dgvPro.Rows[index].Cells["actualAmount"].Value) < amount + 1)
                {
                    return;
                }
                dgvPro.Rows[index].Cells["Num"].Value = (++amount).ToString();
            }
            if (dgvPro.Columns[e.ColumnIndex].Name == "minus")
            {
                amount = Convert.ToInt32(dgvPro.Rows[index].Cells["Num"].Value);
                if (amount == 0)
                {
                    return;
                }
                dgvPro.Rows[index].Cells["Num"].Value = (--amount).ToString();
            }
        }
        /// <summary>
        /// 默认加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStorage_Load(object sender, EventArgs e)
        {
            //不允许自动生成行
            dgvPro.AllowUserToAddRows = false;
            //仓位默认位置
            cbbLocation.SelectedIndex = 0;
        }
        /// <summary>
        /// 单元格编辑结束验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int num = Convert.ToInt32(dgvPro.Rows[index].Cells["Num"].Value);
            if (num > Convert.ToInt32(dgvPro.Rows[index].Cells["actualAmount"].Value) || num < 0)
            {
                MessageBox.Show("输入不合法！", "系统提示");
                dgvPro.Rows[index].Cells["Num"].Value = "0";
                return;
            }
        }
        /// <summary>
        /// 右键打开SN输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    int index = e.RowIndex;
                    int amount = Convert.ToInt32(dgvPro.Rows[index].Cells["Num"].Value);//获取当前选中列的数量
                    groupBox2.Tag = amount;//将数量绑定到SN码Tag
                    txtSNName.Text = dgvPro.Rows[index].Cells["productName"].Value.ToString();//获取产品名称
                    txtSNSNID.Text = dgvPro.Rows[index].Cells["pnid"].Value.ToString();//获取规格型号
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
            if (string.IsNullOrEmpty(txtPID.Text))
            {
                MessageBox.Show("尚未有该订单，请核实后再保存！", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(cbbLocation.Text))
            {
                MessageBox.Show("请选择仓位！", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(txtCourier.Text))
            {
                MessageBox.Show("快递单号不允许为空", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(txtSupplierID.Text))
            {
                MessageBox.Show("供应商订单号不允许为空!", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(cbbCourier.Text))
            {
                MessageBox.Show("快递公司不允许为空！", "系统提示");
                return;
            }
            if (BLL.QueryStorage(0,tstxtPID.Text).Rows.Count>0)
            {
                MessageBox.Show("该订单已存在！", "系统提示");
                return;
            }
            int allindex = 0;
            foreach (DataGridViewRow dgvr in dgvPro.Rows)
            { 
                /********************************bug:无法获取DataGridViewComboBoxCell选中的值****************************************/
                string[] data = new string[] {
                    txtCourier.Text,cbbCourier.Text,cbbLocation.Text, txtSupplierID.Text
                    , dtpDeliveryDate.Text, dgvr.Cells["productID"].Value.ToString()
                    , dgvr.Cells["Num"].Value.ToString() , dgvr.Cells["consigneeID"].Value.ToString(),dgvr.Cells["invoiceID"].Value.ToString()
                    , dgvr.Cells["checktaker"].Value.ToString(), rtbRemark.Text };
                int index = BLL.InsStorage(1, txtPID.Text, data);
                allindex += index;
            }
            if (allindex == dgvPro.Rows.Count)
            {
                MessageBox.Show("添加成功！", "系统提示");
            }
            else
                MessageBox.Show("添加失败！", "系统提示");
        }
    }
}
