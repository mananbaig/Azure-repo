// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LibraryResourceInfoConverter))]
    public partial class LibraryResourceInfo : IUtf8JsonSerializable, IModelJsonSerializable<LibraryResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LibraryResourceInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LibraryResourceInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryResourceInfo>(this, options.Format);

            writer.WriteStartObject();
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

        internal static LibraryResourceInfo DeserializeLibraryResourceInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<int> recordId = default;
            Optional<string> state = default;
            Optional<string> created = default;
            Optional<string> changed = default;
            Optional<string> type = default;
            Optional<string> name = default;
            Optional<string> operationId = default;
            Optional<string> artifactId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    created = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changed"u8))
                {
                    changed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LibraryResourceInfo(id.Value, Optional.ToNullable(recordId), state.Value, created.Value, changed.Value, type.Value, name.Value, operationId.Value, artifactId.Value, serializedAdditionalRawData);
        }

        LibraryResourceInfo IModelJsonSerializable<LibraryResourceInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryResourceInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLibraryResourceInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LibraryResourceInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryResourceInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LibraryResourceInfo IModelSerializable<LibraryResourceInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LibraryResourceInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLibraryResourceInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LibraryResourceInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LibraryResourceInfo"/> to convert. </param>
        public static implicit operator RequestContent(LibraryResourceInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LibraryResourceInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LibraryResourceInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLibraryResourceInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class LibraryResourceInfoConverter : JsonConverter<LibraryResourceInfo>
        {
            public override void Write(Utf8JsonWriter writer, LibraryResourceInfo model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LibraryResourceInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryResourceInfo(document.RootElement);
            }
        }
    }
}
