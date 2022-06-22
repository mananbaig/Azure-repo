// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationPackageSupportUris
    {
        internal static ArmApplicationPackageSupportUris DeserializeArmApplicationPackageSupportUris(JsonElement element)
        {
            Optional<string> publicAzure = default;
            Optional<string> governmentCloud = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicAzure"))
                {
                    publicAzure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("governmentCloud"))
                {
                    governmentCloud = property.Value.GetString();
                    continue;
                }
            }
            return new ArmApplicationPackageSupportUris(publicAzure.Value, governmentCloud.Value);
        }
    }
}
