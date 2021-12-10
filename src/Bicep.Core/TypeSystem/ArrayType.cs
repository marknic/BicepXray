// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace Bicep.Core.TypeSystem
{
    public class ArrayType : TypeSymbol
    {
        public ArrayType(string name) : base(name)
        {
            Item = LanguageConstants.Any;
        }

        public override TypeKind TypeKind => TypeKind.Primitive;

        public virtual ITypeReference Item { get; }
    }
}
