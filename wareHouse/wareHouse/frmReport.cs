using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
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
    public partial class frmReport : Form
    {
        string PID = null;
        int INDEX = -1;
        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(int index)
        {
            InitializeComponent();
            this.INDEX = index;
        }
        public frmReport(string pid,int index)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.PID = pid;
            this.INDEX = index;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            switch (INDEX)
            {
                //默认错误
                case -1:break;
                    //采购通知单
                case 0:
                    //窗体加载
                    Procurement("purchaseOrder.rpt");
                    //传递参数
                    ParamField(crystalReportViewer1, "内部订单号", PID.ToString());
                    break;
                    //收获通知单
                case 1:
                    //窗体加载
                    Procurement("ReceiptNotice.rpt");
                    //传递参数
                    ParamField(crystalReportViewer1, "内部订单号", PID.ToString());
                    break;
                case 2:
                    //窗体加载
                    Procurement("Stock.rpt");
                    break;
                default:
                    break;
            }
            
        }
        /// <summary>
        /// 参数字段赋值
        /// </summary>
        /// <param name="crystalReportViewer">报表名称</param>
        /// <param name="FieldName">参数字段名称</param>
        /// <param name="name">值</param>
        public void ParamField(CrystalReportViewer crystalReportViewer,string FieldName, string name)
        {
            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue discreteVal = new ParameterDiscreteValue();
            //   第一个参数是具有多个值的离散参数。设置参数字段的名称，它必须和报表中的参数相符。   
            paramField.ParameterFieldName = FieldName;
            //   设置离散值并将其传递给该参数。
            discreteVal.Value = name;
            paramField.CurrentValues.Add(discreteVal);
            //   将该参数添加到参数字段集合。
            paramFields.Add(paramField);
            //   将参数字段集合放入查看器控件。   
            crystalReportViewer.ParameterFieldInfo = paramFields;
        }

        private void Procurement(string rpt)
        {
            try
            {
                string CRPath = @"F:\Items\C#\希创仓库管理系统\wareHouse\wareHouse\"+rpt;//拼接水晶报表模板路径
                ReportDocument reportdocument = new ReportDocument();
                reportdocument.Load(CRPath);//加载模板
                //默认账号密码
                TableLogOnInfo logInfo = new TableLogOnInfo();
                logInfo.ConnectionInfo.UserID = "sa";
                logInfo.ConnectionInfo.Password = "111-aaa";
                reportdocument.Database.Tables[0].ApplyLogOnInfo(logInfo);
                //reportdocument.SetDataSource(datatable);
                this.crystalReportViewer1.ReportSource = reportdocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message.ToString());
            }
        }
    }
}
