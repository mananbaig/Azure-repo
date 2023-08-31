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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactSchemaReference : IUtf8JsonSerializable, IModelJsonSerializable<EdifactSchemaReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdifactSchemaReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdifactSchemaReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("messageId"u8);
            writer.WriteStringValue(MessageId);
            writer.WritePropertyName("messageVersion"u8);
            writer.WriteStringValue(MessageVersion);
            writer.WritePropertyName("messageRelease"u8);
            writer.WriteStringValue(MessageRelease);
            if (Optional.IsDefined(SenderApplicationId))
            {
                writer.WritePropertyName("senderApplicationId"u8);
                writer.WriteStringValue(SenderApplicationId);
            }
            if (Optional.IsDefined(SenderApplicationQualifier))
            {
                writer.WritePropertyName("senderApplicationQualifier"u8);
                writer.WriteStringValue(SenderApplicationQualifier);
            }
            if (Optional.IsDefined(AssociationAssignedCode))
            {
                writer.WritePropertyName("associationAssignedCode"u8);
                writer.WriteStringValue(AssociationAssignedCode);
            }
            writer.WritePropertyName("schemaName"u8);
            writer.WriteStringValue(SchemaName);
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

        internal static EdifactSchemaReference DeserializeEdifactSchemaReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            string messageVersion = default;
            string messageRelease = default;
            Optional<string> senderApplicationId = default;
            Optional<string> senderApplicationQualifier = default;
            Optional<string> associationAssignedCode = default;
            string schemaName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageVersion"u8))
                {
                    messageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageRelease"u8))
                {
                    messageRelease = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderApplicationId"u8))
                {
                    senderApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderApplicationQualifier"u8))
                {
                    senderApplicationQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("associationAssignedCode"u8))
                {
                    associationAssignedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdifactSchemaReference(messageId, messageVersion, messageRelease, senderApplicationId.Value, senderApplicationQualifier.Value, associationAssignedCode.Value, schemaName, rawData);
        }

        EdifactSchemaReference IModelJsonSerializable<EdifactSchemaReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactSchemaReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdifactSchemaReference>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdifactSchemaReference IModelSerializable<EdifactSchemaReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdifactSchemaReference(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EdifactSchemaReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EdifactSchemaReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdifactSchemaReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
