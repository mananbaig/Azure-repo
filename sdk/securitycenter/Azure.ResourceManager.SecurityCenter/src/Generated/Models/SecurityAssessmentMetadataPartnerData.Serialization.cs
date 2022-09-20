// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAssessmentMetadataPartnerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("partnerName");
            writer.WriteStringValue(PartnerName);
            if (Optional.IsDefined(ProductName))
            {
                writer.WritePropertyName("productName");
                writer.WriteStringValue(ProductName);
            }
            writer.WritePropertyName("secret");
            writer.WriteStringValue(Secret);
            writer.WriteEndObject();
        }

        internal static SecurityAssessmentMetadataPartnerData DeserializeSecurityAssessmentMetadataPartnerData(JsonElement element)
        {
            string partnerName = default;
            Optional<string> productName = default;
            string secret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partnerName"))
                {
                    partnerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productName"))
                {
                    productName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secret"))
                {
                    secret = property.Value.GetString();
                    continue;
                }
            }
            return new SecurityAssessmentMetadataPartnerData(partnerName, productName.Value, secret);
        }
    }
}
