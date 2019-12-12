using System;

namespace ICE.Framework.DBMapping
{
    /// <summary>
    /// 实体属性对应数据库字段名称
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DBColumnAttribute : AbstractMappingAttribute
    {
        public DBColumnAttribute(string columnName) : base(columnName)
        {

        }
    }
}
