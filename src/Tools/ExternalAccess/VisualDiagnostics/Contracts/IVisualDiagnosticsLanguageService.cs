﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Host;
using Microsoft.VisualStudio.Debugger.Contracts.HotReload;

namespace Microsoft.CodeAnalysis.ExternalAccess.VisualDiagnostics.Contracts
{
    public interface IVisualDiagnosticsLanguageService : IWorkspaceService
    {
        public Task InitializeAsync();
        public Task CreateDiagnosticsSessionAsync(Guid processId);
        public Task StopDiagnosticsSessionAsync(Guid processId);
    }
}
