using ClassFileGenerator.Core.Meta;
using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Settings;

namespace ClassFileGenerator.Core.Templates.Typescript.Interface {
    partial class Template : ITemplate {
        private readonly InterfaceMeta meta;

        public Template(InterfaceMeta meta) {
            this.meta = meta;
        }

        private string nameSpace => meta.NameSpace;
        private string interfaceName => meta.InterfaceName;
        private UsingDefinition[] usings => meta.UsingDefinitions;
        private FieldDefinition[] fields => meta.FieldDefinitions;
        private MethodDefinition[] methods => meta.MethodDefinitions;
        private ImplementsSetting implementsSetting => meta.ImplementsSetting;
    }
}
