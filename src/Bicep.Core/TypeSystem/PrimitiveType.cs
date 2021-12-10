// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace Bicep.Core.TypeSystem
{
    /// <summary>
    /// Represents a built-in primitive type.
    /// </summary>
    public class PrimitiveType : TypeSymbol
    {
        public PrimitiveType(string name, TypeSymbolValidationFlags validationFlags) : base(name)
        {
            ValidationFlags = validationFlags;
        }

        public override TypeKind TypeKind => TypeKind.Primitive;

        public override TypeSymbolValidationFlags ValidationFlags { get; }
    }
}
