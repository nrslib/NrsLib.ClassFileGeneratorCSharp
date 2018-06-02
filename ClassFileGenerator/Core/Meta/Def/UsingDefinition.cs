namespace ClassFileGenerator.Core.Meta.Def
{
    public class UsingDefinition
    {
        private readonly string nameSpace;

        public UsingDefinition(string nameSpace)
        {
            this.nameSpace = nameSpace;
        }

        public string ToText() => "using " + nameSpace;
    }
}
