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

namespace Azure.ResourceManager.WebPubSub.Models
{
    internal partial class SignalRServiceUsageList : IUtf8JsonSerializable, IModelJsonSerializable<SignalRServiceUsageList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SignalRServiceUsageList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SignalRServiceUsageList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRServiceUsageList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SignalRServiceUsage>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static SignalRServiceUsageList DeserializeSignalRServiceUsageList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SignalRServiceUsage>> value = default;
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
                    List<SignalRServiceUsage> array = new List<SignalRServiceUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SignalRServiceUsage.DeserializeSignalRServiceUsage(item));
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
            return new SignalRServiceUsageList(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        SignalRServiceUsageList IModelJsonSerializable<SignalRServiceUsageList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRServiceUsageList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSignalRServiceUsageList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SignalRServiceUsageList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRServiceUsageList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SignalRServiceUsageList IModelSerializable<SignalRServiceUsageList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SignalRServiceUsageList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSignalRServiceUsageList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SignalRServiceUsageList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SignalRServiceUsageList"/> to convert. </param>
        public static implicit operator RequestContent(SignalRServiceUsageList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SignalRServiceUsageList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SignalRServiceUsageList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSignalRServiceUsageList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
