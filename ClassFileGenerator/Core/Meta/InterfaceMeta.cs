using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Settings;

namespace ClassFileGenerator.Core.Meta
{
    public class InterfaceMeta : IMeta
    {
        private readonly UsingSetting usingSetting = new UsingSetting();
        private readonly ImplementsSetting implementsSetting = new ImplementsSetting();
        private readonly MethodsSetting methodSetting = new MethodsSetting();

        public InterfaceMeta(string nameSpace, string interfaceName)
        {
            NameSpace = nameSpace;
            InterfaceName = interfaceName;
        }

        public string NameSpace { get; }
        public string InterfaceName { get; }
        public UsingDefinition[] UsingDefinitions => usingSetting.Usings;
        public MethodDefinition[] MethodDefinitions => methodSetting.Methods;
        public ImplementsSetting ImplementsSetting => implementsSetting;

        public UsingSetting SetupUsing()
        {
            return usingSetting;
        }

        public ImplementsSetting SetupImplements()
        {
            return implementsSetting;
        }

        public MethodsSetting SetupMethod()
        {
            return methodSetting;
        }
    }
}
