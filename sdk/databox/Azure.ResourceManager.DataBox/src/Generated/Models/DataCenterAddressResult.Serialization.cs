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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataCenterAddressResult : IUtf8JsonSerializable, IModelJsonSerializable<DataCenterAddressResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataCenterAddressResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataCenterAddressResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("datacenterAddressType"u8);
            writer.WriteStringValue(DataCenterAddressType.ToSerialString());
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

        internal static DataCenterAddressResult DeserializeDataCenterAddressResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("datacenterAddressType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatacenterAddressInstruction": return DataCenterAddressInstructionResult.DeserializeDataCenterAddressInstructionResult(element);
                    case "DatacenterAddressLocation": return DataCenterAddressLocationResult.DeserializeDataCenterAddressLocationResult(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataCenterAddressType dataCenterAddressType = default;
            Optional<IReadOnlyList<string>> supportedCarriersForReturnShipment = default;
            Optional<AzureLocation> dataCenterAzureLocation = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datacenterAddressType"u8))
                {
                    dataCenterAddressType = property.Value.GetString().ToDataCenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"u8))
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
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataCenterAzureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownDataCenterAddressResponse(dataCenterAddressType, Optional.ToList(supportedCarriersForReturnShipment), Optional.ToNullable(dataCenterAzureLocation), rawData);
        }

        DataCenterAddressResult IModelJsonSerializable<DataCenterAddressResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCenterAddressResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataCenterAddressResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataCenterAddressResult IModelSerializable<DataCenterAddressResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataCenterAddressResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataCenterAddressResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataCenterAddressResult"/> to convert. </param>
        public static implicit operator RequestContent(DataCenterAddressResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataCenterAddressResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataCenterAddressResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataCenterAddressResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
