using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class IndexerNode : IMemberFunction

    {
        IndexerDeclarationSyntax node;

        public IndexerNode(IndexerDeclarationSyntax node)
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
            get;
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