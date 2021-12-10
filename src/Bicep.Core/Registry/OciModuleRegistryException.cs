// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;

namespace Bicep.Core.Registry
{
    public class OciModuleRegistryException : ExternalModuleException
    {
        public OciModuleRegistryException(string message) : base(message)
        {
        }

        public OciModuleRegistryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
