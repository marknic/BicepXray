// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;

namespace Bicep.Core.Parsing
{
    [Flags]
    public enum ExpressionFlags
    {
        None = 0,
        AllowComplexLiterals = 1,
        AllowResourceDeclarations = 2,
    }
}
