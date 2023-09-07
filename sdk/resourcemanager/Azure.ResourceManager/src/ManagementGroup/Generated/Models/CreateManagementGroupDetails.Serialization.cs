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
    public partial class CreateManagementGroupDetails : IUtf8JsonSerializable, IModelJsonSerializable<CreateManagementGroupDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CreateManagementGroupDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CreateManagementGroupDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateManagementGroupDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Parent))
            {
                writer.WritePropertyName("parent"u8);
                if (Parent is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagementGroupParentCreateOptions>)Parent).Serialize(writer, options);
                }
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

        internal static CreateManagementGroupDetails DeserializeCreateManagementGroupDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> version = default;
            Optional<DateTimeOffset> updatedTime = default;
            Optional<string> updatedBy = default;
            Optional<ManagementGroupParentCreateOptions> parent = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("updatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedBy"u8))
                {
                    updatedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parent = ManagementGroupParentCreateOptions.DeserializeManagementGroupParentCreateOptions(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CreateManagementGroupDetails(Optional.ToNullable(version), Optional.ToNullable(updatedTime), updatedBy.Value, parent.Value, serializedAdditionalRawData);
        }

        CreateManagementGroupDetails IModelJsonSerializable<CreateManagementGroupDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateManagementGroupDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateManagementGroupDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CreateManagementGroupDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateManagementGroupDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CreateManagementGroupDetails IModelSerializable<CreateManagementGroupDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CreateManagementGroupDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCreateManagementGroupDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CreateManagementGroupDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CreateManagementGroupDetails"/> to convert. </param>
        public static implicit operator RequestContent(CreateManagementGroupDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CreateManagementGroupDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CreateManagementGroupDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCreateManagementGroupDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
