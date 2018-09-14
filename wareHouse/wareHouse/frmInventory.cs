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
        public frmInventory()
        {
            InitializeComponent();
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
            txtPID.Text = dgvr.Cells["pid"].Value.ToString() ;
            txtPName.Text = dgvr.Cells["pname"].Value.ToString();
            txtPNID.Text = dgvr.Cells["ppnid"].Value.ToString();
            txtPrice.Text = dgvr.Cells["pprice"].Value.ToString();
            txtNum.Text = dgvr.Cells["pNum"].Value.ToString();
            cbbUnit.Text = dgvr.Cells["pUnit"].Value.ToString();
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
        }
        /// <summary>
        /// 加载库存信息
        /// </summary>
        private void GetInventory()
        {
            string[] data = new string[] { "", "", "", "", "", "" };
            DataTable dt = BLL.GetInventory(0, data);
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
                    if (row.Cells["pid"].Value.ToString().Trim()==txtPID.Text.Trim().ToString())
                    {
                        exist++;
                        selectedindex = row.Index;
                    }
                }
                if (exist > 0)
                {
                    //确认后更新数据
                    string[] updatedata = new string[] { txtPID.Text, txtPName.Text, txtPNID.Text, txtPrice.Text, cbbUnit.Text, txtNum.Text };
                    int updateindex = BLL.InsInventory(2, updatedata);
                    if (updateindex > 0)
                    {
                        MessageBox.Show("修改成功！", "系统提示");
                        DataGridViewRow dgvr = dgvInventory.Rows[selectedindex];
                        for (int i = 0; i < dgvr.Cells.Count; i++)
                        {
                            DataGridViewTextBoxCell dgtbc = (DataGridViewTextBoxCell)dgvr.Cells[i];
                            dgtbc.Value = updatedata[i];
                        }
                    }
                    //清空产品信息操作框信息
                    Clear(groupBox1);
                }
                else
                {
                    //确认后添加数据
                    string[] data = new string[] { txtPID.Text, txtPName.Text, txtPNID.Text, txtPrice.Text, cbbUnit.Text, txtNum.Text };
                    int index = BLL.InsInventory(1, data);
                    if (index > 0)
                    {
                        MessageBox.Show("添加成功！", "系统提示");
                        //将添加成功的数据显示到DataGridView中
                        DataGridViewRow dgvr = new DataGridViewRow();
                        for (int i = 0; i < data.Count(); i++)
                        {
                            DataGridViewTextBoxCell dgvc = new DataGridViewTextBoxCell();
                            dgvc.Value = data[i];
                            dgvr.Cells.Add(dgvc);
                        }
                        dgvInventory.Rows.Add(dgvr);
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
            //是否存在
            int exist = 0;
            //存在编号
            int selectedindex = 0;
            //判断产品编号是否存在
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["pid"].Value.ToString().Trim() == ttxtID.Text.Trim().ToString())
                {
                    exist++;
                    selectedindex = row.Index;
                }
            }
            if (exist>0)
            {
                //存在则将详细的信息添加到产品信息中
                DataGridViewRow dgvr = dgvInventory.Rows[selectedindex];
                string[] data = new string[] {dgvr.Cells["pid"].Value.ToString(), dgvr.Cells["pname"].Value.ToString(), dgvr.Cells["ppnid"].Value.ToString(), dgvr.Cells["pprice"].Value.ToString(), dgvr.Cells["punit"].Value.ToString(), dgvr.Cells["pnum"].Value.ToString(), };
                txtPID.Text = data[0];
                txtPName.Text = data[1];
                txtPNID.Text = data[2];
                txtPrice.Text = data[3];
                cbbUnit.Text = data[4];
                txtNum.Text = data[5];
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport(2);
            report.Show();
        }
    }
}
