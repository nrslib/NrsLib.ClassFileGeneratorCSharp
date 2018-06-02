using ClassFileGenerator.Core.Meta;
using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Settings;

namespace ClassFileGenerator.Core.Templates.CSharp.Interface
{
    partial class InterfaceTemplate : ITemplate
    {
        private readonly InterfaceMeta meta;

        public InterfaceTemplate(InterfaceMeta meta)
        {
            this.meta = meta;
        }

        private string nameSpace => meta.NameSpace;
        private string interfaceName => meta.InterfaceName;
        private UsingDefinition[] usings => meta.UsingDefinitions;
        private MethodDefinition[] methods => meta.MethodDefinitions;
        private ImplementsSetting implementsSetting => meta.ImplementsSetting;
    }
}
