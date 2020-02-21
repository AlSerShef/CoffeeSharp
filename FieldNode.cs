using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class FieldNode : IMemberData

    {
       FieldDeclarationSyntax node;

       public FieldNode(FieldDeclarationSyntax node)
        {
            this.node = node;
        }
       
        public TypeSyntax TypeData
        {
            get => node.Declaration.Type;
        }

        public string Name
        {
            get => node.ToString();
        }

        public SeparatedSyntaxList<VariableDeclarationSyntax> Value
        {
            get => node.Declaration.Variables;
        }
    }
}