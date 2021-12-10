// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using BicepFlex.Models;
using BicepFlex.Process;
using System;
using System.Management.Automation;

namespace BicepXray.CmdLet
{
    [Cmdlet(VerbsCommon.New, "Xray")]
    [OutputType(typeof(string))]
    public class BicepXrayCmdletCommand : Cmdlet
    {

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string? BicepTemplateFile { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true)]
        public string? OutputFolder { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            if (BicepTemplateFile == null)
            {
                throw new ArgumentNullException(nameof(BicepTemplateFile));
            }

            var xrayData = new TemplateFile(BicepTemplateFile, OutputFolder);

            XrayProcessor.DoXray(xrayData);

            WriteObject(xrayData);
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
