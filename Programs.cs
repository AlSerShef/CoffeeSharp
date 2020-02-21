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

public interface INullInterface{}

public class ClassNode : INullInterface
{
    private int[]   mass = new int[2]{1,2};

    private int fieldPrivate;

    public string fieldPublic;

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

public delegate DelgateNode();

public interface InterfaceNode
{ 
    void AbsMethodOne();

    int AbsMethodTwo();

    delegate void DelegateAbs();

    int Number{get; set;}

    const int Value = 10;

    static double radius = 15.326;

    event DelegateAbs EventAbs();
}

public enum EnumNode{ONE, TWO}

public struct StructNode
{
    public string NameNode;
    public int NumberNode;
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

            string json = JsonConvert.SerializeObject(tree);     
             using (StreamWriter sw = new StreamWriter(@"C:\Users\doty6\OneDrive\Документы\Project\CoffeeSharp\tree.json"))
                {
                    sw.WriteLine(json);
                }
           
            foreach(var elementNode in walk.NodeCode)
            {
                // if(elementNode is NamespaceDeclarationSyntax)
                // {
                //      var temp = (NamespaceDeclarationSyntax)elementNode;
                //      Console.WriteLine($"namespace\t{((IdentifierNameSyntax)temp.Name).Identifier.Text}");
                // }

                //  if(elementNode is ClassDeclarationSyntax)
                // {
                     
                //      var temp = (ClassDeclarationSyntax)elementNode;
                //      Console.WriteLine($"{temp.BaseList}");
                // }
            //     if(elementNode is StructDeclarationSyntax)
            //     {
            //          var temp = (StructDeclarationSyntax)elementNode;
            //          Console.WriteLine($"struct\t{temp.Identifier.Text}");
            //     }
            //     if(elementNode is DelegateDeclarationSyntax)
            //     {
            //         var temp = (DelegateDeclarationSyntax)elementNode;
            //          Console.WriteLine($"delegate\t{temp.Identifier.Text}");
            //     }

            //     if(elementNode is InterfaceDeclarationSyntax)
            //     {
            //         var temp = (InterfaceDeclarationSyntax)elementNode;
            //          Console.WriteLine($"interface\t{temp.Identifier.Text}");
            //     }
            //      if(elementNode is EnumDeclarationSyntax)
            //     {
            //          var temp = (EnumDeclarationSyntax)elementNode;
            //          Console.WriteLine($"enum\t{temp.Identifier.Text}");
            //     }

            //      if(elementNode is MethodDeclarationSyntax)
            //     {
            //          var temp = (MethodDeclarationSyntax)elementNode;
            //          Console.WriteLine($"method\t{temp.Identifier.Text}");
            //     }
              
            //    if(elementNode is PropertyDeclarationSyntax)
            //     {
            //          var temp = (PropertyDeclarationSyntax)elementNode;
            //          Console.WriteLine($"property\t{temp.Identifier.Text}");
            //     }

                if(elementNode is FieldDeclarationSyntax)
                {
                     var temp = (FieldDeclarationSyntax)elementNode;
                     
                     Console.WriteLine($"field\t{temp.Declaration.Type} {temp.Declaration.Variables}");
                     
                    
                }

            //     if(elementNode is ConstructorDeclarationSyntax)
            //     {
            //          var temp = (ConstructorDeclarationSyntax)elementNode;
            //          Console.WriteLine($"constructor\t{temp.Identifier.Text}");
            //     }

            //     if(elementNode is IndexerDeclarationSyntax)
            //     {
            //          var temp = (IndexerDeclarationSyntax)elementNode;
            //          Console.WriteLine($"indexer \t{temp.Type}");
            //     }

            }

            Console.ReadKey();

           
        }
    }
}
