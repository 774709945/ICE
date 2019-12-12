using System;

namespace ICE.Framework.DBMapping
{
    /// <summary>
    /// DB特性父类(因为PropertyInfo和Type拥有同一个父类MemberInfo)
    /// </summary>
    public class AbstractMappingAttribute : Attribute
    {
        private string _Name;

        public AbstractMappingAttribute(string name)
        {
            _Name = name;
        }

        public string GetName()
        {
            return _Name;
        }
    }
}
