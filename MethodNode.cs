using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class MethodNode : INode<MethodDeclarationSyntax>

    {
        MethodDeclarationSyntax node;

        public MethodDeclarationSyntax Node
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