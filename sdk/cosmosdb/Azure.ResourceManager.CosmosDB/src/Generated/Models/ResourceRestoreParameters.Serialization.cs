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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ResourceRestoreParameters : IUtf8JsonSerializable, IModelJsonSerializable<ResourceRestoreParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceRestoreParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceRestoreParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ResourceRestoreParameters>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RestoreSource))
            {
                writer.WritePropertyName("restoreSource"u8);
                writer.WriteStringValue(RestoreSource);
            }
            if (Optional.IsDefined(RestoreTimestampInUtc))
            {
                writer.WritePropertyName("restoreTimestampInUtc"u8);
                writer.WriteStringValue(RestoreTimestampInUtc.Value, "O");
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

        internal static ResourceRestoreParameters DeserializeResourceRestoreParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> restoreSource = default;
            Optional<DateTimeOffset> restoreTimestampInUtc = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restoreSource"u8))
                {
                    restoreSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTimestampInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreTimestampInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceRestoreParameters(restoreSource.Value, Optional.ToNullable(restoreTimestampInUtc), rawData);
        }

        ResourceRestoreParameters IModelJsonSerializable<ResourceRestoreParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ResourceRestoreParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceRestoreParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceRestoreParameters>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ResourceRestoreParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceRestoreParameters IModelSerializable<ResourceRestoreParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ResourceRestoreParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceRestoreParameters(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ResourceRestoreParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ResourceRestoreParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceRestoreParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
