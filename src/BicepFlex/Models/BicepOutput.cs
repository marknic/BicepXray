// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace BicepPrep.Models
{
    public class BicepOutput
    {
        public string Name { get; private set; }
        public ParamType Type { get; private set; }

        public BicepOutput(string name, ParamType type)
        {
            Name = name;
            Type = type;
        }
    }
}
