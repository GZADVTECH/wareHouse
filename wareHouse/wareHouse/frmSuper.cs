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
    public partial class frmSuper : Form
    {
        private static string UNAME;
        Dictionary<string, object> dictionary;
        public frmSuper()
        {
            InitializeComponent();
        }
        public frmSuper(string uname)
        {
            InitializeComponent();
            UNAME = uname;
        }
        DataTable dt = new DataTable();
        private void frmSuper_Load(object sender, EventArgs e)
        {
            QueryProCargo();
        }
        /// <summary>
        /// 获取详细的采购信息
        /// </summary>
        private void QueryProCargo()
        {
            dt = WHBLL.BLL.QueryProCargo();
            lbPro.DataSource = WHBLL.BLL.QueryPro();
            lbPro.DisplayMember = "pID";
            lbPro.ValueMember = "pID";
        }
        /// <summary>
        /// 选择之后显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPro_SelectedValueChanged(object sender, EventArgs e)
        {
            rtbDetailed.Text = string.Empty;
            StringBuilder sb = new StringBuilder();
            DataRow[] dr = dt.Select(string.Format("pID='{0}'", lbPro.SelectedValue.ToString()));
            int i = 0;
            double total = 0;
            double amount = 0;
            double price = 0;
            foreach (DataRow item in dr)
            {
                if (i++ < 1)
                    sb.Append(string.Format("详细信息如下：\n内部订单号：{0}\n正式订单号：{1}\n采购人：{2}\n客户姓名：{3}\n产品内容：\n", item["pID"].ToString(), item["contractOrder"].ToString(), item["userName"].ToString(), item["cName"].ToString()));
                sb.Append(string.Format("名称：{0}，规格型号：{1}，数量：{2}，采购单价：{3}\n", item["productName"].ToString(), item["PNID"].ToString(), item["amount"].ToString(), item["unitPrice"].ToString()));
                total += (Double.TryParse(item["amount"].ToString(), out amount) ? amount : 0) * (Double.TryParse(item["unitPrice"].ToString(), out price) ? price : 0);
            }
            sb.Append(string.Format("总金额：{0}元", total));
            rtbDetailed.Text = sb.ToString();
        }

        private void 审核通过ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认通过？","系统提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("internalOrderNumber", lbPro.SelectedValue.ToString());
                //dictionary.Add("officialOrderNumber", );
                //dictionary.Add("operatorID", );
                //dictionary.Add("customerID", );
                //dictionary.Add("arrivalTime", );
                //dictionary.Add("creationTime", );
                dictionary.Add("auditStatus", 1);
                //dictionary.Add("completeState",0);
                dictionary.Add("type", 2);
                int feedback = WHBLL.BLL.ExecuteProcurement(dictionary);
                if (feedback>0)
                {
                    MessageBox.Show("审核成功！", "系统提示");
                    QueryProCargo();
                    rtbDetailed.Text = string.Empty;
                }
            }
        }

        private void 驳回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认驳回？","系统提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("internalOrderNumber", lbPro.SelectedValue.ToString());
                //dictionary.Add("officialOrderNumber", );
                //dictionary.Add("operatorID", );
                //dictionary.Add("customerID", );
                //dictionary.Add("arrivalTime", );
                //dictionary.Add("creationTime", );
                //dictionary.Add("auditStatus", 0);
                dictionary.Add("completeState", 1);
                dictionary.Add("type", 2);
                int feedback = WHBLL.BLL.ExecuteProcurement(dictionary);
                if (feedback > 0)
                {
                    MessageBox.Show("成功驳回！", "系统提示");
                    QueryProCargo();
                    rtbDetailed.Text = string.Empty;
                }
            }
        }
    }
}
