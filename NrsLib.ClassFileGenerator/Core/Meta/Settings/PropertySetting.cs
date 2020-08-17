using System;
using System.Collections.Generic;
using NrsLib.ClassFileGenerator.Core.Meta.Def;

namespace NrsLib.ClassFileGenerator.Core.Meta.Settings
{
    public class PropertySetting
    {
        private readonly List<PropertyDefinition> properties = new List<PropertyDefinition>();

        internal PropertyDefinition[] Properties => properties.ToArray();

        public PropertySetting AddProperty(string name, Action<PropertyDefinition> predicate = null)
        {
            var property = new PropertyDefinition(name);
            predicate?.Invoke(property);
            properties.Add(property);
            return this;
        }
    }
}
