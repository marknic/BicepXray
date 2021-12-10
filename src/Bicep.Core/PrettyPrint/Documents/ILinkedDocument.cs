// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System.Text;

namespace Bicep.Core.PrettyPrint.Documents
{
    public interface ILinkedDocument
    {
        ILinkedDocument Concat(ILinkedDocument other);

        ILinkedDocument Nest();

        void Layout(StringBuilder sb, string indent, string newline);
    }
}
