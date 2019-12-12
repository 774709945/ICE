using System;
using System.Configuration;

namespace ICE.Framework.DB
{
    public class BaseSql
    {
        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["connStr"].ToString();

        public string GetConnectionStr()
        {
            if (string.IsNullOrEmpty(_connStr))
            {
                throw new Exception("异常: 没有获取到数据库连接字符串");
            }

            return _connStr;
        }
    }
}
