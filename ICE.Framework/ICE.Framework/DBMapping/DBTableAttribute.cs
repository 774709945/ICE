using System;

namespace ICE.Framework.DBMapping
{
    /// <summary>
    /// 实体对应数据库表名
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DBTableAttribute : AbstractMappingAttribute
    {
        public DBTableAttribute(string tableName) : base(tableName)
        {

        }
    }
}
