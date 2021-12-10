// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using Azure.Deployments.Core.Instrumentation;

namespace Bicep.Core.Emit
{
    public static class BicepDeploymentsInterop
    {
        public static void Initialize() => DeploymentsInterop.Initialize();
    }
}