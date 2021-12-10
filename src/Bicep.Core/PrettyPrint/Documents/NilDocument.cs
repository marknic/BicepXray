// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System.Text;

namespace Bicep.Core.PrettyPrint.Documents
{
    public sealed class NilDocument : ILinkedDocument
    {
        public ILinkedDocument Concat(ILinkedDocument other)
        {
            return other;
        }

        public ILinkedDocument Nest()
        {
            return this;
        }

        public void Layout(StringBuilder builder, string indent, string newline)
        {
            // Do nothing.
        }
    }
}
