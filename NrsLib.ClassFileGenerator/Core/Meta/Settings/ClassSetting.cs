namespace NrsLib.ClassFileGenerator.Core.Meta.Settings {
    public class ClassSetting
    {
        internal string NameSpace { get; private set; } = "YourNameSpace";
        internal string ClassName { get; private set; } = "YourClass";
        internal bool IsPartial { get; private set; }

        public ClassSetting SetNameSpace(string nameSpace)
        {
            NameSpace = nameSpace;
            return this;
        }

        public ClassSetting SetClassName(string className)
        {
            ClassName = className;
            return this;
        }

        public ClassSetting SetPartial(bool isPartial)
        {
            IsPartial = isPartial;
            return this;
        }
    }
}
