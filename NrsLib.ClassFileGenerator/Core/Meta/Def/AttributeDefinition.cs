using System.Collections.Generic;
using NrsLib.ClassFileGenerator.Core.Meta.Def.Attributes;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def
{
    public class AttributeDefinition
    {
        public AttributeDefinition(string typeName)
        {
            TypeName = typeName;
        }

        internal string TypeName { get; }
        internal List<string> Arguments { get; set; } = new List<string>();

        public AttributeDefinition AddArgument(string argument)
        {
            Arguments.Add(argument);
            return this;
        }

        internal string ToText(IAttributeFormatter formatter)
        {
            return formatter.Format(this);
        }
    }
}
