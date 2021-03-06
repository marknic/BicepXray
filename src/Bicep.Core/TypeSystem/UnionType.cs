// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Bicep.Core.Extensions;

namespace Bicep.Core.TypeSystem
{
    public class UnionType : TypeSymbol
    {
        public UnionType(string name, ImmutableArray<ITypeReference> members)
            : base(name)
        {
            this.Members = members;
        }

        public override TypeKind TypeKind => this.Members.Any() ? TypeKind.Union : TypeKind.Never;

        public ImmutableArray<ITypeReference> Members { get; }

        public override string FormatNameForCompoundTypes() => this.WrapTypeName();
    }
}

