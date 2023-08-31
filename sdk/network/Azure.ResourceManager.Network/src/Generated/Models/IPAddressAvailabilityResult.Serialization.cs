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
    public partial class IPAddressAvailabilityResult : IUtf8JsonSerializable, IModelJsonSerializable<IPAddressAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IPAddressAvailabilityResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IPAddressAvailabilityResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Available))
            {
                writer.WritePropertyName("available"u8);
                writer.WriteBooleanValue(Available.Value);
            }
            if (Optional.IsCollectionDefined(AvailableIPAddresses))
            {
                writer.WritePropertyName("availableIPAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableIPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPlatformReserved))
            {
                writer.WritePropertyName("isPlatformReserved"u8);
                writer.WriteBooleanValue(IsPlatformReserved.Value);
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

        internal static IPAddressAvailabilityResult DeserializeIPAddressAvailabilityResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> available = default;
            Optional<IReadOnlyList<string>> availableIPAddresses = default;
            Optional<bool> isPlatformReserved = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("available"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    available = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("availableIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availableIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("isPlatformReserved"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPlatformReserved = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IPAddressAvailabilityResult(Optional.ToNullable(available), Optional.ToList(availableIPAddresses), Optional.ToNullable(isPlatformReserved), rawData);
        }

        IPAddressAvailabilityResult IModelJsonSerializable<IPAddressAvailabilityResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIPAddressAvailabilityResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IPAddressAvailabilityResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IPAddressAvailabilityResult IModelSerializable<IPAddressAvailabilityResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIPAddressAvailabilityResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IPAddressAvailabilityResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IPAddressAvailabilityResult"/> to convert. </param>
        public static implicit operator RequestContent(IPAddressAvailabilityResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IPAddressAvailabilityResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IPAddressAvailabilityResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIPAddressAvailabilityResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
