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
        private static string USERID;
        Dictionary<string, object> dictionary;
        public frmSuper()
        {
            InitializeComponent();
        }
        public frmSuper(string userid)
        {
            InitializeComponent();
            USERID = userid;
        }
        DataTable dt = new DataTable();
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSuper_Load(object sender, EventArgs e)
        {
            QueryProCargo();
            List<int> Year = new List<int>();
            for (int i = DateTime.Now.Year - 5; i <= DateTime.Now.Year + 5; i++)
                Year.Add(i);
            //年月规划
            cbbBeginYear.DataSource = Year;
            cbbEndYear.DataSource = Year;
            cbbBeginYear.SelectedIndex = 0;
            cbbEndYear.SelectedIndex = 0;
            cbbBeginMonth.SelectedIndex = 0;
            cbbEndMonth.SelectedIndex = 0;
            //权限详细
            cbbUserLimit.ValueMember = "rightsLevel";
            cbbUserLimit.DisplayMember = "rightsName";
            cbbUserLimit.DataSource = WHBLL.BLL.GetUserLimits();
            //DataGridView数据绑定
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("type", 1);
            dgvUser.AutoGenerateColumns = false;
            dgvUser.AllowUserToAddRows = false;
            dgvUser.DataSource = WHBLL.BLL.GetUser(dictionary);

        }
        /// <summary>
        /// 获取详细的采购信息
        /// </summary>
        private void QueryProCargo()
        {
            rtbDetailed.Text = string.Empty;
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("internalOrderNumber", null);
            dictionary.Add("beginTime", null);
            dictionary.Add("endTime", null);
            dictionary.Add("type", 5);
            dt = WHBLL.BLL.QueryProcurement(dictionary);
            if (dt.Rows.Count <= 0)
            {
                lbPro.Items.Clear();
                rtbDetailed.Text = "无订单！";
                return;
            }
            lbPro.DisplayMember = "internalOrderNumber";
            lbPro.ValueMember = "internalOrderNumber";
            lbPro.DataSource = WHBLL.BLL.QueryPro();
        }
        /// <summary>
        /// 选择之后显示详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbPro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbPro.Items.Count <= 0)
                return;
            if (dt.Rows.Count <= 0) return;
            rtbDetailed.Text = string.Empty;
            StringBuilder sb = new StringBuilder();
            DataRow[] dr = dt.Select(string.Format("internalOrderNumber='{0}'", lbPro.SelectedValue.ToString()));
            int i = 0;
            double total = 0;
            double amount = 0;
            double price = 0;
            foreach (DataRow item in dr)
            {
                if (i++ < 1)
                    sb.Append(string.Format("详细信息如下：\n内部订单号：{0}\n正式订单号：{1}\n采购人：{2}\n客户姓名：{3}\n产品内容：\n", item["internalOrderNumber"].ToString(), item["officialOrderNumber"].ToString(), item["userName"].ToString(), item["customerCompany"].ToString()));
                sb.Append(string.Format("名称：{0}，规格型号：{1}，数量：{2}，采购单价：{3}RMB\n", item["productName"].ToString(), item["model"].ToString(), item["inventoryQuantity"].ToString(), item["purchasePrice"].ToString()));
                total += (Double.TryParse(item["inventoryQuantity"].ToString(), out amount) ? amount : 0) * (Double.TryParse(item["purchasePrice"].ToString(), out price) ? price : 0);
            }
            sb.Append(string.Format("总金额：{0}元", total));
            rtbDetailed.Text = sb.ToString();
        }

        private void 审核通过ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认通过？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                QueryProCargo();
                dictionary = new Dictionary<string, object>();
                dictionary.Add("internalOrderNumber", lbPro.SelectedValue.ToString());
                dictionary.Add("officialOrderNumber", null);
                dictionary.Add("operatorID", USERID);
                dictionary.Add("customerID", null);
                dictionary.Add("arrivalTime", null);
                dictionary.Add("creationTime", null);
                dictionary.Add("auditStatus", 1);
                dictionary.Add("completeState", 0);
                dictionary.Add("type", 2);
                int feedback = WHBLL.BLL.ExecuteProcurement(dictionary);
                if (feedback > 0)
                {
                    MessageBox.Show("审核成功！", "系统提示");
                    QueryProCargo();
                    rtbDetailed.Text = string.Empty;
                    
                }
            }
        }

        private void 驳回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认驳回？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                QueryProCargo();
                dictionary = new Dictionary<string, object>();
                dictionary.Add("internalOrderNumber", lbPro.SelectedValue.ToString());
                dictionary.Add("officialOrderNumber", null);
                dictionary.Add("operatorID", USERID);
                dictionary.Add("customerID", null);
                dictionary.Add("arrivalTime", null);
                dictionary.Add("creationTime", null);
                dictionary.Add("auditStatus", 0);
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
        /// <summary>
        /// 查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //验证
            foreach (Control item in groupBox2.Controls)
            {
                if (item is ComboBox)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        MessageBox.Show("查询年月不允许为空！", "系统提示");
                        return;
                    }
                }
            }
            if (Convert.ToInt32(cbbBeginYear.Text) > Convert.ToInt32(cbbEndYear.Text) || Convert.ToInt32(cbbBeginMonth.Text) > Convert.ToInt32(cbbEndMonth.Text))
            {
                MessageBox.Show("查询时间错误，请重新输入！", "系统提示");
                return;
            }
            //将总价值为零
            txtCount.Text = "0.00";
            //总价值代数
            double amount = 0;
            //获取始终时间
            string beginTime, endTime;
            beginTime = cbbBeginYear.Text + cbbBeginMonth.Text + "01";
            endTime = cbbEndYear.Text + cbbEndMonth.Text + "01";
            DateTime beginDate, endDate;
            beginDate = DateTime.ParseExact(beginTime, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            endDate = DateTime.ParseExact(endTime, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture).AddDays(-1);
            //查询数据
            dictionary = new Dictionary<string, object>();
            dictionary.Add("beginTime", beginDate);
            dictionary.Add("endTime", endDate);
            DataTable dt = WHBLL.BLL.GetMonthlyKnot(dictionary);
            if (dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] item = {(++i).ToString(),dt.Rows[i]["lastWarehousing"].ToString(), dt.Rows[i]["monthlyKnotProductID"].ToString(), dt.Rows[i]["productName"].ToString(), dt.Rows[i]["model"].ToString()
                            , dt.Rows[i]["purchasePrice"].ToString()+"("+ (Convert.ToBoolean(dt.Rows[i]["purchaseincludeTax"])?"是":"否").ToString()+")", dt.Rows[i]["beginmonthNumber"].ToString()
                            , dt.Rows[i]["monthlyInput"].ToString(), dt.Rows[i]["monthlyOutput"].ToString(), dt.Rows[i]["endmonthNumber"].ToString()
                            ,(Convert.ToDouble(dt.Rows[i]["purchasePrice"])*Convert.ToDouble(dt.Rows[i]["endmonthNumber"])).ToString()+"("+ (Convert.ToBoolean(dt.Rows[i]["purchaseincludeTax"])?"是":"否").ToString()+")" };
                    DataGridViewRow dgvr = new DataGridViewRow();
                    foreach (string data in item)
                    {
                        DataGridViewTextBoxCell dgvtbc = new DataGridViewTextBoxCell();
                        dgvtbc.Value = data;
                        dgvr.Cells.Add(dgvtbc);
                    }
                    dgvMonth.Rows.Add(dgvr);
                    amount+=Convert.ToDouble(dgvMonth.Rows[i].Cells["amount"].Value);
                }
                txtCount.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("该月无数据显示！", "系统提示");
                return;
            }
        }
        /// <summary>
        /// 创建新账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否新建用户账号？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //验证
                foreach (Control control in groupBox3.Controls)
                {
                    if (control is TextBox)
                    {
                        if (string.IsNullOrEmpty(control.Text.Trim()))
                        {
                            MessageBox.Show("请将信息填写完整！", "系统提示");
                            return;
                        }
                    }
                }
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                dictionary.Add("loginNumber", txtLoginNumber.Text);
                dictionary.Add("loginPwd", txtLoginPwd.Text);
                dictionary.Add("userName", txtUserName.Text);
                dictionary.Add("userRights", Convert.ToInt32(cbbUserLimit.SelectedValue));
                dictionary.Add("type", 1);
                if (WHBLL.BLL.ExecuteUser(dictionary) > 0)
                {
                    MessageBox.Show("操作成功！", "系统提示");
                    //清空
                    foreach (Control item in groupBox3.Controls)
                    {
                        if (item is TextBox)
                            item.Text = string.Empty;
                    }
                    //DataGridView数据绑定
                    Dictionary<string, object> dictionarys = new Dictionary<string, object>();
                    dictionarys.Add("type", 1);
                    dgvUser.DataSource = WHBLL.BLL.GetUser(dictionarys);
                }
                else
                {
                    MessageBox.Show("操作失败！", "系统提示");
                    return;
                }
            }
        }
        /// <summary>
        /// 单击显示登录账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNDLoginNumber.Text = dgvUser["loginNumber", e.RowIndex].Value.ToString();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定初始化？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("loginNumber", txtNDLoginNumber.Text);
                dictionary.Add("loginPwd", "0000000");
                dictionary.Add("userName", null);
                dictionary.Add("userRights", null);
                dictionary.Add("type", 2);
                if (WHBLL.BLL.ExecuteUser(dictionary) > 0)
                {
                    MessageBox.Show("初始化成功！", "系统提示");
                    txtNDLoginNumber.Text = string.Empty;
                    //DataGridView数据绑定
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    dictionary.Add("type", 1);
                    dgvUser.AutoGenerateColumns = false;
                    dgvUser.AllowUserToAddRows = false;
                    dgvUser.DataSource = WHBLL.BLL.GetUser(dictionary);
                }
                else
                {
                    MessageBox.Show("操作失败，请稍后再试！", "系统提示");
                    return;
                }
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dictionary = new Dictionary<string, object>();
                dictionary.Add("loginNumber", txtNDLoginNumber.Text);
                dictionary.Add("loginPwd", "0000000");
                dictionary.Add("userName", null);
                dictionary.Add("userRights", 0);
                dictionary.Add("type", 3);
                if (WHBLL.BLL.ExecuteUser(dictionary) > 0)
                {
                    MessageBox.Show("删除成功！", "系统提示");
                    txtNDLoginNumber.Text = string.Empty;
                    //DataGridView数据绑定
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    dictionary.Add("type", 1);
                    dgvUser.AutoGenerateColumns = false;
                    dgvUser.AllowUserToAddRows = false;
                    dgvUser.DataSource = WHBLL.BLL.GetUser(dictionary);
                }
                else
                {
                    MessageBox.Show("操作失败，请稍后再试！", "系统提示");
                    return;
                }
            }
        }
        /// <summary>
        /// 导出月结单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定导出？","系统提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                //导出
                WHBLL.ExportToExcel d = new WHBLL.ExportToExcel();
                d.OutputAsExcelFile(dgvMonth);
            }
        }
    }
}
