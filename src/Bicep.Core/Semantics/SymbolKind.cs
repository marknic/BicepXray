// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace Bicep.Core.Semantics
{
    public enum SymbolKind
    {
        Error,
        Type,
        File,
        Parameter,
        Variable,
        Resource,
        Module,
        Output,
        Namespace,
        ImportedNamespace,
        Function,
        Local,
        Scope,
        Property,
    }
}
