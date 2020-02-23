using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class INamespace
    {
        List<IStructData> StructData
        {
            get;
        }

        List<INamespace> ParentNamespace
        {
            get;
        }

        List<INamespace> KindNamespace
        {
            get;
        }

        string Name
        {
            get;
        }

    }
}