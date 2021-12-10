// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BicepFlex.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BicepFlex.Process
{
    public static class ParameterFileProcessor
    {
        //const string SchemaValue = "https://schema.management.azure.com/schemas/2019-04-01/deploymentParameters.json#";
        //const string ContentVersion = "1.0.0.0";

        public static string Process(ParameterFileInfo parameterFileInfo)
        {
            string? outputParameterFile;

            var loggerProvider = new ConsoleLoggerProvider(new LoggerProvider<ConsoleLoggerOptions>(new ConsoleLoggerOptions()));
            var logger = loggerProvider.CreateLogger("logger");

            var templateFileName = parameterFileInfo.BicepTemplateFile; // "vnet.bicep";
            var parameterFileName = parameterFileInfo.MainParameterFile; //  @"params.main.json";

            var templateParameters = BicepDecoder.DecodeTemplate(templateFileName).Parameters;

            var parameterFileObject = JObject.Parse(File.ReadAllText(parameterFileName));
            var parametersInFile = parameterFileObject["parameters"];

            var parameterNamesInFile = new List<string>();

            var parametersToDelete = new List<string>();


            if (parameterFileInfo == null)
            {
                throw new ArgumentNullException(nameof(parameterFileInfo));
            }

            if (parameterFileInfo.MainParameterFile == null)
            {
                throw new NullReferenceException($"{nameof(parameterFileInfo.MainParameterFile)} is null and must have the name of the main parameter file as input");
            }

            if (string.IsNullOrWhiteSpace(parameterFileInfo.OutputParameterFile))
            {
                var fileNameNoExtension = Path.GetFileNameWithoutExtension(parameterFileInfo.MainParameterFile);

                if (string.IsNullOrWhiteSpace(fileNameNoExtension))
                {
                    throw new ArgumentException("No Template filename has been provided to process");
                }

                outputParameterFile = Path.GetDirectoryName(parameterFileInfo.MainParameterFile);

                if (outputParameterFile == null)
                {
                    outputParameterFile = ".";
                }

                outputParameterFile = Path.Combine(outputParameterFile, fileNameNoExtension, ".params.json");

            }
            else
            {
                outputParameterFile = parameterFileInfo.OutputParameterFile;
            }

            // Get the list of parameter names in the parameter file
            if (parametersInFile != null)
            {
                // Scan each parameter in the file to see if it should be kept or discarded
                foreach (JProperty parameter in parametersInFile.Children())
                {
                    // if the key("Parameter Name") is not in the fileParameterNames list then
                    // add it.  If it is there already, then there's a duplicate named parm in the file
                    if (!parameterNamesInFile.Any(x => x.Contains(parameter.Name)))
                    {
                        // It doesn't already exist, so add it to the list
                        parameterNamesInFile.Add(parameter.Name);

                        // Look for the name in the template parameter list
                        var paramFound = templateParameters.FirstOrDefault(x => x.Name == parameter.Name);

                        // If we cannot find the parameter from the parm file in the template,
                        // then delete the parm from the parameter file list 
                        if (paramFound == null)
                        {
                            parametersToDelete.Add(parameter.Name);
                        }
                    }
                    else
                    {
                        // Log the error
                        logger.LogError($"Duplicate parameter found ({parameter.Name}) in the parameter file: {parameterFileName}");
                    }
                }
            }

            // Remove all of the unused parameters
            if (parametersInFile != null)
            {
                foreach (var name in parametersToDelete)
                {
                    var paramsFound = parametersInFile.Where(x => ((JProperty)x).Name == name).ToArray();

                    if (paramsFound.Any())
                    {
                        for (var i = 0; i < paramsFound.Length; i++)
                        {
                            paramsFound[i].Remove();
                        }
                    }
                }

                foreach (var name in parametersToDelete)
                {
                    var paramsFound = parametersInFile.Where(x => ((JProperty)x).Name == name).ToArray();

                    if (paramsFound.Any())
                    {
                        for (var i = 0; i < paramsFound.Length; i++)
                        {
                            paramsFound[i].Remove();
                        }
                    }
                }

                if (!string.IsNullOrEmpty(parameterFileInfo.Exceptions))
                {

                    var parameterToLeaveOut = parameterFileInfo.Exceptions.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                    foreach (var name in parameterToLeaveOut)
                    {
                        var paramsFound = parametersInFile.Where(x => ((JProperty)x).Name == name).ToArray();

                        if (paramsFound.Any())
                        {
                            for (var i = 0; i < paramsFound.Length; i++)
                            {
                                paramsFound[i].Remove();
                            }
                        }
                        else
                        {
                            logger.LogWarning($"Parameter in Exception List ({name}) was not found in the list of Parameter File.");
                        }
                    }
                }
            }

            // Check for errors of omission
            // if a parameter in a template is not in the parameter file AND it does not have a default value, 
            // then it is an error
            if (parameterNamesInFile.Count > 0)
            {
                foreach (var templateParm in templateParameters)
                {
                    if (!parameterNamesInFile.Contains(templateParm.Name))
                    {
                        if (string.IsNullOrWhiteSpace(templateParm.DefaultVal))
                        {
                            logger.LogError($"A parameter in the template ({templateFileName}) was not found in the parameter file: {parameterFileName}.  Note: there wasn't a default value found in the template.");
                        }
                        else
                        {
                            logger.LogInformation($"A parameter in the template ({templateFileName}) was not found in the parameter file: {parameterFileName}.  However, a default value was found.");
                        }
                    }
                    else
                    {
                        logger.LogInformation($"The parameter in the template ({templateParm.Name}) was matched with the parameter in the file: {parameterFileName}");
                    }
                }
            }

            var parameterFileSerialized = JsonConvert.SerializeObject(parameterFileObject);

            return parameterFileSerialized;
        }
    }
}
