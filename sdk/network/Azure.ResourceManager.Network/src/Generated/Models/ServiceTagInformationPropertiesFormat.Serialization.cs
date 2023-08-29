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
    public partial class ServiceTagInformationPropertiesFormat : IUtf8JsonSerializable, IModelJsonSerializable<ServiceTagInformationPropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceTagInformationPropertiesFormat>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceTagInformationPropertiesFormat>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static ServiceTagInformationPropertiesFormat DeserializeServiceTagInformationPropertiesFormat(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> changeNumber = default;
            Optional<string> region = default;
            Optional<string> systemService = default;
            Optional<IReadOnlyList<string>> addressPrefixes = default;
            Optional<string> state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changeNumber"u8))
                {
                    changeNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemService"u8))
                {
                    systemService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressPrefixes"u8))
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
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceTagInformationPropertiesFormat(changeNumber.Value, region.Value, systemService.Value, Optional.ToList(addressPrefixes), state.Value, rawData);
        }

        ServiceTagInformationPropertiesFormat IModelJsonSerializable<ServiceTagInformationPropertiesFormat>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceTagInformationPropertiesFormat(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceTagInformationPropertiesFormat>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceTagInformationPropertiesFormat IModelSerializable<ServiceTagInformationPropertiesFormat>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceTagInformationPropertiesFormat(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ServiceTagInformationPropertiesFormat model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ServiceTagInformationPropertiesFormat(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceTagInformationPropertiesFormat(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
