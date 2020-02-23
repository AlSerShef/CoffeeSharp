using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class ConstructorNode : IMemberFunction

    {

        private ConstructorDeclarationSyntax node;

        public ConstructorNode(ConstructorDeclarationSyntax node)
        {
            this.node = node;
        }

        public TypeParameterListSyntax TypeParameter
        {
            get;
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
            get => node.ParameterList.Parameters;
        }

        public BlockSyntax BodyMember
        {
            get => node.Body;
        }
    }
}