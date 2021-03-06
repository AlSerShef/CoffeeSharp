using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class IMemberFunction
    {

        SyntaxTokenList AccessModifiers
        {
            get;
        }

        TypeSyntax ReturnTypeMember
        {
            get;
        }
        
        string Name
        {
            get;
        }

        SeparatedSyntaxList<ParameterSyntax> Parameter
        {
            get;
        }

        BlockSyntax BodyMember
        {
            get;
        }



    }
}