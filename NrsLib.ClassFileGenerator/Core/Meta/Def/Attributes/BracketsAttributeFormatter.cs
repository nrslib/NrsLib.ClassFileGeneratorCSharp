using System.Linq;
using System.Text;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def.Attributes
{
    public class BracketsAttributeFormatter : IAttributeFormatter
    {
        public string Format(AttributeDefinition define)
        {
            var sb = new StringBuilder("[");
            sb.Append(define.TypeName);

            if (define.Arguments.Any())
            {
                sb.Append("(");
                var argsText = string.Join(",", define.Arguments);
                sb.Append(argsText);
                sb.Append(")");
            }

            sb.Append("]");
            return sb.ToString();
        }
    }
}
