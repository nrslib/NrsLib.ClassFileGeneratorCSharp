using System.Collections.Generic;
using System.Linq;
using ClassFileGenerator.Core.Meta.Def.Methods;
using ClassFileGenerator.Core.Meta.Words;

namespace ClassFileGenerator.Core.Meta.Def {
    public class ConstructorDefinition {
        private readonly List<VariantDefinition> arguments = new List<VariantDefinition>();

        internal AccessLevel AccessLevel { get; private set; } = AccessLevel.Private;

        public ConstructorDefinition AddArgument(string name, string type)
        {
            arguments.Add(new VariantDefinition(name, type));
            return this;
        }

        public ConstructorDefinition SetAccessLevel(AccessLevel level)
        {
            AccessLevel = level;
            return this;
        }

        internal string ArgumentsText(IArgumentFormatter fomatter) {
            return string.Join(", ", arguments.Select(fomatter.Format));
        }
    }
}
