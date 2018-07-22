using System;
using System.Collections.Generic;
using NrsLib.ClassFileGenerator.Core.Meta.Def;

namespace NrsLib.ClassFileGenerator.Core.Meta.Settings {
    public class ConstructorSetting {
        private readonly List<ConstructorDefinition> constructors = new List<ConstructorDefinition>();

        internal ConstructorDefinition[] Constructors => constructors.ToArray();

        public ConstructorSetting AddConstructor(Action<ConstructorDefinition> predicate)
        {
            var constructor = new ConstructorDefinition();
            constructors.Add(constructor);
            predicate(constructor);
            return this;
        }
    }
}
