namespace NrsLib.ClassFileGenerator.Core.Meta.Def.Methods {
    class SimpleArgumenFormatter : IArgumentFormatter {
        public string Format(VariantDefinition arg)
        {
            return arg.Type + " " + arg.Name;
        }
    }
}
