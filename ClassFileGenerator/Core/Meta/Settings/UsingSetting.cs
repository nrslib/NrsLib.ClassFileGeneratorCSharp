using System.Collections.Generic;
using ClassFileGenerator.Core.Meta.Def;

namespace ClassFileGenerator.Core.Meta.Settings
{
    public class UsingSetting
    {
        private readonly List<UsingDefinition> usings = new List<UsingDefinition>();

        internal UsingDefinition[] Usings => usings.ToArray();

        public UsingSetting AddUsing(UsingDefinition usingDefinition)
        {
            usings.Add(usingDefinition);
            return this;
        }

        public UsingSetting AddUsing(string name)
        {
            var define = new UsingDefinition(name);
            usings.Add(define);
            return this;
        }

        public UsingSetting AddUsing(IEnumerable<UsingDefinition> args)
        {
            usings.AddRange(args);
            return this;
        }
    }
}
