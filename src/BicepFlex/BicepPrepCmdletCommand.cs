// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System.Management.Automation;
using BicepFlex.Models;
using BicepFlex.Process;

namespace BicepPrep.CmdLet
{

    [Cmdlet(VerbsCommon.New, "Prep")]
    [OutputType(typeof(string))]
    public class BicepPrepCmdletCommand : Cmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string? BicepTemplateFile { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string? MainParameterFile { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true)]
        public string? OutputParameterFile { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true)]
        public string? Exceptions { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }


        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            var parameterFileInfo = new ParameterFileInfo(BicepTemplateFile, MainParameterFile, OutputParameterFile, Exceptions, Force);

            var data = ParameterFileProcessor.Process(parameterFileInfo);

            WriteObject(parameterFileInfo);
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
