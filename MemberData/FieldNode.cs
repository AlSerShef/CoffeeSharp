using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class FieldNode : IMemberData
    {
       private FieldDeclarationSyntax node;

       public FieldNode(FieldDeclarationSyntax node)
        {
            this.node = node;
            
        }
       
        public TypeSyntax TypeData
        {
            get => node.Declaration.Type;
        }


        public SyntaxTokenList AccessModifiers
        {
            get => node.Modifiers;
        }


        public string Value
        {
            get => node.Declaration.Variables.First().Initializer?.Value.ToString();
        }

        
        public string Name
        {
            get => node.Declaration.Variables.First().Identifier.ToString();
        }
    }
}