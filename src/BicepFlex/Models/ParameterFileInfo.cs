// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;
using System.CodeDom;
using System.IO;

namespace BicepFlex.Models
{
    public class ParameterFileInfo
    {
        public ParameterFileInfo(string? bicepTemplateFile, string? mainParameterFile, string? outputParameterFile = "", string? exceptions = "", bool force = false)
        {
            BicepTemplateFile = bicepTemplateFile ?? throw new ArgumentNullException(nameof(bicepTemplateFile));

            MainParameterFile = mainParameterFile ?? throw new ArgumentNullException(nameof(mainParameterFile));

            BicepTemplateFile = Path.GetFullPath(BicepTemplateFile);

            MainParameterFile = Path.GetFullPath(MainParameterFile);

            if (string.IsNullOrEmpty(outputParameterFile))
            {
                var templateFileName = Path.GetFileNameWithoutExtension(bicepTemplateFile);

                if (templateFileName == null)
                {
                    throw new ArgumentNullException(nameof(bicepTemplateFile));
                }

                outputParameterFile = $"params.{templateFileName}.json";
            } else
            {
                if (Directory.Exists(outputParameterFile))
                {
                    throw new ArgumentException($"{nameof(outputParameterFile)} must be a file name not a folder.");
                }
            }

            OutputParameterFile = Path.GetFullPath(outputParameterFile);

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
