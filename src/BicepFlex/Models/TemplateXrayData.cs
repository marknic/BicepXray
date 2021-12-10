// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace BicepFlex.Models
{
    public class TemplateXrayData
    {
        public TemplateXrayData(string bicepTemplateFile, string? outputPath)
        {
            BicepTemplateFile = bicepTemplateFile;
            OutputPath = outputPath;
        }

        public string? BicepTemplateFile { get; private set; }

        public string? OutputPath { get; private set; }

    }
}
