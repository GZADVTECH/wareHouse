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
        public frmMaintenance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 默认操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            Inventory(cbbproname);//产品名称绑定
            cbbpnid.SelectedIndex = 0;
            GetClient(cbbcname);//客户绑定
            cbbcname.SelectedIndex = 0;
            GetUser(cbbcontactsid);//用户绑定
            cbbcontactsid.SelectedIndex = 0;
            //快递名称索引默认为0
            txttrackingname.SelectedIndex = 0;
            txtreturntrackingname.SelectedIndex = 0;
            //绑定DataGridView
            string[] data = new string[] { "", "", "", "", "", "", "", "", "", "", "","","","" };
            dgvMain.DataSource = BLL.QueryMain(data);
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
        /// <summary>
        /// 获取客户信息
        /// </summary>
        private void GetClient(object sender)
        {
            ComboBox cbb = (ComboBox)sender;
            cbb.DisplayMember = "cName";
            cbb.ValueMember = "autoID";
            cbb.DataSource = BLL.GetCustomer(0, "", "", "");
        }
        /// <summary>
        /// 选择产品名称更新规格型号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbproname_SelectedValueChanged(object sender, EventArgs e)
        {
            cbbpnid.DisplayMember = "PNID";
            cbbpnid.ValueMember = "productID";
            string[] data = new string[] { "", cbbproname.Text, "", "", "", "", "" };
            cbbpnid.DataSource = BLL.GetInventory(0, data);
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
                Clear(groupBox2);
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
            cbb.ValueMember = "userID";
            cbb.DisplayMember = "userName";
            cbb.DataSource = BLL.GetUser(0);
        }
        /// <summary>
        /// 插入维修表详细信息
        /// </summary>
        /// <param name="sender"></param>
        private int InsMain(object sender)
        {
            string[] data = new string[] {cbbcname.SelectedValue.ToString(),cbbpnid.SelectedValue.ToString(),txtsnid.Text,txtmainmsg.Text,txtmainname.Text,dtparrivaldate.Value.ToString()
            ,txttrackingid.Text,txttrackingname.Text,cbbcontactsid.SelectedValue.ToString(),txtnewsnid.Text,dtpreturndate.Value.ToString(),txtreturntrackingid.Text,txtreturntrackingname.Text};
            int dt = BLL.InsMain(data);
            return dt;
        }
        /// <summary>
        /// 更新维修表详细信息
        /// </summary>
        /// <param name="sender"></param>
        private int UpdateMain(object sender)
        {
            string[] data = new string[] {cbbcname.SelectedValue.ToString(),cbbpnid.SelectedValue.ToString(),txtsnid.Text,txtmainmsg.Text,txtmainname.Text,dtparrivaldate.Value.ToString()
            ,txttrackingid.Text,txttrackingname.Text,cbbcontactsid.SelectedValue.ToString(),txtnewsnid.Text,dtpreturndate.Value.ToString(),txtreturntrackingid.Text,txtreturntrackingname.Text};
            int dt = BLL.UpdateMain(data);
            return dt;
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
                        if (cbbpnid.SelectedValue.ToString() == row.Cells["proID"].Value.ToString())
                        {
                            if (txtsnid.Text == row.Cells["snid"].Value.ToString())
                            {
                                index++;
                            }
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
                        Clear(groupBox2);
                        Clear(groupBox3);
                        string[] data = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                        dgvMain.DataSource = BLL.QueryMain(data);
                    }
                }
                else
                {
                    //插入
                    if (InsMain(sender) > 0)
                    {
                        MessageBox.Show("保存成功！", "系统提示");
                        Clear(groupBox1);
                        Clear(groupBox2);
                        Clear(groupBox3);
                        string[] data = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                        dgvMain.DataSource = BLL.QueryMain(data);
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
                    cbbproname.Text = dgvMain["proName", e.RowIndex].Value.ToString();//校准产品名称
                    cbbpnid.SelectedValue = dgvMain["proID", e.RowIndex].Value;//校准规格型号
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
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }
    }
}
