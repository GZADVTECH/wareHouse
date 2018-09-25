using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace WHDAL
{
   public class ExcelHelper
    {
        public static DataTable QueryExcel(string path,string sql)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new Exception("未设置参数：path");
            }
            if (string .IsNullOrEmpty(sql))
            {
                throw new Exception("未设置参数：sql");
            }
            string strCon = @"provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=NO;IMEX=1'";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))//建立连接
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))//执行语句
                    {
                        using (OleDbDataAdapter da=new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                System.Text.StringBuilder log = new StringBuilder();
                log.Append("查询数据出错");
                log.Append(ex);
                throw new Exception(log.ToString());
            }
            
        }
    }
}
