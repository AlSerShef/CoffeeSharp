using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class PropertyNode : IMemberData

    {
        PropertyDeclarationSyntax node;

        public PropertyNode(PropertyDeclarationSyntax node)
        {
            this.node = node;
        }


        public SyntaxTokenList TypeMember
        {
            get => node.Modifiers;
        }

        public TypeSyntax ReturnTypeMember
        {
            get;
        }
        
        public string Name
        {
            get => node.Identifier.Text;
        }

        public SeparatedSyntaxList<ParameterSyntax> Parameter
        {
            get;
        }

        public BlockSyntax BodyMember
        {
            get;
        }
    }
}