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
        public List<string> classes = new List<String>();


        public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
        {
            node = (StructDeclarationSyntax)base.VisitStructDeclaration(node);
            Console.WriteLine(node.Members);
            string className = node.Identifier.ValueText;
            classes.Add(className); // save your visited classes

            return node;
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            string code = @"using System;

namespace HelloWorld
{
    struct Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int res = a + b;
        }
    }
 
 
struct CC
    {
     static void sum(int a, int b)
        {
            return a + b;
        }   
    }
}";
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
            var root = (CompilationUnitSyntax)tree.GetRoot();

            foreach (var usin in root.Usings)
            {
                Console.WriteLine(usin.Name);
            }


            var classVisitor = new ClassVirtualizationVisitor();
            classVisitor.Visit(root);

            var classes = classVisitor.classes; // list of classes in your solution


            foreach (var structs in classes)
            {
                Console.WriteLine(structs);
            }

            Console.ReadKey();
        }
    }
}