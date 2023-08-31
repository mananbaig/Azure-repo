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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ConnectorMappingCompleteOperation : IUtf8JsonSerializable, IModelJsonSerializable<ConnectorMappingCompleteOperation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectorMappingCompleteOperation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectorMappingCompleteOperation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CompletionOperationType))
            {
                writer.WritePropertyName("completionOperationType"u8);
                writer.WriteStringValue(CompletionOperationType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DestinationFolder))
            {
                writer.WritePropertyName("destinationFolder"u8);
                writer.WriteStringValue(DestinationFolder);
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

        internal static ConnectorMappingCompleteOperation DeserializeConnectorMappingCompleteOperation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CompletionOperationType> completionOperationType = default;
            Optional<string> destinationFolder = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completionOperationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completionOperationType = property.Value.GetString().ToCompletionOperationType();
                    continue;
                }
                if (property.NameEquals("destinationFolder"u8))
                {
                    destinationFolder = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectorMappingCompleteOperation(Optional.ToNullable(completionOperationType), destinationFolder.Value, rawData);
        }

        ConnectorMappingCompleteOperation IModelJsonSerializable<ConnectorMappingCompleteOperation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorMappingCompleteOperation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectorMappingCompleteOperation>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectorMappingCompleteOperation IModelSerializable<ConnectorMappingCompleteOperation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectorMappingCompleteOperation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectorMappingCompleteOperation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectorMappingCompleteOperation"/> to convert. </param>
        public static implicit operator RequestContent(ConnectorMappingCompleteOperation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectorMappingCompleteOperation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectorMappingCompleteOperation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectorMappingCompleteOperation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
