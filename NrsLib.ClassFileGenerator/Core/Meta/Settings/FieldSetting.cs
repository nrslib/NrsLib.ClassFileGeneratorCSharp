using System;
using System.Collections.Generic;
using NrsLib.ClassFileGenerator.Core.Meta.Def;

namespace NrsLib.ClassFileGenerator.Core.Meta.Settings {
    public class FieldsSetting {
        private readonly List<FieldDefinition> fields = new List<FieldDefinition>();

        internal FieldDefinition[] Fields => fields.ToArray();

        public FieldsSetting AddField(string name, Action<FieldDefinition> predicate = null)
        {
            var field = new FieldDefinition(name);
            predicate?.Invoke(field);
            fields.Add(field);
            return this;
        }
    }
}
