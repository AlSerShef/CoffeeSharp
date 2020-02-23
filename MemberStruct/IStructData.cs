using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class IStructData 
    {
        
        List<IMemberData> KindMemberData
        {
            get;
        }

        List<IMemberFunction> KindMemberFunction
        {
            get;
        }

        List<IStructData> KindStructData
        {
            get;
        }


        BaseListSyntax BaseExtend
        {
            get;
        }

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