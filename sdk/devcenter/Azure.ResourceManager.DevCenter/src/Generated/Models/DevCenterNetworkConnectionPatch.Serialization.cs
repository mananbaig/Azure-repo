// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterNetworkConnectionPatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Core.Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Core.Optional.IsDefined(OrganizationUnit))
            {
                writer.WritePropertyName("organizationUnit"u8);
                writer.WriteStringValue(OrganizationUnit);
            }
            if (Core.Optional.IsDefined(DomainUsername))
            {
                writer.WritePropertyName("domainUsername"u8);
                writer.WriteStringValue(DomainUsername);
            }
            if (Core.Optional.IsDefined(DomainPassword))
            {
                writer.WritePropertyName("domainPassword"u8);
                writer.WriteStringValue(DomainPassword);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
