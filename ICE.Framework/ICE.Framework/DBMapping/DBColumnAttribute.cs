using System;

namespace ICE.Framework.DBMapping
{
    /// <summary>
    /// 实体属性对应数据库字段名称
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DBColumnAttribute : Attribute
    {
        private string _columnName;

        public DBColumnAttribute(string columnName)
        {
            _columnName = columnName;
        }

        public string GetColumnName()
        {
            return _columnName;
        }
    }
}
