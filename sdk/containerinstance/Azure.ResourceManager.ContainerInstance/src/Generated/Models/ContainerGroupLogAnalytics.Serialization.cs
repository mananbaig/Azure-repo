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

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerGroupLogAnalytics : IUtf8JsonSerializable, IModelJsonSerializable<ContainerGroupLogAnalytics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerGroupLogAnalytics>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerGroupLogAnalytics>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("workspaceId"u8);
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("workspaceKey"u8);
            writer.WriteStringValue(WorkspaceKey);
            if (Optional.IsDefined(LogType))
            {
                writer.WritePropertyName("logType"u8);
                writer.WriteStringValue(LogType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId"u8);
                writer.WriteStringValue(WorkspaceResourceId);
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

        internal static ContainerGroupLogAnalytics DeserializeContainerGroupLogAnalytics(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string workspaceId = default;
            string workspaceKey = default;
            Optional<ContainerGroupLogAnalyticsLogType> logType = default;
            Optional<IDictionary<string, string>> metadata = default;
            Optional<ResourceIdentifier> workspaceResourceId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceKey"u8))
                {
                    workspaceKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logType = new ContainerGroupLogAnalyticsLogType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("workspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerGroupLogAnalytics(workspaceId, workspaceKey, Optional.ToNullable(logType), Optional.ToDictionary(metadata), workspaceResourceId.Value, rawData);
        }

        ContainerGroupLogAnalytics IModelJsonSerializable<ContainerGroupLogAnalytics>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupLogAnalytics(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerGroupLogAnalytics>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerGroupLogAnalytics IModelSerializable<ContainerGroupLogAnalytics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerGroupLogAnalytics(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerGroupLogAnalytics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerGroupLogAnalytics"/> to convert. </param>
        public static implicit operator RequestContent(ContainerGroupLogAnalytics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerGroupLogAnalytics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerGroupLogAnalytics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerGroupLogAnalytics(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
