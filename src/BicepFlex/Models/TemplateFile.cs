// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;

namespace BicepFlex.Models
{
    public class TemplateFile
    {
        public TemplateFile(string? bicepTemplateFile, string? outputFile)
        {
            BicepTemplateFile = bicepTemplateFile ?? throw new ArgumentNullException(nameof(bicepTemplateFile));

            OutputFile = outputFile;
        }

        public string BicepTemplateFile { get; private set; }
        public string? OutputFile { get; private set; }
    }
}
