using ClassFileGenerator.Core.Meta;
using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Def.Methods;
using ClassFileGenerator.Core.Meta.Settings;

namespace ClassFileGenerator.Core.Templates.CSharp.Class
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
        private FieldDefinition[] fields => meta.fieldDefinitions;
        private MethodDefinition[] methods => meta.MethodDefinitions;
        private IArgumentFormatter formatter => new SimpleArgumenFormatter();
    }
}
