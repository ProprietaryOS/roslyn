﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class StackAllocArrayCreationExpressionSyntax
    {
        public StackAllocArrayCreationExpressionSyntax Update(SyntaxToken stackAllocKeyword, TypeSyntax type)
            => Update(stackAllocKeyword, type, Initializer);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static StackAllocArrayCreationExpressionSyntax StackAllocArrayCreationExpression(SyntaxToken stackAllocKeyword, TypeSyntax type)
            => StackAllocArrayCreationExpression(stackAllocKeyword, type, initializer: null);
    }
}
