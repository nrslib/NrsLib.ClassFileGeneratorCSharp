using System;
using System.Collections.Generic;
using NrsLib.ClassFileGenerator.Core.Meta.Words;

namespace NrsLib.ClassFileGenerator.Core.Meta.Def
{
    public class PropertyDefinition
    {

        public PropertyDefinition(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public AccessLevel MaxAccessLevel => GetterAccessLevel > SetterAccessLevel ? SetterAccessLevel : GetterAccessLevel;
        public AccessLevel GetterAccessLevel { get; private set; } = AccessLevel.Public;
        public AccessLevel SetterAccessLevel { get; private set; } = AccessLevel.Private;
        public bool HasSetter { get; private set; }
        public string Type { get; private set; } = "object";
        public List<AttributeDefinition> Attributes { get; } = new List<AttributeDefinition>();

        public PropertyDefinition AddAttribute(string attributeTypeName, Action<AttributeDefinition> predicate = null)
        {
            var attribute = new AttributeDefinition(attributeTypeName);
            predicate?.Invoke(attribute);
            Attributes.Add(attribute);
            return this;
        }

        public PropertyDefinition AddSetter(AccessLevel accessLevel = AccessLevel.Private)
        {
            HasSetter = true;
            SetterAccessLevel = accessLevel;
            return this;
        }

        public PropertyDefinition SetType(string typeName)
        {
            Type = typeName;
            return this;
        }

        public PropertyDefinition ChangeAccessLevel(AccessLevel getAccessLevel, AccessLevel? setAccessLevel = null)
        {
            GetterAccessLevel = getAccessLevel;
            SetterAccessLevel = setAccessLevel ?? SetterAccessLevel;
            return this;
        }
    }
}
