// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using Bicep.Core.Syntax;

namespace Bicep.Core.Semantics.Metadata
{
    public record ResourceMetadataParent(
        ResourceMetadata Metadata,
        SyntaxBase? IndexExpression,
        bool IsNested);
}