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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class AddressValue : IUtf8JsonSerializable, IModelJsonSerializable<AddressValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AddressValue>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AddressValue>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressValue>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(HouseNumber))
            {
                writer.WritePropertyName("houseNumber"u8);
                writer.WriteStringValue(HouseNumber);
            }
            if (Optional.IsDefined(PoBox))
            {
                writer.WritePropertyName("poBox"u8);
                writer.WriteStringValue(PoBox);
            }
            if (Optional.IsDefined(Road))
            {
                writer.WritePropertyName("road"u8);
                writer.WriteStringValue(Road);
            }
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(PostalCode))
            {
                writer.WritePropertyName("postalCode"u8);
                writer.WriteStringValue(PostalCode);
            }
            if (Optional.IsDefined(CountryRegion))
            {
                writer.WritePropertyName("countryRegion"u8);
                writer.WriteStringValue(CountryRegion);
            }
            if (Optional.IsDefined(StreetAddress))
            {
                writer.WritePropertyName("streetAddress"u8);
                writer.WriteStringValue(StreetAddress);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(CityDistrict))
            {
                writer.WritePropertyName("cityDistrict"u8);
                writer.WriteStringValue(CityDistrict);
            }
            if (Optional.IsDefined(StateDistrict))
            {
                writer.WritePropertyName("stateDistrict"u8);
                writer.WriteStringValue(StateDistrict);
            }
            if (Optional.IsDefined(Suburb))
            {
                writer.WritePropertyName("suburb"u8);
                writer.WriteStringValue(Suburb);
            }
            if (Optional.IsDefined(House))
            {
                writer.WritePropertyName("house"u8);
                writer.WriteStringValue(House);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level);
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

        internal static AddressValue DeserializeAddressValue(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> houseNumber = default;
            Optional<string> poBox = default;
            Optional<string> road = default;
            Optional<string> city = default;
            Optional<string> state = default;
            Optional<string> postalCode = default;
            Optional<string> countryRegion = default;
            Optional<string> streetAddress = default;
            Optional<string> unit = default;
            Optional<string> cityDistrict = default;
            Optional<string> stateDistrict = default;
            Optional<string> suburb = default;
            Optional<string> house = default;
            Optional<string> level = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("houseNumber"u8))
                {
                    houseNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poBox"u8))
                {
                    poBox = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("road"u8))
                {
                    road = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryRegion"u8))
                {
                    countryRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress"u8))
                {
                    streetAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cityDistrict"u8))
                {
                    cityDistrict = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateDistrict"u8))
                {
                    stateDistrict = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suburb"u8))
                {
                    suburb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("house"u8))
                {
                    house = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AddressValue(houseNumber.Value, poBox.Value, road.Value, city.Value, state.Value, postalCode.Value, countryRegion.Value, streetAddress.Value, unit.Value, cityDistrict.Value, stateDistrict.Value, suburb.Value, house.Value, level.Value, serializedAdditionalRawData);
        }

        AddressValue IModelJsonSerializable<AddressValue>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressValue>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAddressValue(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AddressValue>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressValue>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AddressValue IModelSerializable<AddressValue>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AddressValue>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAddressValue(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AddressValue"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AddressValue"/> to convert. </param>
        public static implicit operator RequestContent(AddressValue model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AddressValue"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AddressValue(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAddressValue(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
