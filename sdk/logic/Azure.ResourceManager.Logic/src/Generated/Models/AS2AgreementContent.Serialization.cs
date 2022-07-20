// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2AgreementContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("receiveAgreement");
            writer.WriteObjectValue(ReceiveAgreement);
            writer.WritePropertyName("sendAgreement");
            writer.WriteObjectValue(SendAgreement);
            writer.WriteEndObject();
        }

        internal static AS2AgreementContent DeserializeAS2AgreementContent(JsonElement element)
        {
            AS2OneWayAgreement receiveAgreement = default;
            AS2OneWayAgreement sendAgreement = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("receiveAgreement"))
                {
                    receiveAgreement = AS2OneWayAgreement.DeserializeAS2OneWayAgreement(property.Value);
                    continue;
                }
                if (property.NameEquals("sendAgreement"))
                {
                    sendAgreement = AS2OneWayAgreement.DeserializeAS2OneWayAgreement(property.Value);
                    continue;
                }
            }
            return new AS2AgreementContent(receiveAgreement, sendAgreement);
        }
    }
}
