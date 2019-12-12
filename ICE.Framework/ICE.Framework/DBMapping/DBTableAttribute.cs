using System;

namespace ICE.Framework.DBMapping
{
    /// <summary>
    /// 实体对应数据库表名
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DBTableAttribute : Attribute
    {
        private string _tableName;

        public DBTableAttribute(string tableName)
        {
            _tableName = tableName;
        }

        public string GetTableName()
        {
            return _tableName;
        }
    }
}
