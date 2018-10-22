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
    public partial class frmMaintenance : Form
    {
        private string USERID;
        public frmMaintenance(string userid)
        {
            InitializeComponent();
            this.USERID = userid;
        }
        Dictionary<string, object> dictionary;
        /// <summary>
        /// 默认操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            Inventory(cbbproname);//产品名称绑定
            GetClient(cbbcname);//客户绑定
            cbbcname.SelectedIndex = 0;
            GetUser(cbbcontactsid);//用户绑定
            cbbcontactsid.SelectedIndex = 0;
            //快递名称索引默认为0
            txttrackingname.SelectedIndex = 0;
            txtreturntrackingname.SelectedIndex = -1;
            //绑定DataGridView
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AllowUserToAddRows = false;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("repairCustomernumber",null);
            dictionary.Add("repairProductID", null);
            dictionary.Add("repairSNCode", null);
            dictionary.Add("type",1);
            dgvMain.DataSource = BLL.QueryMain(dictionary);
        }        
        /// <summary>
        /// 产品名称获取
        /// </summary>
        private void Inventory(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            dictionary = new Dictionary<string, object>();
            dictionary.Add("inventoryNumber",null);
            dictionary.Add("productID", null);
            dictionary.Add("productName", null);
            dictionary.Add("model", null);
            dictionary.Add("type",5);
            DataTable dt = BLL.GetStock(dictionary);
            Dictionary<string,string> modeldictionary = new Dictionary<string, string>();
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
        /// 获取客户信息
        /// </summary>
        private void GetClient(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            cbb.DisplayMember = "customerName";
            cbb.ValueMember = "customerNumber";
            dictionary = new Dictionary<string, object>();
            dictionary.Add("customerNumber", null);
            dictionary.Add("type",1);
            cbb.DataSource = BLL.GetCustomer(dictionary);
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
                    if (item.Name == "txtAddress") continue;
                    item.Text = string.Empty;
                }
                if (item is CheckBox)
                {
                    CheckBox cb = item as CheckBox;
                    cb.Checked = false;
                }
                if (item is ComboBox)
                {
                    if (item.Name=="cbbpnid")
                    {
                        continue;
                    }
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
        /// 新建按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否新建？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Clear(groupBox1);
                Clear(groupBox3);
            }
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="sender"></param>
        private void GetUser(object sender)
        {
            ComboBox cbb = sender as ComboBox;
            cbb.ValueMember = "loginNumber";
            cbb.DisplayMember = "userName";
            dictionary = new Dictionary<string, object>();
            dictionary.Add("type",1);
            cbb.DataSource = BLL.GetUser(dictionary);
        }
        /// <summary>
        /// 插入维修表详细信息
        /// </summary>
        /// <param name="sender"></param>
        private int InsMain(object sender)
        {
            dictionary = new Dictionary<string, object>();
            dictionary.Add("repairCustomernumber", cbbcname.SelectedValue.ToString());
            dictionary.Add("repairProductID",cbbproname.SelectedValue.ToString());
            dictionary.Add("repairSNCode", txtsnid.Text);
            dictionary.Add("repairMeg", txtmainmsg.Text);
            dictionary.Add("repairName", txtmainname.Text);
            dictionary.Add("repairArrivalTime", dtparrivaldate.Value.ToString());
            dictionary.Add("repairExpressNumber", txttrackingid.Text);
            dictionary.Add("repairExpressCompany", txttrackingname.Text);
            dictionary.Add("repairContacts", cbbcontactsid.SelectedValue.ToString());
            dictionary.Add("repairContactinfo", txtContactinfo.Text);
            dictionary.Add("repairContactAddress",txtAddress.Text );
            dictionary.Add("repairReturnTime", dtpreturndate.Value.ToString());
            dictionary.Add("repairReturnExpressNumber", txtreturntrackingid.Text);
            dictionary.Add("repairReturnExpressCompany", txtreturntrackingname.Text);
            dictionary.Add("repairReturnSNCode", txtnewsnid.Text);
            dictionary.Add("repairOperatorID",USERID);
            dictionary.Add("repairStatus",0);
            dictionary.Add("type",1);
            int dt = BLL.ExecuteMain(dictionary);
            return dt;
        }
        /// <summary>
        /// 更新维修表详细信息
        /// </summary>
        /// <param name="sender"></param>
        private int UpdateMain(object sender)
        {
            if (!string.IsNullOrEmpty(txttrackingid.Text.Trim()))
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("repairCustomernumber", cbbcname.SelectedValue.ToString());
                dictionary.Add("repairProductID", cbbproname.SelectedValue.ToString());
                dictionary.Add("repairSNCode", txtsnid.Text);
                dictionary.Add("repairMeg", txtmainmsg.Text);
                dictionary.Add("repairName", txtmainname.Text);
                dictionary.Add("repairArrivalTime", dtparrivaldate.Value.ToString());
                dictionary.Add("repairExpressNumber", txttrackingid.Text);
                dictionary.Add("repairExpressCompany", txttrackingname.Text);
                dictionary.Add("repairContacts", cbbcontactsid.SelectedValue.ToString());
                dictionary.Add("repairContactinfo", txtContactinfo.Text);
                dictionary.Add("repairContactAddress", txtAddress.Text);
                dictionary.Add("repairOperatorID", USERID);
                dictionary.Add("type", 2);
                int returnvalue = BLL.ExecuteMain(dictionary);
                return returnvalue;
            }
            else
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("repairCustomernumber", cbbcname.SelectedValue.ToString());
                dictionary.Add("repairProductID", cbbproname.SelectedValue.ToString());
                dictionary.Add("repairSNCode", txtsnid.Text);
                dictionary.Add("repairReturnTime", dtpreturndate.Value.ToString());
                dictionary.Add("repairReturnExpressNumber", txtreturntrackingid.Text);
                dictionary.Add("repairReturnExpressCompany", txtreturntrackingname.Text);
                dictionary.Add("repairOperatorID", USERID);
                dictionary.Add("repairStatus", 0);
                dictionary.Add("type", 2);
                int returnvalue = BLL.ExecuteMain(dictionary);
                return returnvalue;
            }
        }
        /// <summary>
        /// 保存操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否保存？", "系统提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Control group in groupBox1.Controls)
                {
                    if (string.IsNullOrEmpty(group.Text.Trim()))
                    {
                        MessageBox.Show("请将基础数据填写完整！", "系统提示");
                        return;
                    }
                }
                int index = 0;
                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    if (cbbcname.SelectedValue.ToString() == row.Cells["cid"].Value.ToString())
                    {
                        if (txtsnid.Text == row.Cells["snid"].Value.ToString())
                        {
                            index++;
                        }
                    }
                }
                if (index>0)
                {
                    //更新
                    if (UpdateMain(sender) > 0)
                    {
                        MessageBox.Show("更新成功！", "系统提示");
                        Clear(groupBox1);
                        Clear(groupBox3);
                        dictionary = new Dictionary<string, object>();
                        dictionary.Add("repairCustomernumber", null);
                        dictionary.Add("repairProductID", null);
                        dictionary.Add("repairSNCode", null);
                        dictionary.Add("type", 1);
                        dgvMain.DataSource = BLL.QueryMain(dictionary);
                    }
                }
                else
                {
                    //插入
                    if (InsMain(sender) > 0)
                    {
                        MessageBox.Show("保存成功！", "系统提示");
                        Clear(groupBox1);
                        Clear(groupBox3);
                        dictionary = new Dictionary<string, object>();
                        dictionary.Add("repairCustomernumber", null);
                        dictionary.Add("repairProductID", null);
                        dictionary.Add("repairSNCode", null);
                        dictionary.Add("type", 1);
                        dgvMain.DataSource = BLL.QueryMain(dictionary);
                    }
                }
            }
        }
        /// <summary>
        /// 右键添加详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                if (e.RowIndex>=0)
                {
                    cbbcname.SelectedValue = dgvMain["cid", e.RowIndex].Value;//校准客户名称
                    cbbproname.Text = string.Format(dgvMain["proName", e.RowIndex].Value.ToString()+"("+ dgvMain["pnid", e.RowIndex].Value.ToString() + ")");//校准产品名称
                    txtmainmsg.Text = dgvMain["mainMsg", e.RowIndex].Value.ToString();//校准维保原因
                    txtmainname.Text = dgvMain["mainName", e.RowIndex].Value.ToString();//校准维保地
                    txtsnid.Text= dgvMain["snid", e.RowIndex].Value.ToString();//校准S/N号
                    dtparrivaldate.Value = Convert.ToDateTime(dgvMain["arrivatedate", e.RowIndex].Value.ToString());//校准收货日期
                    txttrackingid.Text = dgvMain["trackingID", e.RowIndex].Value.ToString();//校准快递单号
                    txttrackingname.Text = dgvMain["trackingname", e.RowIndex].Value.ToString();//校准快递公司
                    dtpreturndate.Value = Convert.ToDateTime(dgvMain["returndate", e.RowIndex].Value.ToString());//校准归还日期
                    txtreturntrackingid.Text = dgvMain["returntrackingid", e.RowIndex].Value.ToString();//校准归还快递单号
                    txtreturntrackingname.Text = dgvMain["returntrackingname", e.RowIndex].Value.ToString();//校准归还快递公司
                    cbbcontactsid.SelectedValue = dgvMain["contactsid", e.RowIndex].Value;//校准联系人
                    txtnewsnid.Text = dgvMain["returnsnid", e.RowIndex].Value.ToString();//校准归还S/N号
                    txtContactinfo.Text= dgvMain["repairContactinfo", e.RowIndex].Value.ToString();//校准联系方式
                    txtAddress.Text= dgvMain["repairContactAddress", e.RowIndex].Value.ToString();//校准联系地址
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }
        /// <summary>
        /// 点击选中全部内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
        }
    }
}
