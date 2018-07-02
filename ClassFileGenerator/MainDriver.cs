using System;
using ClassFileGenerator.Core.Meta;
using ClassFileGenerator.Core.Templates;
using ClassFileGenerator.Core.Templates.CSharp.Class;
using ClassFileGenerator.Core.Templates.CSharp.Interface;
using ClassFileGenerator.Core.Templates.Typescript.Interface;

namespace ClassFileGenerator {
    public class MainDriver {
        public string Create(IMeta classMeta, Language language)
        {
            var template = FindTemplate(classMeta, language);
            return template.TransformText();
        }

        private ITemplate FindTemplate(IMeta meta, Language language)
        {
            switch (meta)
            {
                case ClassMeta classMeta:
                    return FindClassTemplate(classMeta, language);
                case InterfaceMeta interfaceMeta:
                    return FindInterfaceTemplate(interfaceMeta, language);
                default:
                    throw new ArgumentOutOfRangeException(meta.GetType().ToString(), meta.GetType(), null );
            }
        }

        private ITemplate FindClassTemplate(ClassMeta classMeta, Language language)
        {
            switch (language)
            {
                case Language.CSharp:
                    return new ClassTemplate(classMeta);
                default:
                    throw new ArgumentOutOfRangeException(nameof(language), language, null);
            }
        }

        private ITemplate FindInterfaceTemplate(InterfaceMeta interfaceMeta, Language language) {
            switch (language) {
                case Language.CSharp:
                    return new Core.Templates.CSharp.Interface.Template(interfaceMeta);
                case Language.Typescript:
                    return new Core.Templates.Typescript.Interface.Template(interfaceMeta);
                default:
                    throw new ArgumentOutOfRangeException(nameof(language), language, null);
            }
        }

    }
}
