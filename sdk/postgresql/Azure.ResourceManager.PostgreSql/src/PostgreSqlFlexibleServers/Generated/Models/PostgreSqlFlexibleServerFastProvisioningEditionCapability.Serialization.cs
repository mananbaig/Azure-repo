// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerFastProvisioningEditionCapability : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerFastProvisioningEditionCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerFastProvisioningEditionCapability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerFastProvisioningEditionCapability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerFastProvisioningEditionCapability>(this, options.Format);

            writer.WriteStartObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static PostgreSqlFlexibleServerFastProvisioningEditionCapability DeserializePostgreSqlFlexibleServerFastProvisioningEditionCapability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> supportedTier = default;
            Optional<string> supportedSku = default;
            Optional<long> supportedStorageGb = default;
            Optional<string> supportedServerVersions = default;
            Optional<int> serverCount = default;
            Optional<PostgreSqlFlexbileServerCapabilityStatus> status = default;
            Optional<string> reason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedTier"u8))
                {
                    supportedTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedSku"u8))
                {
                    supportedSku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedStorageGb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedStorageGb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedServerVersions"u8))
                {
                    supportedServerVersions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerFastProvisioningEditionCapability(Optional.ToNullable(status), reason.Value, supportedTier.Value, supportedSku.Value, Optional.ToNullable(supportedStorageGb), supportedServerVersions.Value, Optional.ToNullable(serverCount), rawData);
        }

        PostgreSqlFlexibleServerFastProvisioningEditionCapability IModelJsonSerializable<PostgreSqlFlexibleServerFastProvisioningEditionCapability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerFastProvisioningEditionCapability>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerFastProvisioningEditionCapability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerFastProvisioningEditionCapability>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerFastProvisioningEditionCapability>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerFastProvisioningEditionCapability IModelSerializable<PostgreSqlFlexibleServerFastProvisioningEditionCapability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerFastProvisioningEditionCapability>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerFastProvisioningEditionCapability(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlFlexibleServerFastProvisioningEditionCapability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlFlexibleServerFastProvisioningEditionCapability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerFastProvisioningEditionCapability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
