// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using Bicep.Core.Analyzers;

namespace Bicep.Core.Diagnostics
{
    public static class IDiagnosticExtensions
    {
        public static bool CanBeSuppressed(this IDiagnostic diagnostic)
        {
            return !(diagnostic.Level == DiagnosticLevel.Error && diagnostic is not AnalyzerDiagnostic);
        }
    }
}
