// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class AfdOriginPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Origin))
            {
                writer.WritePropertyName("azureOrigin");
                JsonSerializer.Serialize(writer, Origin);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                writer.WritePropertyName("httpPort");
                writer.WriteNumberValue(HttpPort.Value);
            }
            if (Optional.IsDefined(HttpsPort))
            {
                writer.WritePropertyName("httpsPort");
                writer.WriteNumberValue(HttpsPort.Value);
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader");
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority");
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight");
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(SharedPrivateLinkResource))
            {
                if (SharedPrivateLinkResource != null)
                {
                    writer.WritePropertyName("sharedPrivateLinkResource");
                    writer.WriteObjectValue(SharedPrivateLinkResource);
                }
                else
                {
                    writer.WriteNull("sharedPrivateLinkResource");
                }
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(EnforceCertificateNameCheck))
            {
                writer.WritePropertyName("enforceCertificateNameCheck");
                writer.WriteBooleanValue(EnforceCertificateNameCheck.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
