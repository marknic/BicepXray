// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;
using Bicep.Core.Configuration;

namespace Bicep.Core.Registry
{
    public interface ITemplateSpecRepositoryFactory
    {
        ITemplateSpecRepository CreateRepository(RootConfiguration configuration, string subscriptionId);
    }
}
