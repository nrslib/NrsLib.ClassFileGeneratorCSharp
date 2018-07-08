namespace ClassFileGenerator.Core.Meta.Def.Methods {
    class InvertWithColonArgumentFormatter : IArgumentFormatter{
        public string Format(VariantDefinition arg)
        {
            return arg.Name + ": " + arg.Type;
        }
    }
}
