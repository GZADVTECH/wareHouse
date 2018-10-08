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
        public static DataTable VerificationLogin(string uid,string pwd)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@uid",uid),
                new SqlParameter("@pwd",pwd)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_search_userinfo", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id">用户账号</param>
        /// <returns></returns>
        public static DataTable GetClient(int id,string name,string way,string address)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@id",id),
                new SqlParameter("@name",name),
                new SqlParameter("@way",way),
                new SqlParameter("@address",address)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_Client", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="id">用户账号</param>
        /// <param name="pwd">新密码</param>
        /// <returns></returns>
        public static int UpdatePwd(string id,string pwd)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@uid",id),
                new SqlParameter("@pwd",pwd)
            };
            int i = SQLHelper.Execute("SQL", "update user_Message set userID=@uid where userPwd=@pwd", param, CommandType.Text);
            return i;
        }
        /// <summary>
        /// 获取供应商信息
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="typeid">执行类型</param>
        /// <returns></returns>
        public static DataTable GetSupplier(string name,int typeid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@name",name),
                new SqlParameter("@typeid",typeid)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_supplier", param, CommandType.StoredProcedure);
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
        public static int InsProcurement(string pid,string orderid,string uid,DateTime buydate,DateTime arrival,string cid,int typeid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",pid),
                new SqlParameter("@orderid",orderid),
                new SqlParameter("@userid",uid),
                new SqlParameter("@buydate",buydate),
                new SqlParameter("@arrivaldate",arrival),
                new SqlParameter("@cid",cid),
                new SqlParameter("@typeid",typeid)
            };
            int i = SQLHelper.Execute("SQL", "pro_procurement", param, CommandType.StoredProcedure);
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
        public static int InsProcargo(string pid,string productID,bool isparts,int supplierid,int amount,decimal unitprice,bool istax,double discount, bool isinvoice,int typeid,bool sellistax,decimal sellprice)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",pid),
                new SqlParameter("@productID",productID),
                new SqlParameter("@isparts",isparts),
                new SqlParameter("@supplierid",supplierid),
                new SqlParameter("@amount",amount),
                new SqlParameter("@istax",istax),
                new SqlParameter("@unitprice",unitprice),
                new SqlParameter("@sellistax",sellistax),
                new SqlParameter("@sellprice",sellprice),
                new SqlParameter("@discount",discount),
                new SqlParameter("@isInvoice",isinvoice),
                new SqlParameter("@typeid",typeid)
            };
            int i = SQLHelper.Execute("SQL", "pro_procargo", param, CommandType.StoredProcedure);
            return i;
        }
      /// <summary>
      /// 库存表操作
      /// </summary>
      /// <param name="name"></param>
      /// <param name="pnid"></param>
      /// <param name="typeid"></param>
      /// <returns></returns>
        public static DataTable GetInventory(int typeid,params string[] item)
        {
            SqlParameter[] param=
            {
                new SqlParameter("@pid",item[0]),
                new SqlParameter("@productname",item[1]),
                new SqlParameter("@pnid",item[2]),
                new SqlParameter("@unitprice",item[3]),
                new SqlParameter("@unit",item[4]),
                new SqlParameter("@quantity",item[5]),
                new SqlParameter("@typeid",typeid)
            };
            DataTable dt=SQLHelper.QueryDataTable("SQL", "pro_inventory", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 库存表插入修改数据
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int InsInventory(int typeid,params string[] item)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",item[0]),
                new SqlParameter("@productname",item[1]),
                new SqlParameter("@pnid",item[2]),
                new SqlParameter("@unitprice",item[3]),
                new SqlParameter("@unit",item[4]),
                new SqlParameter("@quantity",item[5]),
                new SqlParameter("@typeid",typeid)
            };
            int index= SQLHelper.Execute("SQL", "pro_inventory", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 通过编号查询订单的详细信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static DataTable QueryProcurement(string pid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",pid)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_proc_inven", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 查询内部订单号
        /// </summary>
        /// <returns></returns>
        public static int QueryPID(string pid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",pid)
            };
            int index = (int)SQLHelper.QueryScalar("SQL", "select Count(pID) from procurement where pID=@pid", param,CommandType.Text);
            return index;
        }
        /// <summary>
        /// 入库单添加信息
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="pid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int InsStorage(int typeid,string pid,params string[] data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@storageid",data[11]),
                new SqlParameter("@pid",pid),
                new SqlParameter("@typeid",typeid),
                new SqlParameter("@tid",data[0]),
                new SqlParameter("@tname",data[1]),
                new SqlParameter("@location",data[2]),
                new SqlParameter("@soid",data[3]),
                new SqlParameter("@deliverydate",data[4]),
                new SqlParameter("@productid",data[5]),
                new SqlParameter("@actualamount",data[6]),
                new SqlParameter("@consigneeid",data[7]),
                new SqlParameter("@invoiceid",data[8]),
                new SqlParameter("@checktaker",data[9]),
                new SqlParameter("@remark",data[10])
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
        public static DataTable QueryStorage(int typeid,string pid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",pid),
                new SqlParameter("@typeid",typeid)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_cargo", param, CommandType.StoredProcedure);
            return dt;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public static DataTable GetUser(int typeid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@typeid",typeid)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_user", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 添加SN码
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="productid"></param>
        /// <param name="snid"></param>
        /// <returns></returns>
        public static int InsSNID(string pid,string productid,string snid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@typeid",1),
                new SqlParameter("@pid",pid),
                new SqlParameter("@productid",productid),
                new SqlParameter("@snid",snid)
            };
            int index = SQLHelper.Execute("SQL", "pro_snid", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 查询SN表
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="productid"></param>
        /// <returns></returns>
        public static DataTable QuerySNID(string pid,string productid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",pid),
                new SqlParameter("@productid",productid),
                new SqlParameter("@typeid","0")
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
        public static DataTable QueryFinace(string pid)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@pid",pid)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_finace", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 财务插入
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int InsFinance(int typeid,params string[] data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("typeid",typeid),
                new SqlParameter("pid",data[0]),
                new SqlParameter("financeID",data[1]),
                new SqlParameter("payDate",data[2]),
                new SqlParameter("paySum",data[3]),
                new SqlParameter("remark",data[4])
            };
            int index = SQLHelper.Execute("SQL", "pro_finance", param, CommandType.StoredProcedure);
            return index;
        }
        /// <summary>
        /// 通过合同订单号查询详细信息
        /// </summary>
        /// <param name="contractorder"></param>
        /// <returns></returns>
        public static DataTable QueryContractOrder(string contractorder)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@contractorder",contractorder)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_contractOrder", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 插入出库数据
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int InsDelivery(int typeid,params string[] data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@typeid",typeid),
                new SqlParameter("@orderid",data[0]),
                new SqlParameter("@cid",data[1]),
                new SqlParameter("@productid",data[2]),
                new SqlParameter("@count",data[3]),
                new SqlParameter("@sellingPrice",data[4]),
                new SqlParameter("@discount",data[5]),
                new SqlParameter("@deliveryistax",data[6]),
                new SqlParameter("@discountprice",data[7]),
                new SqlParameter("@sellingprices",data[8]),
                new SqlParameter("@trackingid",data[9]),
                new SqlParameter("@trackingname",data[10]),
                new SqlParameter("@arrivaldate",data[11]),
                new SqlParameter("@consignerid",data[12]),
                new SqlParameter("@remark",data[13])
            };
            int feedback = SQLHelper.Execute("SQL", "pro_delivery", param, CommandType.StoredProcedure);
            return feedback;
        }
        public static int InsMain(params string[] data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@cid",data[0]),
                new SqlParameter("@proid",data[1]),
                new SqlParameter("@snid",data[2]),
                new SqlParameter("@mainmsg",data[3]),
                new SqlParameter("@mainname",data[4]),
                new SqlParameter("@arrivaldate",data[5]),
                new SqlParameter("@trackingid",data[6]),
                new SqlParameter("@trackingname",data[7]),
                new SqlParameter("@contid",data[8]),
                new SqlParameter("@returnproid",data[9]),
                new SqlParameter("@returndate",data[10]),
                new SqlParameter("@returntrackid",data[11]),
                new SqlParameter("@returntrackname",data[12])
            };
            int index = SQLHelper.Execute("SQL", "insert into maintenanceTable values(@cid,@proid,@snid,@mainmsg,@mainname,@arrivaldate,@trackingid,@trackingname,@contid,@returnproid,@returndate,@returntrackid,@returntrackname)", param, CommandType.Text);
            return index;
        }
        /// <summary>
                 /// 更新维修表信息
                 /// </summary>
                 /// <param name="typeid"></param>
                 /// <param name="data"></param>
                 /// <returns></returns>
        public static int UpdateMain(params string[] data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@cid",data[0]),
                new SqlParameter("@proid",data[1]),
                new SqlParameter("@snid",data[2]),
                new SqlParameter("@mainmsg",data[3]),
                new SqlParameter("@mainname",data[4]),
                new SqlParameter("@arrivaldate",data[5]),
                new SqlParameter("@trackingid",data[6]),
                new SqlParameter("@trackingname",data[7]),
                new SqlParameter("@contid",data[8]),
                new SqlParameter("@returnproid",data[9]),
                new SqlParameter("@returndate",data[10]),
                new SqlParameter("@returntrackid",data[11]),
                new SqlParameter("@returntrackname",data[12])
            };
            int index = SQLHelper.Execute("SQL", "update maintenanceTable set maintenanceMsg=@mainmsg,@mainname=@mainname,arrivalDate=@arrivaldate,trackingID=@trackingid,trackingName=@trackingname,contactsID=@contid, returnproductID = @returnproid, returnDate = @returndate, returntrackingID = @returntrackid, returntrackingName = @returntrackname where cID = @cid and productID = @proid and SNID = @snid", param, CommandType.Text);
            return index;
        }
        /// <summary>
        /// 获取维修表信息
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable QueryMain(string[] data)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@typeid","0"),
                new SqlParameter("@cid",data[0]),
                new SqlParameter("@proid",data[1]),
                new SqlParameter("@snid",data[2])
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_maintenance", param, CommandType.StoredProcedure);
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
        /// 更新审核
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="check"></param>
        /// <returns></returns>
        public static int UpdatePro(string pid,int check)
        {
            SqlParameter[] param = { new SqlParameter("@check", check),new SqlParameter("@pID",pid) };
            int feedback = SQLHelper.Execute("SQL", "update procurement set [check]=@check where pID=@pID", param, CommandType.Text);
            return feedback;
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
