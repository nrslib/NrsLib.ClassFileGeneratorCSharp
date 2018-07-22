using System;
using System.Collections.Generic;
using System.Linq;
using NrsLib.ClassFileGenerator.Core.Meta.Def.Methods;
using NrsLib.ClassFileGenerator.Core.Meta.Words;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def
{
    public class MethodDefinition
    {
        private readonly List<VariantDefinition> arguments = new List<VariantDefinition>();
        private readonly List<string> body = new List<string>();
        private readonly List<GenericDefinition> genericDefinitions = new List<GenericDefinition>();
        private bool noneBody;

        public MethodDefinition(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(nameof(name), "empty");
            Name = name;
        }

        internal AccessLevel AccessLevel { get; private set; } = AccessLevel.Private;
        internal string ReturnType { get; private set; } = "void";
        internal string Name { get; }
        internal VariantDefinition[] Arguments => arguments.ToArray();
        internal string[] Body => body.Count <= 0 && !noneBody ? new []{"throw new NotImplementedException();"} : body.ToArray();
        internal bool HasAnyGenerics => genericDefinitions.Any();
        internal string GenericsList => string.Join(", ", genericDefinitions.Select(x => x.Name));
        internal bool HasAnyGenericsWhere => GenericsWheres.Any();
        internal string[] GenericsWheres => genericDefinitions.Select(x => $"{x.Name} : {x.Condition}").ToArray();

        public MethodDefinition NoBodyOnNoLine(bool noneBody)
        {
            this.noneBody = noneBody;
            return this;
        }

        public MethodDefinition SetAccessLevel(AccessLevel level)
        {
            AccessLevel = level;
            return this;
        }

        public MethodDefinition SetReturnType(string returnType)
        {
            ReturnType = returnType;
            return this;
        }

        public MethodDefinition AddArgument(string name, string type)
        {
            arguments.Add(new VariantDefinition(name, type));
            return this;
        }

        public MethodDefinition AddBody(params string[] texts)
        {
            body.AddRange(texts);
            return this;
        }

        public MethodDefinition AddGenerics(string name, Action<GenericDefinition> predicate = null)
        {
            var instance = new GenericDefinition(name);
            predicate?.Invoke(instance);
            genericDefinitions.Add(instance);
            return this;
        }

        internal string ArgumentsText(IArgumentFormatter fomatter)
        {
            return string.Join(", ", Arguments.Select(fomatter.Format));
        }
    }
}
