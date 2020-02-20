using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace CoffeeSharp
{
    class WalkerCode : CSharpSyntaxWalker
    {
        readonly private List<CSharpSyntaxNode> nodeCode;

        public List<CSharpSyntaxNode> NodeCode { get => nodeCode;}
        
        
        public WalkerCode() : base(SyntaxWalkerDepth.StructuredTrivia){
            nodeCode = new List<CSharpSyntaxNode>();
        }
        public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitNamespaceDeclaration(node);
        }

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
           
            nodeCode.Add(node);
            base.VisitClassDeclaration(node);
        }
        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitStructDeclaration(node);
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitDelegateDeclaration(node);
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitInterfaceDeclaration(node);
        }
        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitEnumDeclaration(node);
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitMethodDeclaration(node);
        }

         public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitPropertyDeclaration(node);
        }


        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitFieldDeclaration(node);
        }

        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitConstructorDeclaration(node);
        }

        public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
        {
            nodeCode.Add(node);
            base.VisitIndexerDeclaration(node);
        }

    }
}