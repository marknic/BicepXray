// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;

namespace BicepFlex.Models
{
    public class ParameterFileInfo
    {
        public ParameterFileInfo(string? bicepTemplateFile, string? mainParameterFile, string? outputParameterFile = "", string? exceptions = "", bool force = false)
        {
            BicepTemplateFile = bicepTemplateFile ?? throw new ArgumentNullException(nameof(bicepTemplateFile));

            MainParameterFile = mainParameterFile ?? throw new ArgumentNullException(nameof(mainParameterFile));

            OutputParameterFile = outputParameterFile;

            Exceptions = exceptions;

            Force = force;
        }

        public string BicepTemplateFile { get; private set; }
        public string MainParameterFile { get; private set; }
        public string? OutputParameterFile { get; private set; }
        public string? Exceptions { get; private set; }
        public bool Force { get; private set; }
    }
}
