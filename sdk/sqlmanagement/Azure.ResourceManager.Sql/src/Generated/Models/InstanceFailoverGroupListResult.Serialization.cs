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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class InstanceFailoverGroupListResult : IUtf8JsonSerializable, IModelJsonSerializable<InstanceFailoverGroupListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InstanceFailoverGroupListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InstanceFailoverGroupListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstanceFailoverGroupListResult>(this, options.Format);

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

        internal static InstanceFailoverGroupListResult DeserializeInstanceFailoverGroupListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<InstanceFailoverGroupData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstanceFailoverGroupData> array = new List<InstanceFailoverGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InstanceFailoverGroupListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        InstanceFailoverGroupListResult IModelJsonSerializable<InstanceFailoverGroupListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstanceFailoverGroupListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInstanceFailoverGroupListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InstanceFailoverGroupListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstanceFailoverGroupListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InstanceFailoverGroupListResult IModelSerializable<InstanceFailoverGroupListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstanceFailoverGroupListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInstanceFailoverGroupListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InstanceFailoverGroupListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InstanceFailoverGroupListResult"/> to convert. </param>
        public static implicit operator RequestContent(InstanceFailoverGroupListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InstanceFailoverGroupListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InstanceFailoverGroupListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInstanceFailoverGroupListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
