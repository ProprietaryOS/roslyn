﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.LanguageServer.Handler.Diagnostics;

[Export(typeof(IDiagnosticSourceProvider)), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class DocumentTaskDiagnosticSourceProvider([Import] IGlobalOptionService globalOptions)
    : AbstractDocumentDiagnosticSourceProvider(PullDiagnosticCategories.Task)
{
    public override ValueTask<ImmutableArray<IDiagnosticSource>> CreateDiagnosticSourcesAsync(RequestContext context, CancellationToken cancellationToken)
    {
        if (context.TextDocument is not Document document)
        {
            context.TraceInformation("Ignoring task list diagnostics request because no document was provided");
            return new([]);
        }

        var source = new TaskListDiagnosticSource(document, globalOptions);
        return new([source]);
    }
}

