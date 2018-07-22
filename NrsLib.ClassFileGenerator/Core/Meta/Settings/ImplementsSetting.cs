using System;
using System.Collections.Generic;
using System.Linq;
using NrsLib.ClassFileGenerator.Core.Meta.Def;

namespace NrsLib.ClassFileGenerator.Core.Meta.Settings
{
    public class ImplementsSetting
    {
        private readonly List<ImplementDefinition> implaments = new List<ImplementDefinition>();

        internal bool HasAny => implaments.Any();

        internal string HeadImplement => implaments.First().ToText();

        internal IEnumerable<string> TailImplement => implaments.Skip(1).Select(x => x.ToText());

        public ImplementsSetting AddImplements(InterfaceMeta interfaceMeta)
        {
            implaments.Add(new ImplementDefinition(interfaceMeta.InterfaceName));
            return this;
        }

        public ImplementsSetting AddImplements(string name, Action<ImplementDefinition> predicate = null)
        {
            var define = new ImplementDefinition(name);
            predicate?.Invoke(define);
            implaments.Add(define);
            return this;
        }
    }
}
