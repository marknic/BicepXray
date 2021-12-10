// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.


using BicepFlex.Models;
using BicepFlex.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace TestCmdLets
{
    [TestClass]
    public class UnitTestParameters
    {
        [TestMethod]
        public void WhenTemplateParmsMatch_ThenReturnValidJson()
        {
            try
            {
                var parameterFileInfo = new ParameterFileInfo("vnet2.bicep", "params.main.json");

                var result = ParameterFileProcessor.Process(parameterFileInfo);

                Assert.IsNotNull(result);

                // Must parse correctly
                var jsonObject = JObject.Parse(result); 

                Assert.IsNotNull(jsonObject);
                
            } catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void WhenTemplateParmsMatch_ThenWriteJsonFile()
        {
            var templateFile = "vnet2.bicep";
            var newParmFile = $"params.{Path.GetFileNameWithoutExtension(templateFile)}.json";
            var mainParmFile = "params.main.json";

            try
            {
                var parameterFileInfo = new ParameterFileInfo(templateFile, mainParmFile);

                ParameterFileProcessor.Process(parameterFileInfo);

                Assert.IsTrue(File.Exists(newParmFile));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void WhenTemplateParmsMatch_ThenOutputJsonFileMustBeValid()
        {
            var templateFile = "vnet2.bicep";
            var newParmFile = $"params.{Path.GetFileNameWithoutExtension(templateFile)}.json";
            var mainParmFile = "params.main.json";

            try
            {
                var parameterFileInfo = new ParameterFileInfo(templateFile, mainParmFile);

                ParameterFileProcessor.Process(parameterFileInfo);

                var fullPath = Path.GetFullPath(newParmFile);

                var serializedJsonString = File.ReadAllText(fullPath);

                var jsonObject = JObject.Parse(serializedJsonString);

                var jsonParms = jsonObject["parameters"];

                Assert.IsNotNull(jsonParms);
                Assert.IsNotNull(jsonParms.Children().Any());
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void WhenTemplateParmsMatch3_ThenReturnJsonWithCorrectNumberOfParameters()
        {
            try
            {
                var parameterFileInfo = new ParameterFileInfo("vnet2.bicep", "params.main.json");

                var result = ParameterFileProcessor.Process(parameterFileInfo);

                Assert.IsNotNull(result);

                var jsonObject = JObject.Parse(result);

                Assert.IsNotNull(jsonObject);

                var props = jsonObject["parameters"];

                Assert.IsNotNull(props);
                Assert.IsTrue(props.Count() == 4);

            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
