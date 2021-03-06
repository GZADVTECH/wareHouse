﻿using System;
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
        //产品实际数量
        int actalamount = 0;
        //产品应收数量
        int receivable = 0;
        //所有采购货物入库完成情况
        bool COMPLETESTATE;
        //保存状态
        bool SAVESTATE;
        Dictionary<string, object> dictionary;
        private string USERID;
        public frmStorage(string userid)
        {
            InitializeComponent();
            this.USERID = userid;
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
                SAVESTATE = false;//状态为false
                groupBox2.Enabled = false;//S/N框禁止状态
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
            int count = 0;
            openFileDialog1.Title = "选择Excel文件";
            openFileDialog1.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog1.FileName;
                    DataTable dt = BLL.QueryExcel(path, "select * from [Sheet1$]");
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtSN.Text = dr[0].ToString();
                        if (string.IsNullOrEmpty(txtSNName.Text) || string.IsNullOrEmpty(txtSNSNID.Text))
                        {
                            MessageBox.Show("无详细的产品信息，无法录入！", "系统提示");
                            return;
                        }
                        if (string.IsNullOrEmpty(txtSN.Text.Trim()))
                        {
                            MessageBox.Show("请输入S/N号！", "系统提示");
                            return;
                        }
                        foreach (ListViewItem item in lvSN.Items)
                        {
                            if (txtSN.Text == item.SubItems[2].Text)
                            {
                                MessageBox.Show("已存在该S/N号！", "系统提示");
                                return;
                            }
                        }
                        if (actalamount < lvSN.Items.Count+1)
                        {
                            MessageBox.Show("超出实际数量！提交成功" + count+"条数据。", "系统提示");
                            return;
                        }
                        //添加数据到数据库
                        dictionary = new Dictionary<string, object>();
                        dictionary.Add("productID", txtPID.Text);
                        dictionary.Add("SNCode", txtSN.Text);
                        //dictionary.Add("sell",);
                        dictionary.Add("entryTime",DateTime.Now);
                        //dictionary.Add("sellingTime",);
                        dictionary.Add("serielOperatorID",USERID);
                        dictionary.Add("type",1);
                        if (BLL.InsSNID(dictionary) > 0)
                        {
                            count++;
                            //将数据添加到listview中
                            ListViewItem lvi = new ListViewItem(txtSNName.Text);
                            lvi.SubItems.Add(txtSNSNID.Text);
                            lvi.SubItems.Add(txtSN.Text);
                            lvSN.Items.Add(lvi);
                            //清空并给予焦点
                            txtSN.Text = string.Empty;
                            txtSN.Focus();
                        }
                    }
                    MessageBox.Show("提交成功" + count + "条数据。", "系统提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询错误！错误内容：" + ex.Message);
                }
            }
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
            Clear(groupBox2);
            lvSN.Items.Clear();
            //查询数据
            dictionary = new Dictionary<string, object>();
            dictionary.Add("internalOrderNumber", tstxtPID.Text);
            dictionary.Add("beginTime", null);
            dictionary.Add("endTime", null);
            dictionary.Add("type", 7);
            DataTable dt = BLL.QueryProcurement(dictionary);
            if (dt.Rows.Count > 0)
            {
                if (Convert.ToBoolean(dt.Rows[0]["auditStatus"].ToString()) == false)
                {
                    MessageBox.Show("该订单尚未审核。。。", "系统提示");
                    return;
                }
                txtPID.Text = dt.Rows[0]["internalOrderNumber"].ToString();
                txtorderID.Text = dt.Rows[0]["officialOrderNumber"].ToString();
                dtpDeliveryDate.Text = dt.Rows[0]["arrivalTime"].ToString();
                cbbLocation.DisplayMember = dt.Rows[0]["productionPosition"].ToString();
                txtCourier.Text = dt.Rows[0]["receiptExpressNumber"].ToString();
                cbbCourier.Text = dt.Rows[0]["receiptExpressCompany"].ToString();
                txtSupplierID.Text = dt.Rows[0]["supplierRelevantNumber"].ToString();
                rtbRemark.Text = dt.Rows[0]["wareRemark"].ToString();
                

                ////收货人绑定数据
                //consigneeID.ValueMember = "loginNumber";
                //consigneeID.DisplayMember = "userName";
                //dictionary = new Dictionary<string, object>();
                //dictionary.Add("type", 1);
                //consigneeID.DataSource = BLL.GetUser(dictionary);
                ////ComboBox默认显示
                ////consigneeID.DefaultCellStyle.NullValue = ((System.Data.DataRowView)consigneeID.Items[0])[consigneeID.DisplayMember].ToString();
                ////收发票人绑定数据
                //checktaker.ValueMember = "loginNumber";
                //checktaker.DisplayMember = "userName";
                //checktaker.DataSource = BLL.GetUser(dictionary);

                //ComboBox默认显示
                //checktaker.DefaultCellStyle.NullValue = ((System.Data.DataRowView)checktaker.Items[0])[consigneeID.DisplayMember].ToString();
                //显示datagridview数据
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    dgvr.CreateCells(dgvPro);//根据dgvPro创建模板
                    DataRow dr = dt.Rows[i];//获取综合数据
                    string[] data = new string[]
                    {
                        dr["purchaseID"].ToString(),dr["productID"].ToString(),dr["productName"].ToString(),dr["model"].ToString()
                        ,dr["supplierName"].ToString(),dr["CollectionQuantity"].ToString(),dr["purchaseQuantity"].ToString()
                        ,Convert.ToBoolean(dr["invoice"])==true?"是":"否",dr["invoiceNumber"].ToString()
                    };
                    int[] count = new int[] { 0, 1, 4, 5, 6, 7, 8, 9, 10 };
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
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(dt.Rows[0]["auditStatus"].ToString()) == false)
                    {
                        MessageBox.Show("该订单尚未审核。。。", "系统提示");
                        return;
                    }
                    txtPID.Text = dt.Rows[0]["internalOrderNumber"].ToString();
                    txtorderID.Text = dt.Rows[0]["officialOrderNumber"].ToString();
                    dtpDeliveryDate.Text = dt.Rows[0]["arrivalTime"].ToString();

                    int index = 1;

                    ////收货人绑定数据
                    //consigneeID.ValueMember = "loginNumber";
                    //consigneeID.DisplayMember = "userName";
                    //consigneeID.DataSource = BLL.GetUser(dictionary);
                    ////ComboBox默认显示
                    ////consigneeID.DefaultCellStyle.NullValue = ((System.Data.DataRowView)consigneeID.Items[0])[consigneeID.DisplayMember].ToString();
                    ////收发票人绑定数据
                    //checktaker.ValueMember = "loginNumber";
                    //checktaker.DisplayMember = "userName";
                    //checktaker.DataSource = BLL.GetUser(dictionary);
                    //ComboBox默认显示
                    //checktaker.DefaultCellStyle.NullValue = ((System.Data.DataRowView)checktaker.Items[0])[consigneeID.DisplayMember].ToString();
                    foreach (DataRow item in dt.Rows)
                    {
                        DataGridViewRow dgvr = new DataGridViewRow();
                        dgvr.CreateCells(dgvPro);//根据dgvPro创建模板
                        string[] data = new string[]
                        {
                            index++.ToString(),item["productID"].ToString(),item["productName"].ToString(),item["model"].ToString()
                        ,item["supplierName"].ToString(),item["purchaseQuantity"].ToString()
                        ,Convert.ToBoolean(item["invoice"])==true?"是":"否"
                        };

                        int[] count = new int[] { 0, 1, 4, 5, 6, 8, 9};
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


        }
        /// <summary>
        /// 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int index = e.RowIndex;
            if (dgvPro.Columns[e.ColumnIndex].Name == "plus")
            {
                if (string.IsNullOrEmpty(dgvPro.Rows[index].Cells["Num"].Value.ToString()))
                    dgvPro.Rows[index].Cells["Num"].Value = "0";
                amount = Convert.ToInt32(dgvPro.Rows[index].Cells["Num"].Value);
                if (Convert.ToInt32(dgvPro.Rows[index].Cells["actualAmount"].Value) < amount + 1)
                {
                    return;
                }
                dgvPro.Rows[index].Cells["Num"].Value = (++amount).ToString();
            }
            if (dgvPro.Columns[e.ColumnIndex].Name == "minus")
            {
                if (string.IsNullOrEmpty(dgvPro.Rows[index].Cells["Num"].Value.ToString()))
                    dgvPro.Rows[index].Cells["Num"].Value = "0";
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
            cbbCourier.SelectedIndex = 0;
        }
        /// <summary>
        /// 单元格编辑结束验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgvPro.Rows[index].Cells["Num"].Value==null)
                dgvPro.Rows[index].Cells["Num"].Value = "0";
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
                    actalamount = Convert.ToInt32(dgvPro.Rows[index].Cells["Num"].Value);//获取当前选中列的数量
                    receivable = Convert.ToInt32(dgvPro.Rows[index].Cells["actualAmount"].Value);//获取该应收数量
                    groupBox2.Tag = dgvPro.Rows[index].Cells["productID"].Value;//将数量绑定到SN码Tag
                    txtSNName.Text = dgvPro.Rows[index].Cells["productName"].Value.ToString();//获取产品名称
                    txtSNSNID.Text = dgvPro.Rows[index].Cells["pnid"].Value.ToString();//获取规格型号
                    //将已经输入的SN显示到ListView中
                    lvSN.Items.Clear();
                    dictionary = new Dictionary<string, object>();
                    //dictionary.Add("serialNumber",);
                    dictionary.Add("productID",txtPID.Text);
                    dictionary.Add("SNCode",groupBox2.Tag.ToString());
                    dictionary.Add("type",1);
                    DataTable dt = BLL.QuerySNID(dictionary);
                    foreach (DataRow item in dt.Rows)
                    {
                        ListViewItem lvi = new ListViewItem(item["productName"].ToString());
                        lvi.SubItems.Add(item["PNID"].ToString());
                        lvi.SubItems.Add(item["SNID"].ToString());
                        lvSN.Items.Add(lvi);
                    }
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
            if (MessageBox.Show("是否保存？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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
                int count = 0;
                for (int i = 0; i < dgvPro.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(dgvPro.Rows[i].Cells[7].FormattedValue.ToString()))
                    {
                        MessageBox.Show("数量不允许为空！", "系统提示");
                        return;
                    }
                    if (dgvPro.Rows[i].Cells["Num"].Value.ToString() == dgvPro.Rows[i].Cells["actualAmount"].Value.ToString())
                    {
                        count++;
                    }
                }
                if (count == dgvPro.Rows.Count)
                    COMPLETESTATE = true;
                else
                    COMPLETESTATE = false;
                dictionary = new Dictionary<string, object>();
                dictionary.Add("internalOrderNumber", txtPID.Text);
                dictionary.Add("type", 3);
                //查询是否有该数据
                if (BLL.QueryStorage(dictionary).Rows.Count <= 0)
                {
                    //无则新建
                    cargoOperation(1);
                }
                else
                {
                    //有则更新
                    cargoOperation(2);
                }
            }
        }
        /// <summary>
        /// 入库操作
        /// </summary>
        /// <param name="typeid"></param>
        private void cargoOperation(int typeid)
        {
            int allindex = 0;
            string invoiceid = "";
            foreach (DataGridViewRow dgvr in dgvPro.Rows)
            {
                if (dgvr.Cells["invoiceID"].Value != null)
                {
                    invoiceid = dgvr.Cells["invoiceID"].Value.ToString();
                }
                dictionary = new Dictionary<string, object>();
                dictionary.Add("purchaseID", dgvr.Cells["ID"].Value.ToString());
                dictionary.Add("internalOrderNumber", txtPID.Text);
                dictionary.Add("receiptExpressNumber", txtCourier.Text);
                dictionary.Add("receiptExpressCompany", cbbCourier.Text);
                dictionary.Add("productionPosition", cbbLocation.Text);
                dictionary.Add("supplierRelevantNumber", txtSupplierID.Text);
                dictionary.Add("storageDate", dtpDeliveryDate.Text);
                dictionary.Add("CollectionQuantity", dgvr.Cells["Num"].Value.ToString());
                dictionary.Add("wareOperatorID", USERID);
                dictionary.Add("invoiceNumber", invoiceid);
                dictionary.Add("wareRemark", rtbRemark.Text);
                dictionary.Add("wareState", COMPLETESTATE?1:0);
                dictionary.Add("type", typeid);
                if(BLL.InsStorage(dictionary)>0)
                allindex++;
            }
            if (allindex == dgvPro.Rows.Count)
            {
                MessageBox.Show("操作成功！", "系统提示");
                SAVESTATE = true;
                groupBox2.Enabled = true;
            }
            else
                MessageBox.Show("操作失败！", "系统提示");
        }
        /// <summary>
        /// 单元格单击一次进入编辑状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0&&e.ColumnIndex>=0)
            {
                DataGridViewComboBoxColumn combo = dgvPro.Columns[e.ColumnIndex] as DataGridViewComboBoxColumn;
                if (combo!=null)
                {
                    dgvPro.BeginEdit(false);
                    DataGridViewComboBoxEditingControl comboEdite = dgvPro.EditingControl as DataGridViewComboBoxEditingControl;
                    if (comboEdite!=null)
                    {
                        comboEdite.DroppedDown = true;
                    }
                }

                DataGridViewTextBoxColumn txtbox = dgvPro.Columns[e.ColumnIndex] as DataGridViewTextBoxColumn;
                if (txtbox!=null)
                {
                    dgvPro.BeginEdit(true);
                }
            }
        }
        /// <summary>
        /// 指针离开退出编辑状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPro_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvPro.EndEdit();
        }
        /// <summary>
        /// 验证：不允许输入任何特殊符号,除了退格键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlKeyPress(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0' || e.KeyChar <= 'Z' && e.KeyChar >= 'A' || e.KeyChar <= 'z' && e.KeyChar >= 'a'||e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        /// <summary>
        /// 录入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSNSave_Click(object sender, EventArgs e)
        {
            if (!SAVESTATE)
                return;
            if (string.IsNullOrEmpty(txtSNName.Text)||string.IsNullOrEmpty(txtSNSNID.Text))
            {
                MessageBox.Show("无详细的产品信息，无法录入！", "系统提示");
                return;
            }
            if (string.IsNullOrEmpty(txtSN.Text.Trim()))
            {
                MessageBox.Show("请输入S/N号！", "系统提示");
                return;
            }
            foreach (ListViewItem item in lvSN.Items)
            {
                if (txtSN.Text == item.SubItems[2].Text)
                {
                    MessageBox.Show("已存在该S/N号！", "系统提示");
                    return;
                }
            }
            if (actalamount < lvSN.Items.Count+1)
            {
                MessageBox.Show("超出实际数量！", "系统提示");
                return;
            }
            //添加数据到数据库
            dictionary = new Dictionary<string, object>();
            dictionary.Add("productID", txtPID.Text);
            dictionary.Add("SNCode", txtSN.Text);
            //dictionary.Add("sell",);
            dictionary.Add("entryTime", DateTime.Now);
            //dictionary.Add("sellingTime",);
            dictionary.Add("serielOperatorID", USERID);
            dictionary.Add("type", 1);
            if (BLL.InsSNID(dictionary) > 0)
            {
                //将数据添加到listview中
                ListViewItem lvi = new ListViewItem(txtSNName.Text);
                lvi.SubItems.Add(txtSNSNID.Text);
                lvi.SubItems.Add(txtSN.Text);
                lvSN.Items.Add(lvi);
                //清空并给予焦点
                txtSN.Text = string.Empty;
                txtSN.Focus();
                MessageBox.Show("提交成功！", "系统提示");
            }
        }

        private void tstxtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tsbtnSelect_Click(sender, e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
