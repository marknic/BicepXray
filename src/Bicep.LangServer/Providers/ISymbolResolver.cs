// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

namespace Bicep.LanguageServer.Providers
{
    public interface ISymbolResolver
    {
        SymbolResolutionResult? ResolveSymbol(DocumentUri uri, Position position);
    }
}

