using System.Collections.Generic;
using System.Linq;
using NrsLib.ClassFileGenerator.Core.Meta.Def.Methods;
using NrsLib.ClassFileGenerator.Core.Meta.Words;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def {
    public class ConstructorDefinition {
        private readonly List<VariantDefinition> arguments = new List<VariantDefinition>();
        private readonly List<string> body = new List<string>();

        internal AccessLevel AccessLevel { get; private set; } = AccessLevel.Private;
        internal string[] Body => body.ToArray();

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

        public ConstructorDefinition AddBody(params string[] texts) {
            body.AddRange(texts);
            return this;
        }

        internal string ArgumentsText(IArgumentFormatter fomatter) {
            return string.Join(", ", arguments.Select(fomatter.Format));
        }
    }
}
