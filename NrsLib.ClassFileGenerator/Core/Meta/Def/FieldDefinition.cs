using NrsLib.ClassFileGenerator.Core.Meta.Words;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def {
    public class FieldDefinition {
        public FieldDefinition(string name)
        {
            Name = name;
        }

        internal string Name { get; }
        internal AccessLevel AccessLevel { get; private set; } = AccessLevel.Private;
        internal string Type { get; private set; } = "object";
        internal bool IsReadonly { get; private set; }
        internal string Value { get; private set; }

        public FieldDefinition SetAccessLevel(AccessLevel level)
        {
            AccessLevel = level;
            return this;
        }

        public FieldDefinition SetReadOnly(bool isReadonly)
        {
            IsReadonly = isReadonly;
            return this;
        }

        public FieldDefinition SetType(string type)
        {
            Type = type;
            return this;
        }

        public FieldDefinition SetValue(string value)
        {
            Value = value;
            return this;
        }
    }
}
