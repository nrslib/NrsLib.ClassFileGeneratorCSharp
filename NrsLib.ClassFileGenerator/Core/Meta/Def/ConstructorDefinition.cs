using System;
using System.Collections.Generic;
using System.Linq;
using NrsLib.ClassFileGenerator.Core.Meta.Def.Methods;
using NrsLib.ClassFileGenerator.Core.Meta.Words;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def {
    public class ConstructorDefinition {
        private readonly List<VariantDefinition> arguments = new List<VariantDefinition>();
        private readonly List<string> body = new List<string>();
        private readonly List<string> callArguments = new List<string>();
        
        internal AccessLevel AccessLevel { get; private set; } = AccessLevel.Private;
        internal string[] Body => body.ToArray();
        internal bool CallBase { get; private set; }
        internal bool CallThis { get; private set; }

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

        public ConstructorDefinition SetCallBase(params string[] args)
        {
            if (CallThis)
            {
                throw new InvalidOperationException("This constructor is setting up call this().");
            }

            CallBase = true;
            callArguments.AddRange(args);
            
            return this;
        }

        public ConstructorDefinition SetCallThis(params string[] args)
        {
            if (CallBase)
            {
                throw new InvalidOperationException("This constructor is setting up call base().");
            }

            CallThis = true;
            callArguments.AddRange(args);

            return this;
        }

        internal string ArgumentsText(IArgumentFormatter fomatter) {
            return string.Join(", ", arguments.Select(fomatter.Format));
        }

        internal string CallArgumentsText()
        {
            return string.Join(", ", callArguments);
        }
    }
}
