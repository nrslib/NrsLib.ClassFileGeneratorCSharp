using NrsLib.ClassFileGenerator.Core.Meta;
using NrsLib.ClassFileGenerator.Core.Meta.Def;
using NrsLib.ClassFileGenerator.Core.Meta.Def.Methods;
using NrsLib.ClassFileGenerator.Core.Meta.Settings;

namespace NrsLib.ClassFileGenerator.Core.Templates.CSharp.Interface
{
    partial class Template : ITemplate
    {
        private readonly InterfaceMeta meta;

        public Template(InterfaceMeta meta)
        {
            this.meta = meta;
        }

        private string nameSpace => meta.NameSpace;
        private string interfaceName => meta.InterfaceName;
        private UsingDefinition[] usings => meta.UsingDefinitions;
        private MethodDefinition[] methods => meta.MethodDefinitions;
        private ImplementsSetting implementsSetting => meta.ImplementsSetting;
        private IArgumentFormatter formatter => new SimpleArgumenFormatter();
    }
}
