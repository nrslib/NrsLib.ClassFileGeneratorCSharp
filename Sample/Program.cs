using System;
using ClassFileGenerator;
using ClassFileGenerator.Core.Meta;
using ClassFileGenerator.Core.Meta.Def;
using ClassFileGenerator.Core.Meta.Words;
using ClassFileGenerator.Core.Templates;

namespace Sample {
    class Program {
        static void Main(string[] args)
        {
            var classMeta = new ClassMeta("TestNameSpace.Test", "TestClass");

            // setup using
            classMeta.SetupUsing()
                .AddUsing("System")
                .AddUsing("System.Linq");

            // setup implements
            classMeta.SetupImplements()
                .AddImplements("ISuperClass")
                .AddImplements("ISuperClassWithGeneric", implement => implement.AddGeneric("string"));

            // setup field
            classMeta.SetupFields()
                .AddField("testField", field => field.SetType("int").SetValue("1"));

            // setup simple public method
            classMeta.SetupMethods()
                .AddMethod("TestPublicMethod", method => method.AddArgument("test", "string").SetAccessLevel(AccessLevel.Public));

            // setup no body method
            classMeta.SetupMethods()
                .AddMethod("NoBodyMethod", method => method.NoBodyOnNoLine(true));

            // setup complex method
            classMeta.SetupMethods()
                .AddMethod("ComplexMethod", method =>
                    method.SetReturnType("int")
                        .AddBody("int i = 0;", "i++;", "return i;")
                        .AddGenerics("T", generics => generics.AddWhere("class").AddWhere("new()"))
                        .AddGenerics("TT", generics => generics.AddWhere("class"))
                        .AddArgument("t", "T")
                );

            // if you don't want to use lambda
            var tmpMethod = new MethodDefinition("TempMethod");
            tmpMethod
                .AddBody("Console.WriteLine(\"Hello world\");")
                .SetAccessLevel(AccessLevel.Public)
                .AddArgument("args", "string[]");
            classMeta.SetupMethods()
                .AddMethod(tmpMethod);
            
            var interfaceMeta = new InterfaceMeta("TestNameSpace.Test", "TestInterface");

            interfaceMeta.SetupUsing()
                .AddUsing("System.Linq");

            interfaceMeta.SetupImplements()
                .AddImplements("SuperClass", x => x.AddGeneric("string"));

            interfaceMeta.SetupMethod()
                .AddMethod("TestMethod", x => x.AddArgument("test", "string"))
                .AddMethod("Test2Method")
                .AddMethod("TestGenericsMethod", method =>
                    method.AddGenerics("TKey", generics => generics.AddWhere("class").AddWhere("new()"))
                    .AddGenerics("TVal", generics => generics.AddWhere("struct"))
                );

            // create
            var driver = new MainDriver();
            var classText = driver.Create(classMeta, Language.CSharp);
            var interfaceText = driver.Create(interfaceMeta, Language.CSharp);

            Console.WriteLine("---- class -----");
            Console.WriteLine(classText);
            Console.WriteLine("---- interface -----");
            Console.WriteLine(interfaceText);
            Console.WriteLine("push any key to end");
            Console.ReadKey();
        }
    }
}
