using System;

namespace NrsLib.ClassFileGenerator.Core.Meta.Words
{
    public enum AccessLevel
    {
        Public,
        Protected,
        Private
    }

    static class AccessLevelEx
    {
        internal static string ToText(this AccessLevel level)
        {
            switch (level)
            {
                case AccessLevel.Public: return "public";
                case AccessLevel.Protected: return "protected";
                case AccessLevel.Private: return "private";
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }
    }
}
