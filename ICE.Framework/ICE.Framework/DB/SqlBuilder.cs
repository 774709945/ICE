﻿using ICE.Framework.DBMapping;
using System;
using System.Linq;

namespace ICE.Framework.DB
{
    /// <summary>
    /// Sql语句生成类
    /// </summary>
    public class SqlBuilder<T>
    {
        private static readonly string _FindSql;

        static SqlBuilder()
        {
            Type tp = typeof(T);
            {
                //查询sql语句
                string columnsStr = string.Join(",", tp.GetProperties().Select(u => $"[{u.GetMappingName()}]"));

                _FindSql = $"SELECT {columnsStr} FROM [{tp.GetMappingName()}] WHERE Id=";
            }
        }

        /// <summary>
        /// 获取通用查询sql
        /// </summary>
        /// <returns></returns>
        public static string GetFindSql()
        {
            return _FindSql;
        }
    }
}
