using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class IStructData 
    {
        SyntaxTokenList AccessModifiers
        {
            get;
        }

        string Name
        {
            get;
        }
    }
}