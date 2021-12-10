// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace Bicep.Core.Parsing
{
    public interface IPositionable
    {
        TextSpan Span { get; }
    }
}
