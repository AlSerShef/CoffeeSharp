using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace CoffeeSharp
{
    class WalkerCode : CSharpSyntaxWalker
    {
        private  List<INamespace> @namespaces;

        readonly private List<NamespaceDeclarationSyntax> namespaceNode;
        readonly private List<ClassDeclarationSyntax> classNode;

        readonly private List<StructDeclarationSyntax> structNode;
        readonly private List<DelegateDeclarationSyntax> delegateNode;

        readonly private List<InterfaceDeclarationSyntax> interfaceNode;

        readonly private List<EnumDeclarationSyntax> enumNode;

        readonly private List<MethodDeclarationSyntax> methodNode;

        readonly private List<PropertyDeclarationSyntax> propertyNode;

        readonly private List<FieldDeclarationSyntax> fieldNode;

        readonly private List<ConstructorDeclarationSyntax> constructorNode;

        readonly private List<IndexerDeclarationSyntax> indexerNode;
   
        
        public WalkerCode() : base(SyntaxWalkerDepth.StructuredTrivia){
            this.namespaceNode = new List<NamespaceDeclarationSyntax>();
            this.classNode = new List<ClassDeclarationSyntax>();
            this.structNode = new List<StructDeclarationSyntax>();
            this.delegateNode = new List<DelegateDeclarationSyntax>();
            this.interfaceNode = new List<InterfaceDeclarationSyntax>();
            this.enumNode = new List<EnumDeclarationSyntax>();
            this.fieldNode = new List<FieldDeclarationSyntax>();
            this.methodNode = new List<MethodDeclarationSyntax>();
            this.propertyNode = new List<PropertyDeclarationSyntax>();
            this.constructorNode = new List<ConstructorDeclarationSyntax>();
            this.indexerNode = new List<IndexerDeclarationSyntax>();
        }
        public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            namespaceNode.Add(node);
            base.VisitNamespaceDeclaration(node);
        }

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
           
            classNode.Add(node);
            base.VisitClassDeclaration(node);
        }
        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            structNode.Add(node);
            base.VisitStructDeclaration(node);
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            delegateNode.Add(node);
            base.VisitDelegateDeclaration(node);
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            interfaceNode.Add(node);
            base.VisitInterfaceDeclaration(node);
        }
        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            enumNode.Add(node);
            base.VisitEnumDeclaration(node);
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            methodNode.Add(node);
            base.VisitMethodDeclaration(node);
        }

         public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            propertyNode.Add(node);
            base.VisitPropertyDeclaration(node);
        }


        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            fieldNode.Add(node);
            base.VisitFieldDeclaration(node);
        }

        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            constructorNode.Add(node);
            base.VisitConstructorDeclaration(node);
        }

        public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
        {
            indexerNode.Add(node);
            base.VisitIndexerDeclaration(node);
        }

        // public void ShowUsings()
        // {
        //     foreach(var usings in this.Usin)
        //     {

        //     }
        // }

        public void ShowNamespace()
        {
            foreach(var @namespace in namespaceNode)
            {
                Console.WriteLine($"namespace: {@namespace.Name}");
            }
        }

        public void ShowClass()
        {
            foreach(var @class in classNode)
            {
                Console.WriteLine("class: {");
                Console.WriteLine($"\tname: {@class.Identifier.Text}");
                Console.WriteLine($"\t accessModifys: {@class.Modifiers}");
                Console.WriteLine($"\t accessModifys: {@class.BaseList}");
                Console.WriteLine("}");
            }
        }


        public void ShowField()
        {
            foreach(var field in fieldNode)
            {
                
                Console.WriteLine("field: {");
                Console.WriteLine($"\t name: {field.Declaration.Variables.First().Identifier}");
                Console.WriteLine($"\t val: {field.Declaration.Variables.First().Initializer?.Value}");
                Console.WriteLine($"\t accessModifys: {field.Modifiers}");
                Console.WriteLine($"\t type: {field.Declaration.Type}");
                Console.WriteLine("}");
            }
        }
    }
}