using System;
using System.Collections.Generic;
using ClassFileGenerator.Core.Meta.Def;

namespace ClassFileGenerator.Core.Meta.Settings
{
    public class MethodsSetting
    {
        private readonly List<MethodDefinition> methods = new List<MethodDefinition>();

        internal MethodDefinition[] Methods => methods.ToArray();

        public MethodsSetting AddMethod(MethodDefinition method)
        {
            methods.Add(method);
            return this;
        }

        public MethodsSetting AddMethod(string name, Action<MethodDefinition> predicate = null)
        {
            var methodDefine = new MethodDefinition(name);
            AddMethod(methodDefine);
            predicate?.Invoke(methodDefine);
            return this;
        }
    }
}
