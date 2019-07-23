﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.Extensions.Logging;

namespace Microsoft.CodeAnalysis.Tools.Analyzers
{
    internal class PerDocumentCodeFixApplier : ICodeFixApplier
    {
        public Task<Solution> ApplyCodeFixesAsync(Solution solution,
                                                  CodeAnalysisResult result,
                                                  CodeFixProvider codefixes,
                                                  ILogger logger,
                                                  CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
