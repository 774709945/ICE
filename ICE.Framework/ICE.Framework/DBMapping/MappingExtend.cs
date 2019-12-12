using System.Reflection;

namespace ICE.Framework.DBMapping
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class MappingExtend
    {
        public static string GetMappingName(this MemberInfo type)
        {
            if (type.IsDefined(typeof(AbstractMappingAttribute), false))
            {
                var attribute = type.GetCustomAttribute<AbstractMappingAttribute>();

                return attribute.GetName();
            }
            else
            {
                return type.Name;
            }
        }

    }
}
