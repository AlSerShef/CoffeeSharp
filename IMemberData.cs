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

        string Name
        {
            get;
        }

        SeparatedSyntaxList<VariableDeclarationSyntax> Value
        {
            get;
        }



    }
}