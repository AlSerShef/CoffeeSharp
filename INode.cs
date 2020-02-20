using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    interface INode<T>

    {
        T Node
        {
            get;
            set;
        }

        SyntaxNode Parent
        {
            get;
        }
         SyntaxKind Kind
        {
            get;
        }

    }
}