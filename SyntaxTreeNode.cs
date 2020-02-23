using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class SyntaxTreeNode
    {
        private List<INamespace> @namespaces;
        // private List<IStructData> structsData;
        // private List<IMemberData> membersData;
        // private List<IMemberFunction> functionsData;

        public SyntaxTreeNode(List<INamespace> @namespaces)
        {
            this.@namespaces = @namespaces;
        }

        public List<INamespace> @Namespaces
        {
            get => @namespaces;
        }
    } 
}