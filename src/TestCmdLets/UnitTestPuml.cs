// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.


using BicepFlex.Models;
using BicepFlex.Process;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestCmdLets
{
    [TestClass]
    public class UnitTestPuml
    {
        [TestMethod]
        public void WhenFilePathIsEmptyOrNull_ThenShouldFail()
        {
            try
            {
                var templateFile = new TemplateFile("", null);

                XrayProcessor.DoXray(templateFile);

                Assert.Fail();

            } catch (Exception)
            {
            }
        }

        [TestMethod]
        public void WhenFilePathIsNotValid_ThenShouldFail()
        {
            try
            {
                var templateFile = new TemplateFile("bl}{ah", null);

                XrayProcessor.DoXray(templateFile);

                Assert.Fail();

            }
            catch (Exception)
            {
            }
        }

        [TestMethod]
        public void WhenFilePathIsDoesNotHaveFile_ThenShouldProcessFolder()
        {
            try
            {
                var templateFile = new TemplateFile(".", null);
                var runDir = Path.GetFullPath(".");

                XrayProcessor.DoXray(templateFile);

                var fileListPuml = Directory.GetFiles(runDir, "*.puml");
                var fileListPng = Directory.GetFiles(runDir, "*.png");

                Assert.IsTrue(fileListPuml.Length > 0);
                Assert.IsTrue(fileListPng.Length > 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void WhenFullPathIsProvided_ThenShouldProcessFileProperly()
        {
            try
            {
                string templateFileName = "vnet.bicep";

                var runDir = Path.GetFullPath(".");
                var filePath = Path.Combine(runDir, templateFileName);
                
                var templateFileData = new TemplateFile(filePath, null);

                var templateFile = new TemplateFile(filePath, null);

                XrayProcessor.DoXray(templateFile);

                var fileNameNoExt = Path.GetFileNameWithoutExtension(templateFileName);

                var filePathPuml = Path.Combine(runDir, $"{fileNameNoExt}.puml");
                var filePathPng = Path.Combine(runDir, $"{fileNameNoExt}.png");

                Assert.IsTrue(File.Exists(filePathPuml));
                Assert.IsTrue(File.Exists(filePathPng));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void WhenOutputPathIsProvided_ThenShouldWriteOutputFilesInThatLocation()
        {
            try
            {
                string templateFileName = "vnet.bicep";
                
                var runDir = Path.GetFullPath(".");
                var filePath = Path.Combine(runDir, templateFileName);
                var tmpFolder = Path.GetTempPath();

                var templateFile = new TemplateFile(filePath, tmpFolder);

                XrayProcessor.DoXray(templateFile);

                var fileNameNoExt = Path.GetFileNameWithoutExtension(templateFileName);

                var filePathPuml = Path.Combine(tmpFolder, $"{fileNameNoExt}.puml");
                var filePathPng = Path.Combine(tmpFolder, $"{fileNameNoExt}.png");

                Assert.IsTrue(File.Exists(filePathPuml));
                Assert.IsTrue(File.Exists(filePathPng));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
