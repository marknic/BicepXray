// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace Bicep.Core.Diagnostics
{
    public interface IDiagnosticWriter
    {
        void Write(IDiagnostic diagnostic);
    }
}
