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
using Azure.ResourceManager.PowerBIDedicated.Models;

namespace Azure.ResourceManager.PowerBIDedicated
{
    public partial class AutoScaleVCoreData : IUtf8JsonSerializable, IModelJsonSerializable<AutoScaleVCoreData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutoScaleVCoreData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutoScaleVCoreData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutoScaleVCoreData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            if (Sku is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AutoScaleVCoreSku>)Sku).Serialize(writer, options);
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                if (SystemData is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SystemData>)SystemData).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CapacityLimit))
            {
                writer.WritePropertyName("capacityLimit"u8);
                writer.WriteNumberValue(CapacityLimit.Value);
            }
            if (Optional.IsDefined(CapacityObjectId))
            {
                writer.WritePropertyName("capacityObjectId"u8);
                writer.WriteStringValue(CapacityObjectId);
            }
            writer.WriteEndObject();
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

        internal static AutoScaleVCoreData DeserializeAutoScaleVCoreData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutoScaleVCoreSku sku = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            AzureLocation location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<SystemData> systemData = default;
            Optional<int> capacityLimit = default;
            Optional<string> capacityObjectId = default;
            Optional<VCoreProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = AutoScaleVCoreSku.DeserializeAutoScaleVCoreSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("capacityLimit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacityLimit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("capacityObjectId"u8))
                        {
                            capacityObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VCoreProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutoScaleVCoreData(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), systemData.Value, sku, Optional.ToNullable(capacityLimit), capacityObjectId.Value, Optional.ToNullable(provisioningState), rawData);
        }

        AutoScaleVCoreData IModelJsonSerializable<AutoScaleVCoreData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutoScaleVCoreData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoScaleVCoreData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutoScaleVCoreData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutoScaleVCoreData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutoScaleVCoreData IModelSerializable<AutoScaleVCoreData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AutoScaleVCoreData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutoScaleVCoreData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutoScaleVCoreData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutoScaleVCoreData"/> to convert. </param>
        public static implicit operator RequestContent(AutoScaleVCoreData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutoScaleVCoreData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutoScaleVCoreData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutoScaleVCoreData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
