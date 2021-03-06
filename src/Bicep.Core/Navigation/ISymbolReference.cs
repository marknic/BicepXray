// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using Bicep.Core.Syntax;

namespace Bicep.Core.Navigation
{
    /// <summary>
    /// Represents a syntax node that references a symbol.
    /// </summary>
    public interface ISymbolReference
    {
        IdentifierSyntax Name { get; }
    }
}

