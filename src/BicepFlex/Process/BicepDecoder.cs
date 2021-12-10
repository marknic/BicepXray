// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using Bicep.Core.Diagnostics;
using Bicep.Core.Parsing;
using BicepPrep.Models;

namespace BicepFlex.Process
{
    public class BicepDecoder
    {
        public static BicepTemplate DecodeTemplate(string templateFile)
        {
            var templateText = File.ReadAllText(templateFile);

            var diagnosticWriter = ToListDiagnosticWriter.Create();

            var lexer = new Lexer(new SlidingTextWindow(templateText), diagnosticWriter);
            lexer.Lex();

            var tokens = lexer.GetTokens();

            var workingFolder = Path.GetDirectoryName(Path.GetFullPath(templateFile));

            if (workingFolder == null)
            {
                workingFolder = ".";
            }

            string? description = null;
            var lookForDescription = false;

            var templateName = Path.GetFileNameWithoutExtension(templateFile);
            var targetScope = "default";
            var parameterList = new List<BicepParam>();
            var moduleList = new List<BicepModule>();
            var resourceList = new List<BicepResource>();
            var outputList = new List<BicepOutput>();

            string name;
            string? parent;

            List<string> dependsOn;


            for (var i = 0; i < tokens.Length; i++)
            {
                if (!lookForDescription)
                {
                    if (tokens[i].Type == TokenType.Identifier)
                    {
                        switch (tokens[i].Text.ToLower())
                        {
                            case "targetscope":
                                i++;

                                while (tokens[i].Type != TokenType.StringComplete) { i++; }

                                targetScope = tokens[i].Text;

                                break;

                            case "description":
                                lookForDescription = true;
                                break;

                            case "output":
                                i++;

                                var outputName = tokens[i].Text;

                                i++;

                                while (tokens[i].Type != TokenType.Identifier) { i++; }

                                var type = (ParamType)Enum.Parse(typeof(ParamType), $"{tokens[i].Text}Param");

                                outputList.Add(new BicepOutput(outputName, type));

                                while (tokens[i].Type != TokenType.NewLine && tokens[i].Type != TokenType.EndOfFile) { i++; }

                                break;

                            case "param":
                                var bType = Enum.Parse<ParamType>(tokens[i + 2].Text + "Param");
                                var defaultValue = string.Empty;
                                int j;

                                var paramName = tokens[i + 1].Text;

                                // Is there a default
                                if (i < tokens.Length - 3 && tokens[i + 3].Type == TokenType.Assignment)
                                {
                                    for (j = 4; tokens[j + i].Type == TokenType.NewLine; j++)
                                    {
                                        ;
                                    }

                                    switch (bType)
                                    {
                                        case ParamType.stringParam:
                                        case ParamType.intParam:
                                        case ParamType.boolParam:

                                            while (tokens[i + j].Text != "\r\n\r\n")
                                            {
                                                defaultValue += tokens[i + j++].Text;
                                            }

                                            break;

                                        case ParamType.arrayParam:

                                            while (tokens[j + i].Type != TokenType.RightSquare)
                                            {
                                                defaultValue += tokens[j + i].Text;
                                                if (tokens[j + i].Type == TokenType.StringComplete && tokens[j + i + 2].Type != TokenType.RightSquare)
                                                {
                                                    defaultValue += ", ";
                                                }
                                                j++;
                                            }

                                            defaultValue += tokens[j + i].Text;

                                            i += j + 1;

                                            break;

                                        case ParamType.objectParam:

                                            defaultValue += tokens[j++ + i].Text;

                                            while (tokens[j + i].Type != TokenType.RightBrace)
                                            {
                                                if (tokens[j + i].Type == TokenType.NewLine)
                                                {
                                                    defaultValue += "\r\n";
                                                    j++;
                                                }

                                                defaultValue += $"{tokens[j + i].Text}: {tokens[j + i + 2].Text}";

                                                j += 3;

                                                if (tokens[j + i].Type != TokenType.RightBrace && tokens[j + i + 1].Type != TokenType.RightBrace)
                                                {
                                                    defaultValue += ", ";
                                                }

                                                if (tokens[j + i].Type == TokenType.NewLine)
                                                {
                                                    defaultValue += "\r\n";
                                                    j++;
                                                }

                                            }

                                            defaultValue += tokens[j + i].Text;

                                            i += j + 1;

                                            break;

                                    }
                                }

                                parameterList.Add(new BicepParam(paramName, bType, description, defaultValue));
                                description = null;
                                lookForDescription = false;

                                break;

                            case "module":

                                i++;

                                if (i < tokens.Length && tokens[i].Type == TokenType.NewLine) { i++; }

                                name = tokens[i++].Text;
                                var file = tokens[i++].Text;
                                parent = null;
                                dependsOn = new List<string>();

                                while (tokens[i++].Type != TokenType.LeftBrace) { }
                                i++;
                                j = 1;

                                while (j >= 1)
                                {
                                    if (tokens[i].Type == TokenType.RightBrace)
                                    {
                                        j--;
                                    }
                                    else
                                    {
                                        if (tokens[i].Type == TokenType.Identifier && tokens[i].Text.ToLower() == "dependson")
                                        {
                                            i++;

                                            while (tokens[i].Type != TokenType.RightSquare)
                                            {
                                                if (tokens[i].Type == TokenType.Identifier)
                                                {
                                                    dependsOn.Add(tokens[i].Text);
                                                }

                                                i++;
                                            }
                                        }
                                    }

                                    if (j >= 1) { i++; }
                                }

                                var bicepModule = new BicepModule(name, file, dependsOn.Count > 0 ? dependsOn.ToArray() : null);

                                moduleList.Add(bicepModule);

                                break;


                            case "resource":

                                i++;

                                name = tokens[i++].Text;
                                parent = null;
                                var existing = false;
                                dependsOn = new List<string>();

                                var providerString = tokens[i++].Text;

                                var providerSplit = providerString.Split('@');
                                var resourceProvider = providerSplit[0].Replace("\'", "");
                                var resourceProviderVersion = providerSplit[1].Replace("\'", "");

                                if (tokens[i].Text.ToLower() == "existing")
                                {
                                    existing = true;

                                    while (tokens[i].Type != TokenType.RightBrace) { i++; }
                                    i++;
                                }
                                else
                                {
                                    while (tokens[i].Type != TokenType.LeftBrace) { i++; }
                                    i++;
                                    j = 1;

                                    while (j >= 1)
                                    {
                                        if (tokens[i].Type == TokenType.RightBrace)
                                        {
                                            j--;
                                        }
                                        else if (tokens[i].Type == TokenType.LeftBrace)
                                        {
                                            j++;
                                        }
                                        else
                                        {
                                            if (tokens[i].Type == TokenType.Identifier)
                                            {
                                                switch (tokens[i].Text.ToLower())
                                                {
                                                    case "dependson":
                                                        i++;

                                                        while (tokens[i].Type != TokenType.RightSquare)
                                                        {
                                                            if (tokens[i].Type == TokenType.Identifier)
                                                            {
                                                                dependsOn.Add(tokens[i].Text);
                                                            }

                                                            i++;
                                                        }
                                                        break;

                                                    case "parent":

                                                        i++;

                                                        while (tokens[i].Type != TokenType.Identifier) { i++; }

                                                        parent = tokens[i].Text;

                                                        break;
                                                }
                                            }
                                        }

                                        if (j >= 1) { i++; }
                                    }
                                }

                                var bicepResource = new BicepResource(name, resourceProvider, resourceProviderVersion, existing, dependsOn.Count > 0 ? dependsOn.ToArray() : null, parent);

                                resourceList.Add(bicepResource);

                                break;
                        }
                    }
                }
                else
                {
                    if (tokens[i].Type == TokenType.StringComplete)
                    {
                        description = tokens[i].Text;
                        lookForDescription = false;
                    }
                }
            }

            var children = new List<BicepTemplate>();
            string moduleFilename;

            if (moduleList != null && moduleList.Count > 0)
            {
                foreach (var module in moduleList)
                {
                    if (!Path.IsPathRooted(module.ModuleFile))
                    {
                        moduleFilename = Path.Combine(workingFolder, module.ModuleFile);
                    }
                    else
                    {
                        moduleFilename = module.ModuleFile;
                    }

                    var wrongFolderSeparator = Path.DirectorySeparatorChar == '\\' ? '/' : '\\';

                    // There may be single quotes surrounding the filename
                    moduleFilename = moduleFilename.Replace("\'", "");
                    moduleFilename = moduleFilename.Replace(wrongFolderSeparator, Path.DirectorySeparatorChar);

                    children.Add(DecodeTemplate(moduleFilename));
                }
            }

            var template = new BicepTemplate(templateName, targetScope, templateFile, parameterList, moduleList, resourceList, outputList, children);

            return template;
        }

    }
}
