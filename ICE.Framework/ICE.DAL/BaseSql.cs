using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.DAL
{
    public class BaseSql
    {
        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["connStr"].ToString();

        public string GetConnectionStr()
        {
            if (string.IsNullOrEmpty(_connStr))
            {
                throw new Exception("异常:数据库连接字符串为空");
            }

            return _connStr;
        }
    }
}
