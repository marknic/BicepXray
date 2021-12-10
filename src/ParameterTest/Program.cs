// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using Azure.Deployments.Core.Extensions;
using BicepFlex.Process;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

var loggerProvider = new ConsoleLoggerProvider(new OptionsMonitor<ConsoleLoggerOptions>(new ConsoleLoggerOptions()));

var logger = loggerProvider.CreateLogger("logger");

var templateFileName = "vnet.bicep";
var parameterFileName = @"params.main.json";

var templateParameters = BicepDecoder.DecodeTemplate(templateFileName).Parameters;

var parametersInFile = JObject.Parse(File.ReadAllText(parameterFileName))["parameters"];

List<string> parameterNamesInFile = new List<string>();

List<string> parametersToDelete = new List<string>();


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
if (parametersInFile != null) {
    foreach (var name in parametersToDelete)
    {
        var paramsFound = parametersInFile.Where(x => ((JProperty)x).Name == name).ToArray();

        if (paramsFound.Any())
        {
            for (var i=0; i<paramsFound.Length; i++)
            {
                paramsFound[i].Remove();
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
            } else
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



public class OptionsMonitor<T> : IOptionsMonitor<T>
{
    private readonly T options;

    public OptionsMonitor(T options)
    {
        this.options = options;
    }

    public T CurrentValue => options;

    public T Get(string name) => options;

    public IDisposable OnChange(Action<T, string> listener) => new NullDisposable();

    private class NullDisposable : IDisposable
    {
        public void Dispose() { }
    }
}
