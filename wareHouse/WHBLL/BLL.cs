using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHDAL;
using System.Data;
using System.Data.SqlClient;

namespace WHBLL
{
   public  class BLL
    {
        /// <summary>
    /// 登录操作
    /// </summary>
    /// <param name="uid">用户账号</param>
    /// <param name="pwd">登录密码</param>
    /// <returns></returns>
        public static DataTable VerificationLogin(Dictionary<string,object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@loginPwd",dictionary["loginPwd"]),
                new SqlParameter("@loginNumber",dictionary["loginNumber"]),
                new SqlParameter("@type",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="id">用户账号</param>
        /// <returns></returns>
        public static DataTable GetCustomer(Dictionary<string,object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@customerNumber",dictionary["customerNumber"]),
                new SqlParameter("@type",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_customerinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="id">用户账号</param>
        /// <param name="pwd">新密码</param>
        /// <returns></returns>
        public static int UpdatePwd(Dictionary<string,object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@loginNumber",dictionary["loginNumber"]),
                new SqlParameter("@loginPwd",dictionary["loginPwd"]),
                new SqlParameter("@type",dictionary["type"])
            };
            int i = SQLHelper.Execute("SQL", "pro_execute_userinfo", param, CommandType.StoredProcedure);
            return i;
        }
        /// <summary>
        /// 获取供应商信息
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="typeid">执行类型</param>
        /// <returns></returns>
        public static DataTable GetSupplier(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@supplierNumber",dictionary["supplierNumber"]),
                new SqlParameter("@typeid",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_supplier", param, CommandType.StoredProcedure);
            return dt;
        }
       /// <summary>
       /// 添加采购订单
       /// </summary>
       /// <param name="pid"></param>
       /// <param name="uid"></param>
       /// <param name="buydate"></param>
       /// <param name="arrival"></param>
       /// <param name="isinvoice"></param>
       /// <param name="typeid"></param>
       /// <returns></returns>
        public static int InsProcurement(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param = 
            {
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"]),
                new SqlParameter("@officialOrderNumber",dictionary["officialOrderNumber"]),
                new SqlParameter("@operatorID",dictionary["operatorID"]),
                new SqlParameter("@customerID",dictionary["customerID"]),
                new SqlParameter("@arrivalTime",dictionary["arrivalTime"]),
                new SqlParameter("@creationTime",dictionary["creationTime"]),
                new SqlParameter("@auditStatus",dictionary["auditStatus"]),
                new SqlParameter("@completeState",dictionary["completeState"]),
                new SqlParameter("@typeid",dictionary["type"])
            };
            int i = SQLHelper.Execute("SQL", "pro_execute_purchaseOrder", param, CommandType.StoredProcedure);
            return i;
        }
        /// <summary>
        /// 添加采购货物
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="productID"></param>
        /// <param name="supplierid"></param>
        /// <param name="amount"></param>
        /// <param name="unitprice"></param>
        /// <param name="discount"></param>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public static int InsProcargo(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"]),
                new SqlParameter("@productID",dictionary["supplierNumber"]),
                new SqlParameter("@supportingProducts",dictionary["supportingProducts"]),
                new SqlParameter("@supplierNumber",dictionary["supplierNumber"]),
                new SqlParameter("@purchaseQuantity",dictionary["purchaseQuantity"]),
                new SqlParameter("@invoice",dictionary["invoice"]),
                new SqlParameter("@purchaseRemark",dictionary["purchaseRemark"]),
                new SqlParameter("@type",dictionary["type"])
            };
            int i = SQLHelper.Execute("SQL", "pro_execute_purchaseGoods", param, CommandType.StoredProcedure);
            return i;
        }
      /// <summary>
      /// 库存表操作
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pnid"></param>
      /// <param name="typeid"></param>
      /// <returns></returns>
        public static DataTable GetInventory(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param=
            {
                new SqlParameter("@inventoryNumber",dictionary["inventoryNumber"]),
                new SqlParameter("@productID",dictionary["productID"]),
                new SqlParameter("@productName",dictionary["productName"]),
                new SqlParameter("@model",dictionary["model"]),
                new SqlParameter("@purchasePrice",dictionary["purchasePrice"]),
                new SqlParameter("@purchaseincludeTax",dictionary["purchaseincludeTax"]),
                new SqlParameter("@salesPrice",dictionary["salesPrice"]),
                new SqlParameter("@salesincludeTax",dictionary["salesincludeTax"]),
                new SqlParameter("@unit",dictionary["unit"]),
                new SqlParameter("@inventoryQuantity",dictionary["inventoryQuantity"]),
                new SqlParameter("@lastWarehousing",dictionary["lastWarehousing"]),
                new SqlParameter("@stockOperatorID",dictionary["stockOperatorID"]),
                new SqlParameter("@typeid",dictionary["type"])
            };
            DataTable dt=SQLHelper.QueryDataTable("SQL", "pro_execute_stock", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 库存表插入修改数据
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int InsInventory(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@purchasePrice",dictionary["purchasePrice"]),
                new SqlParameter("@purchaseincludeTax",dictionary["purchaseincludeTax"]),
                new SqlParameter("@salesPrice",dictionary["salesPrice"]),
                new SqlParameter("@salesincludeTax",dictionary["salesincludeTax"]),
                new SqlParameter("@inventoryQuantity",dictionary["inventoryQuantity"]),
                new SqlParameter("@lastWarehousing",dictionary["lastWarehousing"]),
                new SqlParameter("@typeid",dictionary["type"])
            };
            int index= SQLHelper.Execute("SQL", "pro_execute_stock", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 通过编号查询订单的详细信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static DataTable QueryProcurement(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"]),
                new SqlParameter("@type",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_purchaseOrder", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 查询内部订单号
        /// </summary>
        /// <returns></returns>
        public static int QueryPID(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"])
            };
            int index = (int)SQLHelper.QueryScalar("SQL", "pro_search_purchaseOrder", param,CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 入库单添加信息
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="pid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int InsStorage(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@purchaseID",dictionary["purchaseID"]),
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"]),
                new SqlParameter("@receiptExpressNumber",dictionary["receiptExpressNumber"]),
                new SqlParameter("@receiptExpressCompany",dictionary["receiptExpressCompany"]),
                new SqlParameter("@productionPosition",dictionary["productionPosition"]),
                new SqlParameter("@supplierRelevantNumber",dictionary["supplierRelevantNumber"]),
                new SqlParameter("@storageDate",dictionary["storageDate"]),
                new SqlParameter("@CollectionQuantity",dictionary["CollectionQuantity"]),
                new SqlParameter("@wareOperatorID",dictionary["wareOperatorID"]),
                new SqlParameter("@invoiceNumber",dictionary["invoiceNumber"]),
                new SqlParameter("@wareRemark",dictionary["wareRemark"]),
                new SqlParameter("@wareState",dictionary["wareState"]),
                new SqlParameter("@type",dictionary["type"]),
            };
            int index = SQLHelper.Execute("SQL", "pro_cargo", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 通过内部订单号查询入库情况
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static DataTable QueryStorage(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"]),
                new SqlParameter("@type",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_warehousing", param, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public static DataTable GetUser(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@type",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 添加SN码
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="productid"></param>
        /// <param name="snid"></param>
        /// <returns></returns>
        public static int InsSNID(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@productID",dictionary["productID"]),
                new SqlParameter("@SNCode",dictionary["SNCode"]),
                new SqlParameter("@sell",dictionary["sell"]),
                new SqlParameter("@entryTime",dictionary["entryTime"]),
                new SqlParameter("@sellingTime",dictionary["sellingTime"]),
                new SqlParameter("@serielOperatorID",dictionary["serielOperatorID"]),
                new SqlParameter("@type",dictionary["type"])
            };
            int index = SQLHelper.Execute("SQL", "pro_execute_serial", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 查询SN表
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="productid"></param>
        /// <returns></returns>
        public static DataTable QuerySNID(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@serialNumber",dictionary["serialNumber"]),
                new SqlParameter("@productID",dictionary["productID"]),
                new SqlParameter("@SNCode",dictionary["SNCode"]),
                new SqlParameter("@type",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_snid", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// Excel读取
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable QueryExcel(string path,string sql)
        {
            DataTable dt = ExcelHelper.QueryExcel(path, sql);
            return dt;
        }
        /// <summary>
        /// 财务查询
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static DataTable QueryFinace(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_finance", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 财务插入
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int InsFinance(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@financialNumber",dictionary["financialNumber"]),
                new SqlParameter("@internalOrderNumber",dictionary["internalOrderNumber"]),
                new SqlParameter("@paymentDate",dictionary["paymentDate"]),
                new SqlParameter("@paymentAmount",dictionary["paymentAmount"]),
                new SqlParameter("@paymentRemark",dictionary["paymentRemark"]),
                new SqlParameter("@financeOperatorID",dictionary["financeOperatorID"]),
                new SqlParameter("@type",dictionary["type"])
            };
            int index = SQLHelper.Execute("SQL", "pro_execute_finance", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 通过合同订单号查询详细信息
        /// </summary>
        /// <param name="contractorder"></param>
        /// <returns></returns>
        public static DataTable QueryContractOrder(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@officialOrderNumber",dictionary["officialOrderNumber"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_outgoing", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 插入出库数据
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int InsDelivery(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@outgoingNumber",dictionary["outgoingNumber"]),
                new SqlParameter("@officialOrderNumber",dictionary["officialOrderNumber"]),
                new SqlParameter("@outgoingcustomerID",dictionary["outgoingcustomerID"]),
                new SqlParameter("@outgoingproductID",dictionary["outgoingproductID"]),
                new SqlParameter("@outgoingQuantity",dictionary["outgoingQuantity"]),
                new SqlParameter("@outgoingDiscount",dictionary["outgoingDiscount"]),
                new SqlParameter("@includeTax",dictionary["includeTax"]),
                new SqlParameter("@deliveryExpressnumber",dictionary["deliveryExpressnumber"]),
                new SqlParameter("@deliveryExpressCompany",dictionary["deliveryExpressCompany"]),
                new SqlParameter("@deliveryTime",dictionary["deliveryTime"]),
                new SqlParameter("@outgoingOperatorID",dictionary["outgoingOperatorID"]),
                new SqlParameter("@outgoingRemark",dictionary["outgoingRemark"]),
                new SqlParameter("@outgoingState",dictionary["outgoingState"]),
                new SqlParameter("@type",dictionary["type"]),
            };
            int feedback = SQLHelper.Execute("SQL", "pro_execute_outgoing", param, CommandType.StoredProcedure);
            return feedback;
        }
        /// <summary>
        /// 维修增加及更新
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static int InsMain(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@repairCustomernumber",dictionary["repairCustomernumber"]),
                new SqlParameter("@repairProductID",dictionary["repairProductID"]),
                new SqlParameter("@repairSNCode",dictionary["repairSNCode"]),
                new SqlParameter("@repairMeg",dictionary["repairMeg"]),
                new SqlParameter("@repairName",dictionary["repairName"]),
                new SqlParameter("@repairArrivalTime",dictionary["repairArrivalTime"]),
                new SqlParameter("@repairExpressNumber",dictionary["repairExpressNumber"]),
                new SqlParameter("@repairExpressCompany",dictionary["repairExpressCompany"]),
                new SqlParameter("@repairContacts",dictionary["repairContacts"]),
                new SqlParameter("@repairContactinfo",dictionary["repairContactinfo"]),
                new SqlParameter("@repairContactAddress",dictionary["repairContactAddress"]),
                new SqlParameter("@repairReturnTime",dictionary["repairReturnTime"]),
                new SqlParameter("@repairReturnExpressNumber",dictionary["repairReturnExpressNumber"]),
                new SqlParameter("@repairReturnExpressCompany",dictionary["repairReturnExpressCompany"]),
                new SqlParameter("@repairOperatorID",dictionary["repairOperatorID"]),
                new SqlParameter("@repairStatus",dictionary["repairStatus"]),
                new SqlParameter("@type",dictionary["type"]),
            };
            int index = SQLHelper.Execute("SQL", "pro_execute_repair", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 获取维修表信息
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable QueryMain(Dictionary<string, object> dictionary)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@repairCustomernumber",dictionary["repairCustomernumber"]),
                new SqlParameter("@repairProductID",dictionary["repairProductID"]),
                new SqlParameter("@repairSNCode",dictionary["repairSNCode"]),
                new SqlParameter("@type",dictionary["type"])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_repair", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 未审核的详细订单资料
        /// </summary>
        /// <returns></returns>
        public static DataTable QueryProCargo()
        {
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_cargo_pro", null, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 获取采购订单
        /// </summary>
        /// <returns></returns>
        public static DataTable QueryPro()
        {
            DataTable dt = SQLHelper.QueryDataTable("SQL", "select * from procurement where [check]=0", null, CommandType.Text);
            return dt;
        }
    }
}
