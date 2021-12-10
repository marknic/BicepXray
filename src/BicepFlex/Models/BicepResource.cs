// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

namespace BicepPrep.Models
{
    public class BicepResource
    {
        public string Name { get; private set; }
        public string ResourceProvider { get; private set; }
        public string ResourceProviderVersion { get; private set; }
        public string[]? DependsOn { get; private set; }
        public string? Parent { get; private set; }
        public bool Existing { get; private set; }

        public BicepResource(string name, string resourceProvider, string resourceProviderVersion, bool existing = false, string[]? dependsOn = null, string? parent = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(resourceProvider))
            {
                throw new System.ArgumentException($"'{nameof(resourceProvider)}' cannot be null or whitespace.", nameof(resourceProvider));
            }

            if (string.IsNullOrWhiteSpace(resourceProviderVersion))
            {
                throw new System.ArgumentException($"'{nameof(resourceProviderVersion)}' cannot be null or whitespace.", nameof(resourceProviderVersion));
            }

            Name = name;
            ResourceProvider = resourceProvider;
            ResourceProviderVersion = resourceProviderVersion;
            DependsOn = dependsOn;
            Parent = parent;
            Existing = existing;
        }
    }
}
