using System.Collections.Generic;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def {
    public class GenericDefinition
    {
        private readonly List<string> conditions = new List<string>();

        public GenericDefinition(string name)
        {
            Name = name;
        }

        internal string Name { get; }
        internal string Condition => string.Join(",", conditions);

        public GenericDefinition AddWhere(string condition)
        {
            conditions.Add(condition);
            return this;
        }
    }
}
