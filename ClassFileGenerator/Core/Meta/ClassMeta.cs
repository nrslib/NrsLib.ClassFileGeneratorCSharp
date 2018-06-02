using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Settings;

namespace ClassFileGenerator.Core.Meta
{
    public class ClassMeta : IMeta
    {
        private readonly UsingSetting usingSetting = new UsingSetting();
        private readonly ImplementsSetting implementsSetting = new ImplementsSetting();
        private readonly FieldsSetting fieldsSetting = new FieldsSetting();
        private readonly MethodsSetting methodSetting = new MethodsSetting();
        
        public ClassMeta(string nameSpace, string className)
        {
            NameSpace = nameSpace;
            ClassName = className;
        }

        internal string NameSpace { get; }
        internal string ClassName { get; }
        internal UsingDefinition[] UsingDefinitions => usingSetting.Usings;
        internal ImplementsSetting ImplementsSetting => implementsSetting;
        internal FieldDefinition[] fieldDefinitions => fieldsSetting.Fields;
        internal MethodDefinition[] MethodDefinitions => methodSetting.Methods;
        
        public UsingSetting SetupUsing()
        {
            return usingSetting;
        }

        public ImplementsSetting SetupImplements()
        {
            return implementsSetting;
        }

        public FieldsSetting SetupFields()
        {
            return fieldsSetting;
        }

        public MethodsSetting SetupMethods()
        {
            return methodSetting;
        }
    }
}
