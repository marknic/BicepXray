// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace BicepPrep.Models
{
    public class BicepModule
    {
        public string Name { get; private set; }
        public string ModuleFile { get; private set; }
        public string[]? DependsOn { get; private set; }


        public BicepModule(string name, string moduleFile, string[]? dependsOn = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(moduleFile))
            {
                throw new System.ArgumentException($"'{nameof(moduleFile)}' cannot be null or whitespace.", nameof(moduleFile));
            }

            Name = name;
            ModuleFile = moduleFile;
            DependsOn = dependsOn;
        }
    }
}
