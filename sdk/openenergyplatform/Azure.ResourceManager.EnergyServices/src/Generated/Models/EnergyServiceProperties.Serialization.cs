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

namespace Azure.ResourceManager.EnergyServices.Models
{
    public partial class EnergyServiceProperties : IUtf8JsonSerializable, IModelJsonSerializable<EnergyServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EnergyServiceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EnergyServiceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthAppId))
            {
                writer.WritePropertyName("authAppId"u8);
                writer.WriteStringValue(AuthAppId);
            }
            if (Optional.IsCollectionDefined(DataPartitionNames))
            {
                writer.WritePropertyName("dataPartitionNames"u8);
                writer.WriteStartArray();
                foreach (var item in DataPartitionNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static EnergyServiceProperties DeserializeEnergyServiceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> dnsName = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> authAppId = default;
            Optional<IList<DataPartitionName>> dataPartitionNames = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsName"u8))
                {
                    dnsName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authAppId"u8))
                {
                    authAppId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPartitionNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataPartitionName> array = new List<DataPartitionName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPartitionName.DeserializeDataPartitionName(item));
                    }
                    dataPartitionNames = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EnergyServiceProperties(dnsName.Value, Optional.ToNullable(provisioningState), authAppId.Value, Optional.ToList(dataPartitionNames), rawData);
        }

        EnergyServiceProperties IModelJsonSerializable<EnergyServiceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEnergyServiceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EnergyServiceProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EnergyServiceProperties IModelSerializable<EnergyServiceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEnergyServiceProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EnergyServiceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EnergyServiceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEnergyServiceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
