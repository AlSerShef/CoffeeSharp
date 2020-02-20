using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class ConstructorNode : INode<ConstructorDeclarationSyntax>

    {
        ConstructorDeclarationSyntax node;

        public ConstructorDeclarationSyntax Node
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