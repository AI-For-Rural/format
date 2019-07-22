﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.CodingConventions;

namespace Microsoft.CodeAnalysis.Tools.Analyzers
{
    internal class PerDocumentCodeFixApplier : ICodeFixApplier
    {
        public Task<Solution> ApplyCodeFixesAsync(Solution solution,
                                                  CodeAnalysisResult result,
                                                  ImmutableArray<CodeFixProvider> codefixes,
                                                  ImmutableArray<(Document, OptionSet, ICodingConventionsSnapshot)> formattableDocuments,
                                                  ILogger logger,
                                                  CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
