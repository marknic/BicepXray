// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System.Text.RegularExpressions;

namespace Bicep.Core.TypeSystem.Az
{
    public static class AzConstants
    {
        public static readonly Regex ListWildcardFunctionRegex = new Regex("^list[a-zA-Z]*$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
    }
}