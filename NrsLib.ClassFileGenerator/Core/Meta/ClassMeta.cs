using NrsLib.ClassFileGenerator.Core.Meta.Def;
using NrsLib.ClassFileGenerator.Core.Meta.Settings;

namespace NrsLib.ClassFileGenerator.Core.Meta
{
    public class ClassMeta : IMeta
    {
        private readonly ClassSetting classSetting = new ClassSetting();
        private readonly ConstructorSetting constructorSetting = new ConstructorSetting();
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
        internal ConstructorDefinition[] Constructors => constructorSetting.Constructors;
        internal UsingDefinition[] UsingDefinitions => usingSetting.Usings;
        internal ImplementsSetting ImplementsSetting => implementsSetting;
        internal FieldDefinition[] fieldDefinitions => fieldsSetting.Fields;
        internal MethodDefinition[] MethodDefinitions => methodSetting.Methods;

        public ClassSetting SetupClass()
        {
            return classSetting;
        }

        public ConstructorSetting SetupConstructor()
        {
            return constructorSetting;
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
