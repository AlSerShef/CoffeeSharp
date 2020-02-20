using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class InterfaceNode : IStructData, INode<InterfaceDeclarationSyntax>

    {
        InterfaceDeclarationSyntax node;

        public InterfaceDeclarationSyntax Node
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

        public SyntaxTokenList AccessModifiers
        {
            get => node.Modifiers;
        }

        public string Name
        {
            get => node.Identifier.Text;
        }

    }
}