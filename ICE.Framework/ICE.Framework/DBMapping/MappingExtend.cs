using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Framework.DBMapping
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class MappingExtend
    {
        public static string GetTableName(this Type type)
        {
            if (type.IsDefined(typeof(DBTableAttribute),false))
            {
                var attribute = type.GetCustomAttribute<DBTableAttribute>();

                return attribute.GetTableName();
            }
            else
            {
                return type.Name;
            }
        }

        public static string GetColumnName(this MemberInfo member)
        {
            if (member.IsDefined(typeof(DBColumnAttribute),false))
            {
                var memberInfo = member.GetCustomAttribute<DBColumnAttribute>();

                return memberInfo.GetColumnName();
            }
            else
            {
                return member.Name;
            }
        }
    }
}
