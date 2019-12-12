using System;
using System.Configuration;

namespace ICE.Framework
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
