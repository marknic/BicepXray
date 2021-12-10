// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

using System.Collections.Generic;


namespace BicepPrep.Models
{
    public class BicepTemplate
    {
        public string TargetScope { get; private set; }

        public string Name { get; private set; }

        public string TemplateFile { get; private set; }

        public IList<BicepParam> Parameters { get; private set; }

        public IList<BicepModule>? Modules { get; private set; }

        public IList<BicepResource> Resources { get; private set; }

        public IList<BicepOutput> Outputs { get; private set; }

        public IList<BicepTemplate> Children { get; private set; }


        public BicepTemplate(string name,
            string targetScope, string templateFile,
            IList<BicepParam> parameters, IList<BicepModule>? modules,
            IList<BicepResource> resources, IList<BicepOutput> outputs,
            IList<BicepTemplate> children)
        {
            Name = name;
            TargetScope = targetScope;
            TemplateFile = templateFile;
            Parameters = parameters;
            Modules = modules;
            Resources = resources;
            Outputs = outputs;
            Children = children;
        }
    }
}
