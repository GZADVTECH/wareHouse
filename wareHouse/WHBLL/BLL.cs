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
    /// <param name="uid"></param>
    /// <param name="pwd"></param>
    /// <returns></returns>
        public static DataTable GetLogin(string uid,string pwd)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@uid",uid),
                new SqlParameter("@pwd",pwd)
            };
            DataTable dt = SQLHelper.QueryDataTable("SQL", "pro_Login", param, CommandType.StoredProcedure);
            return dt;
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
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
    }
}
