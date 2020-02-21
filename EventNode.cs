using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class EventNode : IMemberData

    {
        private EventDeclarationSyntax node;

        public EventNode(EventDeclarationSyntax node)
        {
            this.node = node;
        }
       
        public TypeSyntax TypeData
        {
            get => node.Type;
        }

        public string Name
        {
            get => node.Identifier.Text;
        }

        public SeparatedSyntaxList<VariableDeclarationSyntax> Value
        {
            get;
        }

    }
}