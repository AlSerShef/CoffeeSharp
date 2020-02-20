using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class EnumNode : INode<EnumDeclarationSyntax>

    {
        EnumDeclarationSyntax node;

        public EnumDeclarationSyntax Node
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