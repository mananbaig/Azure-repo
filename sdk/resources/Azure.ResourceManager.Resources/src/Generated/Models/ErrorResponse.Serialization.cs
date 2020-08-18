// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ErrorResponse
    {
        internal static ErrorResponse DeserializeErrorResponse(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<ErrorResponse>> details = default;
            Optional<IReadOnlyList<ErrorAdditionalInfo>> additionalInfo = default;
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
                if (property.NameEquals("details"))
                {
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeErrorResponse(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("additionalInfo"))
                {
                    List<ErrorAdditionalInfo> array = new List<ErrorAdditionalInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorAdditionalInfo.DeserializeErrorAdditionalInfo(item));
                    }
                    additionalInfo = array;
                    continue;
                }
            }
            return new ErrorResponse(code.Value, message.Value, target.Value, Optional.ToList(details), Optional.ToList(additionalInfo));
        }
    }
}
