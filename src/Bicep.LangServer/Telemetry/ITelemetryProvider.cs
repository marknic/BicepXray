// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace Bicep.LanguageServer.Telemetry
{
    public interface ITelemetryProvider
    {
        void PostEvent(BicepTelemetryEvent telemetryEvent);
    }
}
