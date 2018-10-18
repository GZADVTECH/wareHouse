using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wareHouse
{
    public partial class frmFinance : Form
    {
        private bool STATE = false;
        private string USERID;
        public frmFinance(string userid)
        {
            InitializeComponent();
            this.USERID = userid;
        }
        /// <summary>
        /// 默认操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFinance_Load(object sender, EventArgs e)
        {
            dgvFinace.AutoGenerateColumns = false;
            dgvFinace.AllowUserToAddRows = false;
            GetFinace("", dgvFinace);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmReport report;
            if (toolStripButton2.Tag != null)
                report = new frmReport(toolStripButton2.Tag.ToString(), 5);
            else
                report = new frmReport(5);
            report.ShowDialog();
        }
        /// <summary>
        /// DataGridView数据导入
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="dgv"></param>
        private void GetFinace(string pid,DataGridView dgv)
        {
            dgv.Rows.Clear();
            int index = 0;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("internalOrderNumber",null);
            dictionary.Add("type", 1);
            DataTable dt = WHBLL.BLL.QueryFinace(dictionary);
            foreach (DataRow dr in dt.Rows)
            {
                string[] item =
                {
                    (++index).ToString(),dr["financialNumber"].ToString(),dr["internalOrderNumber"].ToString(),dr["creationTime"].ToString(),dr["supplierName"].ToString(),(Convert.ToDouble(dr["purchasePrice"])*Convert.ToDouble(dr["purchaseQuantity"])).ToString()+"("+
                    (Convert.ToBoolean(dr["purchaseincludeTax"])?"是":"否")+")",dr["paymentDate"].ToString(),(Convert.ToBoolean(dr["auditStatus"])?"已审核":"未审核").ToString(),dr["productName"].ToString(),dr["purchasePrice"].ToString()+"("+(Convert.ToBoolean(dr["purchaseincludeTax"])?"是":"否")+")",
                    dr["purchaseQuantity"].ToString(),dr["customerName"].ToString(),dr["storageDate"].ToString(),dr["CollectionQuantity"].ToString(),dr["invoiceNumber"].ToString(),dr["supplierRelevantNumber"].ToString(),dr["salesPrice"].ToString()+"("+
                    ((dr["salesincludeTax"].ToString()=="true")?"是":"否").ToString()+")",dr["paymentRemark"].ToString(),dr["paymentDate"].ToString(),dr["paymentAmount"].ToString(),
                };
                DataGridViewRow dgvr = new DataGridViewRow();
                dgvr.CreateCells(dgv);//通过dgv创建模板
                int count = 0;
                foreach (string value in item)
                {
                    dgvr.Cells[count++].Value = value;
                }
                dgv.Rows.Add(dgvr);
            }
        }
        /// <summary>
        /// 通过ID查询相关信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            toolStripButton2.Tag = txtPID.Text;
            GetFinace(txtPID.Text, dgvFinace);
        }

        private void txtPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                tsbSelect_Click(sender, e);
            }
        }
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (dgvFinace.Rows.Count == 0)
            {
                MessageBox.Show("无保存数据！", "系统提示");
                return;
            }
            foreach (DataGridViewRow dr in dgvFinace.Rows)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("financialNumber", dr.Cells["autoID"].Value);
                dictionary.Add("internalOrderNumber", dr.Cells["pID"].Value);
                dictionary.Add("paymentDate", dr.Cells["payDate"].Value);
                dictionary.Add("paymentAmount", dr.Cells["paySum"].Value);
                dictionary.Add("paymentRemark", dr.Cells["remark"].Value);
                dictionary.Add("financeOperatorID",USERID);
                dictionary.Add("type",2);
                //更新操作
                WHBLL.BLL.InsFinance(dictionary);
            }
            GetFinace("", dgvFinace);
        }
        /// <summary>
        /// 结束编辑后验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFinace_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rindex = e.RowIndex;//选中行索引
            int cindex = e.ColumnIndex;//选中列索引
            //付款日期
            if (cindex==18)
            {
                DateTime dt;
                if (string.IsNullOrEmpty(dgvFinace[cindex, rindex].Value.ToString())) return;
                if (dgvFinace[cindex, rindex].Value.ToString() == string.Empty) return;
                if (!DateTime.TryParse(dgvFinace[cindex,rindex].Value.ToString(),out dt))
                {
                    MessageBox.Show("输入的格式不正确", "系统提示");
                    dgvFinace[cindex, rindex].Value = string.Empty;
                    return;
                }
            }
            //付款金额
            if (cindex==19)
            {
                Decimal dec;
                if (dgvFinace[cindex, rindex].Value == null) return;
                if (!Decimal.TryParse(dgvFinace[cindex,rindex].Value.ToString(),out dec))
                {
                    MessageBox.Show("输入的格式不正确", "系统提示");
                    dgvFinace[cindex, rindex].Value = string.Empty;
                    return;
                }
            }
        }
        /// <summary>
        /// 单击进入编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFinace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewComboBoxColumn combo = dgvFinace.Columns[e.ColumnIndex] as DataGridViewComboBoxColumn;
                if (combo != null)
                {
                    dgvFinace.BeginEdit(false);
                    DataGridViewComboBoxEditingControl comboEdite = dgvFinace.EditingControl as DataGridViewComboBoxEditingControl;
                    if (comboEdite != null)
                    {
                        comboEdite.DroppedDown = true;
                    }
                }

                DataGridViewTextBoxColumn txtbox = dgvFinace.Columns[e.ColumnIndex] as DataGridViewTextBoxColumn;
                if (txtbox != null)
                {
                    dgvFinace.BeginEdit(true);
                }
            }
        }
    }
}
