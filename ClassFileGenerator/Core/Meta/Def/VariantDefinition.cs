namespace ClassFileGenerator.Core.Meta.Def
{
    public class VariantDefinition
    {
        public VariantDefinition(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
    }
}
