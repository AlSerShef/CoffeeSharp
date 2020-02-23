using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CoffeeSharp
{
    class ClassNode  : IStructData
    {
        private ClassDeclarationSyntax node;
        private List<IMemberData> kindMemberData;
        private List<IMemberFunction> kindMemberFunction;
        private List<IStructData> kindStructData;

        public ClassNode(ClassDeclarationSyntax node)
        {
            this.kindMemberData = new List<IMemberData>();
            this.kindMemberFunction = new List<IMemberFunction>();
            this.kindStructData = new List<IStructData>();
            this.node = node;
        }


        
        public List<IMemberData> KindMemberData
        {
            get => kindMemberData;
        }

        public List<IMemberFunction> KindMemberFunction
        {
            get => kindMemberFunction;
        }

        public List<IStructData> KindStructData
        {
            get => kindStructData;
        }


        public SyntaxTokenList AccessModifiers
        {
            get => node.Modifiers;
        }

        public string Name
        {
            get => node.Identifier.Text;
        }

        public BaseListSyntax BaseExtend
        {
            get => node.BaseList;
        }


  
    }
}