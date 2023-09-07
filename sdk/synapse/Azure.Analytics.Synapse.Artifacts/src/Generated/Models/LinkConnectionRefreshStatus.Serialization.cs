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
    [JsonConverter(typeof(LinkConnectionRefreshStatusConverter))]
    public partial class LinkConnectionRefreshStatus : IUtf8JsonSerializable, IModelJsonSerializable<LinkConnectionRefreshStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkConnectionRefreshStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkConnectionRefreshStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionRefreshStatus>(this, options.Format);

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

        internal static LinkConnectionRefreshStatus DeserializeLinkConnectionRefreshStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> refreshStatus = default;
            Optional<string> errorMessage = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("refreshStatus"u8))
                {
                    refreshStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkConnectionRefreshStatus(refreshStatus.Value, errorMessage.Value, serializedAdditionalRawData);
        }

        LinkConnectionRefreshStatus IModelJsonSerializable<LinkConnectionRefreshStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionRefreshStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkConnectionRefreshStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkConnectionRefreshStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionRefreshStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkConnectionRefreshStatus IModelSerializable<LinkConnectionRefreshStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkConnectionRefreshStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkConnectionRefreshStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkConnectionRefreshStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkConnectionRefreshStatus"/> to convert. </param>
        public static implicit operator RequestContent(LinkConnectionRefreshStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkConnectionRefreshStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkConnectionRefreshStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkConnectionRefreshStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class LinkConnectionRefreshStatusConverter : JsonConverter<LinkConnectionRefreshStatus>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionRefreshStatus model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkConnectionRefreshStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionRefreshStatus(document.RootElement);
            }
        }
    }
}
