using System.Collections.Generic;
using System.Linq;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def
{
    public class ImplementDefinition
    {
        private readonly string name;
        private readonly List<string> generics;

        public ImplementDefinition(string name, params string[] generics)
        {
            this.name = name;
            this.generics = generics.ToList();
        }

        public string ToText()
        {
            if (generics.Any())
            {
                return name + "<" + string.Join(", ", generics) + ">";
            }
            else
            {
                return name;
            }
        }

        public ImplementDefinition AddGeneric(string generic, params string[] args)
        {
            generics.Add(generic);
            generics.AddRange(args);
            return this;
        }
    }
}
