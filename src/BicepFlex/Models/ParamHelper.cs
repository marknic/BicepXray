// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace BicepPrep.Models
{
    public class ParamHelper
    {
        public static string? PrintType(ParamType type)
        {
            switch (type)
            {
                case ParamType.stringParam:
                    return "string";
                case ParamType.intParam:
                    return "int";
                case ParamType.boolParam:
                    return "bool";
                case ParamType.arrayParam:
                    return "array";
                case ParamType.objectParam:
                    return "object";
                default:
                    return null;
            }
        }
    }
}
