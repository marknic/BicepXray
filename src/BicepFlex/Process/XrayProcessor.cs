// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using BicepFlex.Models;
using BicepPrep.Transform;
using System;
using System.IO;
using System.Linq;

namespace BicepFlex.Process
{
    public static class XrayProcessor
    {
        //private static string _workingFolder = string.Empty;


        public static void DoXray(TemplateFile templateFile)
        {
            var filePath = templateFile.BicepTemplateFile;

            if (string.IsNullOrEmpty(filePath))
            {
                filePath = ".";
            }

            var outputFolder = templateFile.OutputFile;

            if (string.IsNullOrEmpty(outputFolder))
            {
                outputFolder = ".";
            }

            outputFolder = Path.GetFullPath(outputFolder);

            var fullPath = Path.GetFullPath(filePath);

            var isDirectoryOnly = Directory.Exists(fullPath);

            if (string.IsNullOrWhiteSpace(fullPath))
            {
                throw new ArgumentException($"Could not derive a folder path from \'{filePath}\'");
            }

            if (isDirectoryOnly)
            {
                var filelist = Directory.EnumerateFiles(fullPath).Where(f => f.EndsWith(".bicep"));

                foreach (var file in filelist)
                {
                    var diagramName = Path.GetFileNameWithoutExtension(file);

                    var template = BicepDecoder.DecodeTemplate(file);

                    PlantUml.CreateDiagram(template, fullPath, diagramName, outputFolder);
                }
            }
            else
            {
                var folder = Path.GetDirectoryName(fullPath);

                if (fullPath != null && File.Exists(fullPath))
                {
                    //#pragma warning disable CS8601 // Possible null reference assignment.
                    //                    _workingFolder = Path.GetDirectoryName(fullPath);
                    //#pragma warning restore CS8601 // Possible null reference assignment.

                    var diagramName = Path.GetFileNameWithoutExtension(fullPath);

                    var template = BicepDecoder.DecodeTemplate(filePath);

                    PlantUml.CreateDiagram(template, folder, diagramName, outputFolder);
                }
            }
        }

    }
}
