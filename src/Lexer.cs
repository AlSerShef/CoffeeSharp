using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CoffeeSharp
{
    class Lexer
    {
        ClassVirtualizationVisitor visitor;

        public Lexer(string code)
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
            var root = (CompilationUnitSyntax)tree.GetRoot();
            visitor = new ClassVirtualizationVisitor();
            visitor.Visit(root);
        }

        public IEnumerable<SyntaxNode> getMethodClass()
        {
            return visitor.ClassNodes.DescendantNodes()
            .OfType<MethodDeclarationSyntax>().ToList();
        }

    }
}
