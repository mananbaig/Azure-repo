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
    public partial class ExtendedRestorableSqlContainerResourceInfo : IUtf8JsonSerializable, IModelJsonSerializable<ExtendedRestorableSqlContainerResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExtendedRestorableSqlContainerResourceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExtendedRestorableSqlContainerResourceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container"u8);
                writer.WriteObjectValue(Container);
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

        internal static ExtendedRestorableSqlContainerResourceInfo DeserializeExtendedRestorableSqlContainerResourceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<CosmosDBOperationType> operationType = default;
            Optional<string> eventTimestamp = default;
            Optional<string> ownerId = default;
            Optional<string> ownerResourceId = default;
            Optional<RestorableSqlContainerPropertiesResourceContainer> container = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("container"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    container = RestorableSqlContainerPropertiesResourceContainer.DeserializeRestorableSqlContainerPropertiesResourceContainer(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExtendedRestorableSqlContainerResourceInfo(rid.Value, Optional.ToNullable(operationType), eventTimestamp.Value, ownerId.Value, ownerResourceId.Value, container.Value, rawData);
        }

        ExtendedRestorableSqlContainerResourceInfo IModelJsonSerializable<ExtendedRestorableSqlContainerResourceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedRestorableSqlContainerResourceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExtendedRestorableSqlContainerResourceInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExtendedRestorableSqlContainerResourceInfo IModelSerializable<ExtendedRestorableSqlContainerResourceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExtendedRestorableSqlContainerResourceInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ExtendedRestorableSqlContainerResourceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ExtendedRestorableSqlContainerResourceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExtendedRestorableSqlContainerResourceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
