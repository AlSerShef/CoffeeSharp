using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.IO;
using Newtonsoft.Json;
namespace CoffeeSharp
{



    
    class Program
    {
        static void Main(string[] args) 
        {

            string code = @"
            using System;

namespace HelloWorld
{


public abstract class ClassNode
{
    private int[]   mass = new int[2]{1,2};

    private int fieldPrivate = 10;

    public const string fieldPublic;

    public int FieldPrivate
    {
        get => fieldPrivate;
        set =>  fieldPrivate = value;
    }

    public ClassNode(int fieldPrivate, fieldPublic)
    {
        this.fieldPrivate = fieldPrivate;
        thi.fieldPublic = fieldPublic;
    }

    public int this[int index]
    {
        get => mass[index];
        set => mass[index]  = value;
    }

    public void SetNameFieldPub(string fieldPublic)
    {
        this.fieldPublic = fieldPublic;
    }

}
}";
        

            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
            var root = (CompilationUnitSyntax)tree.GetCompilationUnitRoot();

            var walk = new WalkerCode();
            walk.Visit(root);

            // foreach(var usingNode in root.Usings)
            // {
            //     Console.WriteLine($"using: {usingNode}");
            // }

            walk.ShowField();

            Console.ReadKey();

           
        }
    }
}
