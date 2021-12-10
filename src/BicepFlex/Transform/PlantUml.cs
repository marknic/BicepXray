// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

// Copyright (c) Mark Nichols. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using BicepPrep.Models;

namespace BicepPrep.Transform
{
    public static class PlantUml
    {
        static readonly StringBuilder _plantUmlData = new();

        public static void CreateDiagram(BicepTemplate? template, string? folder, string chartName, string outputFolder)
        {
            if (template is null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            if (folder == null)
            {
                folder = Path.GetFullPath(".");
            }

            if (string.IsNullOrWhiteSpace(chartName))
            {
                throw new ArgumentException($"'{nameof(chartName)}' cannot be null or whitespace.", nameof(chartName));
            }

            if (outputFolder == null)
            {
                outputFolder = folder;
            }

            _plantUmlData.AppendLine($"@startuml {chartName}\n");

            _plantUmlData.AppendLine("skinparam state {");
            _plantUmlData.AppendLine("    FontSize 20");
            _plantUmlData.AppendLine("    FontName Arial");
            _plantUmlData.AppendLine("}");

            FormatTemplateData(template);

            DrawRelationships(template);

            _plantUmlData.AppendLine();

            _plantUmlData.AppendLine("@enduml");

            var chartOutput = _plantUmlData.ToString();

            var chartNameOut = Path.Combine(outputFolder, $"{chartName}.puml");

            File.WriteAllText(chartNameOut, chartOutput);

            Process.Start("java", $"-jar PlantUml/plantuml.jar {chartNameOut}");
        }

        private static void DrawRelationships(BicepTemplate template)
        {
            if (template != null && template.Children.Any())
            {
                foreach (var templt in template.Children)
                {
                    _plantUmlData.AppendLine($"{template.Name} --> {templt.Name}");

                    DrawRelationships(templt);
                }
            }
        }


        private static void FormatTemplateData(BicepTemplate template)
        {
            var existingCount = 0;
            var newResourcesCount = 0;
            string? leftSide;

            _plantUmlData.AppendLine($"state {template.Name} #LightBlue {{");

            foreach (var resource in template.Resources)
            {
                if (resource.Existing)
                {
                    _plantUmlData.AppendLine($"  state {resource.Name} #LawnGreen : Provider : {resource.ResourceProvider}\\nVersion : {resource.ResourceProviderVersion}\\n\\nExisting : True");

                    existingCount++;
                }
                else
                {
                    newResourcesCount++;

                    _plantUmlData.Append($"  state {resource.Name} #YellowGreen : Provider : {resource.ResourceProvider}\\nVersion : {resource.ResourceProviderVersion}\\n");

                    if (!string.IsNullOrWhiteSpace(resource.Parent))
                    {
                        _plantUmlData.Append($"Parent : {resource.Parent}\\n");
                    }

                    if (resource.DependsOn != null && resource.DependsOn.Any())
                    {
                        _plantUmlData.Append($"DependsOn : [\\n");
                        foreach (var depend in resource.DependsOn)
                        {
                            _plantUmlData.Append($"\t{depend}\\n");
                        }
                        _plantUmlData.Append("]\\n");

                    }
                    _plantUmlData.AppendLine($"\\nExisting : False");
                }
            }

            if (existingCount > 1)
            {
                leftSide = null;

                _plantUmlData.AppendLine();

                foreach (var resource in template.Resources.Where(r => r.Existing))
                {
                    if (leftSide != null)
                    {
                        _plantUmlData.AppendLine($"{leftSide} -[hidden]-> {resource.Name}");
                    }

                    leftSide = resource.Name;
                }
            }

            if (newResourcesCount > 1)
            {
                _plantUmlData.AppendLine();

                leftSide = null;

                foreach (var resource in template.Resources.Where(r => r.Existing == false))
                {
                    if (leftSide != null)
                    {
                        _plantUmlData.AppendLine($"{leftSide} -[hidden]-> {resource.Name}");
                    }

                    leftSide = resource.Name;
                }
            }
            _plantUmlData.AppendLine("}");

            _plantUmlData.AppendLine();

            _plantUmlData.AppendLine($"{template.Name} : <size:16>**__Parameters__**");

            if (template.Parameters != null && template.Parameters.Any())
            {
                foreach (var parameter in template.Parameters)
                {
                    _plantUmlData.AppendLine($"{template.Name} : **{parameter.Name}** : {ParamHelper.PrintType(parameter.Type)}");
                }
            }
            else
            {
                _plantUmlData.AppendLine($"{template.Name} : None ");
            }

            _plantUmlData.AppendLine();
            _plantUmlData.AppendLine($"{template.Name} : \\n<size:16>**__Outputs__**");

            if (template.Outputs != null && template.Outputs.Any())
            {
                foreach (var output in template.Outputs)
                {
                    _plantUmlData.AppendLine($"{template.Name} : **{output.Name}** : {ParamHelper.PrintType(output.Type)}");
                }
            }
            else
            {
                _plantUmlData.AppendLine($"{template.Name} : None ");
            }
            _plantUmlData.AppendLine();

            foreach (var childTmpl in template.Children)
            {
                FormatTemplateData(childTmpl);
            }
        }
    }
}
