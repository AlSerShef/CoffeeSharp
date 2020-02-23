using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class DelegateNode : IMemberFunction

    {
        DelegateDeclarationSyntax node;

        public DelegateNode(DelegateDeclarationSyntax node)
        {
            this.node = node;
        }
        public TypeParameterListSyntax TypeParameter
        {
            get => node.TypeParameterList;
        }

        public SyntaxTokenList TypeMember
        {
            get => node.Modifiers;
        }

        public TypeSyntax ReturnTypeMember
        {
            get => node.ReturnType;
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
            get;
        }
    }
}