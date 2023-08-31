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

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistrySourceTrigger : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistrySourceTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistrySourceTrigger>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistrySourceTrigger>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceRepository"u8);
            writer.WriteObjectValue(SourceRepository);
            writer.WritePropertyName("sourceTriggerEvents"u8);
            writer.WriteStartArray();
            foreach (var item in SourceTriggerEvents)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        internal static ContainerRegistrySourceTrigger DeserializeContainerRegistrySourceTrigger(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceCodeRepoProperties sourceRepository = default;
            IList<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents = default;
            Optional<ContainerRegistryTriggerStatus> status = default;
            string name = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceRepository"u8))
                {
                    sourceRepository = SourceCodeRepoProperties.DeserializeSourceCodeRepoProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceTriggerEvents"u8))
                {
                    List<ContainerRegistrySourceTriggerEvent> array = new List<ContainerRegistrySourceTriggerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ContainerRegistrySourceTriggerEvent(item.GetString()));
                    }
                    sourceTriggerEvents = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ContainerRegistryTriggerStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistrySourceTrigger(sourceRepository, sourceTriggerEvents, Optional.ToNullable(status), name, rawData);
        }

        ContainerRegistrySourceTrigger IModelJsonSerializable<ContainerRegistrySourceTrigger>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistrySourceTrigger(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistrySourceTrigger>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistrySourceTrigger IModelSerializable<ContainerRegistrySourceTrigger>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistrySourceTrigger(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerRegistrySourceTrigger model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerRegistrySourceTrigger(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistrySourceTrigger(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
