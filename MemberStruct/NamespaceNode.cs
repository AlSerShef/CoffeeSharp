using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class NamespaceNode : INamespace
    {
        private NamespaceDeclarationSyntax node;

        private List<INamespace> parentNamespace;
        private List<INamespace> kindNamespace;
        private List<IStructData> kneeStructData;

        public NamespaceNode(NamespaceDeclarationSyntax node)
        {
            this.parentNamespace = new List<INamespace>();
            this.kindNamespace = new List<INamespace>();
            this.kneeStructData = new List<IStructData>();
            this.node = node;
        }

        public List<IStructData> StructData
        {
            get => kneeStructData;
        }

        public List<INamespace> ParentNamespace
        {
            get => parentNamespace;
        }

        public List<INamespace> KindNamespace
        {
            get => kindNamespace;
        }

        public string Name
        {
            get
            {
                return ((IdentifierNameSyntax)node.Name).Identifier.Text;
            }
        }

    }
}