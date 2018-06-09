using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Settings;

namespace ClassFileGenerator.Core.Meta
{
    public class ClassMeta : IMeta
    {
        private readonly ClassSetting classSetting = new ClassSetting();
        private readonly UsingSetting usingSetting = new UsingSetting();
        private readonly ImplementsSetting implementsSetting = new ImplementsSetting();
        private readonly FieldsSetting fieldsSetting = new FieldsSetting();
        private readonly MethodsSetting methodSetting = new MethodsSetting();

        public ClassMeta(string nameSpace, string className)
        {
            classSetting
                .SetNameSpace(nameSpace)
                .SetClassName(className);
        }

        public ClassMeta()
        {
        }

        internal ClassSetting ClassSetting => classSetting;
        internal UsingDefinition[] UsingDefinitions => usingSetting.Usings;
        internal ImplementsSetting ImplementsSetting => implementsSetting;
        internal FieldDefinition[] fieldDefinitions => fieldsSetting.Fields;
        internal MethodDefinition[] MethodDefinitions => methodSetting.Methods;

        public ClassSetting SetupClass()
        {
            return classSetting;
        }
        
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
