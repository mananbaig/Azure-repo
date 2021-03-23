// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.AccessControl.Models
{
    internal partial class ErrorDetail
    {
        internal static ErrorDetail DeserializeErrorDetail(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<string> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
            }
            return new ErrorDetail(code, message, target.Value);
        }
    }
}
