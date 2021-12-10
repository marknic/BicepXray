// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System.Collections.Generic;
using Bicep.Core.Semantics;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

namespace Bicep.LanguageServer.Completions
{
    public interface ICompletionProvider
    {
        IEnumerable<CompletionItem> GetFilteredCompletions(Compilation model, BicepCompletionContext context);
    }
}
