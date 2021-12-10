// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System.Collections.Generic;

namespace Bicep.Core.Semantics
{
    public interface ILanguageScope
    {
        IEnumerable<DeclaredSymbol> GetDeclarationsByName(string name);

        IEnumerable<DeclaredSymbol> Declarations { get; }
    }
}