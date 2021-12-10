// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace Bicep.Core.Registry.Oci
{
    public class ModuleMetadata
    {
        public ModuleMetadata(string manifestDigest)
        {
            this.ManifestDigest = manifestDigest;
        }

        public string ManifestDigest { get; }
    }
}
