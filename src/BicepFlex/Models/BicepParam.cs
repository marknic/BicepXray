// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace BicepPrep.Models
{
    public class BicepParam
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public ParamType Type { get; set; }
        public string? DefaultVal { get; set; }

        public BicepParam(string name, ParamType type, string? descript = null, string? defaultVal = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            Name = name;
            Description = descript;
            Type = type;
            DefaultVal = defaultVal;
        }
    }
}
