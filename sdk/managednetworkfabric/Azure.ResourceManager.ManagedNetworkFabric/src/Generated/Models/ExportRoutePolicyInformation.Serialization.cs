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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ExportRoutePolicyInformation : IUtf8JsonSerializable, IModelJsonSerializable<ExportRoutePolicyInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExportRoutePolicyInformation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExportRoutePolicyInformation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ExportIPv4RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv4RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv4RoutePolicyId);
            }
            if (Optional.IsDefined(ExportIPv6RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv6RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv6RoutePolicyId);
            }
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

        internal static ExportRoutePolicyInformation DeserializeExportRoutePolicyInformation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> exportIPv4RoutePolicyId = default;
            Optional<ResourceIdentifier> exportIPv6RoutePolicyId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exportIpv4RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv4RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exportIpv6RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv6RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExportRoutePolicyInformation(exportIPv4RoutePolicyId.Value, exportIPv6RoutePolicyId.Value, rawData);
        }

        ExportRoutePolicyInformation IModelJsonSerializable<ExportRoutePolicyInformation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExportRoutePolicyInformation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExportRoutePolicyInformation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExportRoutePolicyInformation IModelSerializable<ExportRoutePolicyInformation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExportRoutePolicyInformation(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ExportRoutePolicyInformation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ExportRoutePolicyInformation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExportRoutePolicyInformation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
