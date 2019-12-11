using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoffeeSharp
{



    public class ClassVirtualizationVisitor : CSharpSyntaxRewriter
    {
        private List<ClassDeclarationSyntax> classNodes;
        private List<StructDeclarationSyntax> structNodes;
        private List<InterfaceDeclarationSyntax> interfaceNodes;

        public List<ClassDeclarationSyntax> ClassNodes { get => classNodes; }
        public List<StructDeclarationSyntax> StructNodes { get => structNodes; }
        public List<InterfaceDeclarationSyntax> InterfaceNodes { get => interfaceNodes; }


        public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
        {
            node = (StructDeclarationSyntax)base.VisitStructDeclaration(node);
            structNodes.Add(node);
            return node;
        }


        public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            node = (InterfaceDeclarationSyntax)base.VisitInterfaceDeclaration(node);
            interfaceNodes.Add(node);
            return node;
        }


        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            node = (ClassDeclarationSyntax)base.VisitClassDeclaration(node);
            classNodes.Add(node);
            return node;
        }   


        //public IEnumerable<SyntaxNode> getMethodClass()
        //{
        //    return classNodes.DescendantNodes()
        //    .OfType<MethodDeclarationSyntax>().ToList();
        //}

        //public IEnumerable<SyntaxNode> getMethodStruct()
        //{
        //    return structNodes.DescendantNodes()
        //    .OfType<MethodDeclarationSyntax>().ToList();
        //}

        //public IEnumerable<SyntaxNode> getMethodInterface()
        //{
        //    return interfaceNodes.DescendantNodes()
        //    .OfType<MethodDeclarationSyntax>().ToList();
        //}


        //public IEnumerable<SyntaxNode> getFieldClass()
        //{
        //    return classNodes.DescendantNodes()
        //    .OfType<FieldDeclarationSyntax>().ToList();
        //}

        //public IEnumerable<SyntaxNode> getFieldStruct()
        //{
        //    return structNodes.DescendantNodes()
        //    .OfType<FieldDeclarationSyntax>().ToList();
        //}

        //public IEnumerable<SyntaxNode> getFieldInterface()
        //{
        //    return interfaceNodes.DescendantNodes()
        //    .OfType<FieldDeclarationSyntax>().ToList();
        //}

        //public IEnumerable<SyntaxNode> getPropertyClass()
        //{
        //    return classNodes.DescendantNodes()
        //    .OfType<PropertyDeclarationSyntax>().ToList();
        //}

        //public IEnumerable<SyntaxNode> getPropertyStruct()
        //{
        //    return structNodes.DescendantNodes()
        //    .OfType<PropertyDeclarationSyntax>().ToList();
        //}

        //public IEnumerable<SyntaxNode> getPropertyInterface()
        //{
        //    return interfaceNodes.DescendantNodes()
        //    .OfType<PropertyDeclarationSyntax>().ToList();
        //}

    }





    class Program
    {
        static void Main(string[] args) 
        {
            string code = @"using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }

struct Str
    {
        
    }
}";
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
            var root = (CompilationUnitSyntax)tree.GetRoot();

            //foreach (var usin in root.Usings)
            //{
            //    Console.WriteLine(usin);
            //}

            var visitor = new ClassVirtualizationVisitor();
            visitor.Visit(root);



            Console.ReadKey();
        }
    }
}
