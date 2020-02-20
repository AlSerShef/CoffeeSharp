using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class NamespaceNode : INode<NamespaceDeclarationSyntax>

    {
        NamespaceDeclarationSyntax node;

        public NamespaceDeclarationSyntax Node
        {
            get => node;
            set => node = value;
        }

   

        public SyntaxNode Parent
        {
            get => node.Parent;
        }
        public SyntaxKind Kind
        {
            get => node.Kind();
        }
    }
}