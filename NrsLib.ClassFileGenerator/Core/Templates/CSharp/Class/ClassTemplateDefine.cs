using NrsLib.ClassFileGenerator.Core.Meta;
using NrsLib.ClassFileGenerator.Core.Meta.Def;
using NrsLib.ClassFileGenerator.Core.Meta.Def.Methods;
using NrsLib.ClassFileGenerator.Core.Meta.Settings;

namespace NrsLib.ClassFileGenerator.Core.Templates.CSharp.Class
{
    partial class ClassTemplate: ITemplate
    {
        private readonly ClassMeta meta;

        public ClassTemplate(ClassMeta meta)
        {
            this.meta = meta;
        }

        private string nameSpace => meta.ClassSetting.NameSpace;
        private string className => meta.ClassSetting.ClassName;
        private bool isPartial => meta.ClassSetting.IsPartial;
        private UsingDefinition[] usings => meta.UsingDefinitions;
        private ImplementsSetting implementsSetting => meta.ImplementsSetting;
        private ConstructorDefinition[] constructors => meta.Constructors;
        private FieldDefinition[] fields => meta.FieldDefinitions;
        private PropertyDefinition[] properties => meta.PropertyDefinitions;
        private MethodDefinition[] methods => meta.MethodDefinitions;
        private IArgumentFormatter formatter => new SimpleArgumenFormatter();
    }
}
