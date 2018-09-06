using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHMODELS
{
    /// <summary>
    /// 用户信息
    /// </summary>
   public class userMessage
    {
        /// <summary>
        /// 用户账号
        /// </summary>
        public string userID { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// 访问等级
        /// </summary>
        public int userLimit { get; set; }
    }
}
