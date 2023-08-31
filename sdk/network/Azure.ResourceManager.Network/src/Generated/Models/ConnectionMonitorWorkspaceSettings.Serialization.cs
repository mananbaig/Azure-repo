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

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ConnectionMonitorWorkspaceSettings : IUtf8JsonSerializable, IModelJsonSerializable<ConnectionMonitorWorkspaceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectionMonitorWorkspaceSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectionMonitorWorkspaceSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static ConnectionMonitorWorkspaceSettings DeserializeConnectionMonitorWorkspaceSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> workspaceResourceId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new ConnectionMonitorWorkspaceSettings(workspaceResourceId.Value, rawData);
        }

        ConnectionMonitorWorkspaceSettings IModelJsonSerializable<ConnectionMonitorWorkspaceSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorWorkspaceSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectionMonitorWorkspaceSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectionMonitorWorkspaceSettings IModelSerializable<ConnectionMonitorWorkspaceSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectionMonitorWorkspaceSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectionMonitorWorkspaceSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectionMonitorWorkspaceSettings"/> to convert. </param>
        public static implicit operator RequestContent(ConnectionMonitorWorkspaceSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectionMonitorWorkspaceSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectionMonitorWorkspaceSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectionMonitorWorkspaceSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
