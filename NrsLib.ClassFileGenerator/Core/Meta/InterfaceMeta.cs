using NrsLib.ClassFileGenerator.Core.Meta.Def;
using NrsLib.ClassFileGenerator.Core.Meta.Settings;

namespace NrsLib.ClassFileGenerator.Core.Meta
{
    public class InterfaceMeta : IMeta
    {
        private readonly UsingSetting usingSetting = new UsingSetting();
        private readonly ImplementsSetting implementsSetting = new ImplementsSetting();
        private readonly FieldsSetting fieldSetting = new FieldsSetting();
        private readonly MethodsSetting methodSetting = new MethodsSetting();

        public InterfaceMeta(string nameSpace, string interfaceName)
        {
            NameSpace = nameSpace;
            InterfaceName = interfaceName;
        }

        public string NameSpace { get; }
        public string InterfaceName { get; }
        public UsingDefinition[] UsingDefinitions => usingSetting.Usings;
        public ImplementsSetting ImplementsSetting => implementsSetting;
        public FieldDefinition[] FieldDefinitions => fieldSetting.Fields;
        public MethodDefinition[] MethodDefinitions => methodSetting.Methods;
        
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
            return fieldSetting;
        }

        public MethodsSetting SetupMethod()
        {
            return methodSetting;
        }
    }
}
