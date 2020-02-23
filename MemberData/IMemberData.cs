using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class IMemberData 
    {
        
        TypeSyntax TypeData
        {
            get;
        }

        SyntaxTokenList AccessModifiers
        {
            get;
        }


        
        string Value
        {
            get;
        }

        
        string Name
        {
            get;
        }

    }
}