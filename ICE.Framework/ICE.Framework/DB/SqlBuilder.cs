﻿using ICE.Framework.DBMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string columnsStr = string.Join(",", tp.GetProperties().Select(u => $"[{u.GetColumnName()}]"));

                _FindSql = $"SELECT {columnsStr} FROM [{tp.GetTableName()}] WHERE Id=";
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
