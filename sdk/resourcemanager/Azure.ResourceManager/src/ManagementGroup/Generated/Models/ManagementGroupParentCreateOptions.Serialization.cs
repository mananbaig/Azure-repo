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

namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class ManagementGroupParentCreateOptions : IUtf8JsonSerializable, IModelJsonSerializable<ManagementGroupParentCreateOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagementGroupParentCreateOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagementGroupParentCreateOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupParentCreateOptions>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static ManagementGroupParentCreateOptions DeserializeManagementGroupParentCreateOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> displayName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagementGroupParentCreateOptions(id.Value, name.Value, displayName.Value, serializedAdditionalRawData);
        }

        ManagementGroupParentCreateOptions IModelJsonSerializable<ManagementGroupParentCreateOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupParentCreateOptions>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementGroupParentCreateOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagementGroupParentCreateOptions>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupParentCreateOptions>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagementGroupParentCreateOptions IModelSerializable<ManagementGroupParentCreateOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupParentCreateOptions>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagementGroupParentCreateOptions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagementGroupParentCreateOptions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagementGroupParentCreateOptions"/> to convert. </param>
        public static implicit operator RequestContent(ManagementGroupParentCreateOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagementGroupParentCreateOptions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagementGroupParentCreateOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagementGroupParentCreateOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
