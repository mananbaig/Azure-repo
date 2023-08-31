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
    public partial class ConnectionMonitorOutput : IUtf8JsonSerializable, IModelJsonSerializable<ConnectionMonitorOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectionMonitorOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectionMonitorOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OutputType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(OutputType.Value.ToString());
            }
            if (Optional.IsDefined(WorkspaceSettings))
            {
                writer.WritePropertyName("workspaceSettings"u8);
                if (WorkspaceSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConnectionMonitorWorkspaceSettings>)WorkspaceSettings).Serialize(writer, options);
                }
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

        internal static ConnectionMonitorOutput DeserializeConnectionMonitorOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OutputType> type = default;
            Optional<ConnectionMonitorWorkspaceSettings> workspaceSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workspaceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceSettings = ConnectionMonitorWorkspaceSettings.DeserializeConnectionMonitorWorkspaceSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectionMonitorOutput(Optional.ToNullable(type), workspaceSettings.Value, rawData);
        }

        ConnectionMonitorOutput IModelJsonSerializable<ConnectionMonitorOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectionMonitorOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectionMonitorOutput IModelSerializable<ConnectionMonitorOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectionMonitorOutput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectionMonitorOutput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectionMonitorOutput"/> to convert. </param>
        public static implicit operator RequestContent(ConnectionMonitorOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectionMonitorOutput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectionMonitorOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectionMonitorOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
