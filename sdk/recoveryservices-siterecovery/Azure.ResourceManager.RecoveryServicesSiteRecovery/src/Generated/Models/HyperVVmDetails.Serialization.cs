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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVVmDetails : IUtf8JsonSerializable, IModelJsonSerializable<HyperVVmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVVmDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVVmDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVVmDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceItemId))
            {
                writer.WritePropertyName("sourceItemId"u8);
                writer.WriteStringValue(SourceItemId);
            }
            if (Optional.IsDefined(Generation))
            {
                writer.WritePropertyName("generation"u8);
                writer.WriteStringValue(Generation);
            }
            if (Optional.IsDefined(OSDetails))
            {
                writer.WritePropertyName("osDetails"u8);
                if (OSDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryOSDetails>)OSDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(DiskDetails))
            {
                writer.WritePropertyName("diskDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DiskDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SiteRecoveryDiskDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HasPhysicalDisk))
            {
                writer.WritePropertyName("hasPhysicalDisk"u8);
                writer.WriteStringValue(HasPhysicalDisk.Value.ToString());
            }
            if (Optional.IsDefined(HasFibreChannelAdapter))
            {
                writer.WritePropertyName("hasFibreChannelAdapter"u8);
                writer.WriteStringValue(HasFibreChannelAdapter.Value.ToString());
            }
            if (Optional.IsDefined(HasSharedVhd))
            {
                writer.WritePropertyName("hasSharedVhd"u8);
                writer.WriteStringValue(HasSharedVhd.Value.ToString());
            }
            if (Optional.IsDefined(HyperVHostId))
            {
                writer.WritePropertyName("hyperVHostId"u8);
                writer.WriteStringValue(HyperVHostId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static HyperVVmDetails DeserializeHyperVVmDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "VmmVirtualMachine": return VmmVmDetails.DeserializeVmmVmDetails(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<string> sourceItemId = default;
            Optional<string> generation = default;
            Optional<SiteRecoveryOSDetails> osDetails = default;
            Optional<IReadOnlyList<SiteRecoveryDiskDetails>> diskDetails = default;
            Optional<HyperVVmDiskPresenceStatus> hasPhysicalDisk = default;
            Optional<HyperVVmDiskPresenceStatus> hasFibreChannelAdapter = default;
            Optional<HyperVVmDiskPresenceStatus> hasSharedVhd = default;
            Optional<string> hyperVHostId = default;
            string instanceType = "HyperVVirtualMachine";
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceItemId"u8))
                {
                    sourceItemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generation"u8))
                {
                    generation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDetails = SiteRecoveryOSDetails.DeserializeSiteRecoveryOSDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("diskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDiskDetails> array = new List<SiteRecoveryDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDiskDetails.DeserializeSiteRecoveryDiskDetails(item));
                    }
                    diskDetails = array;
                    continue;
                }
                if (property.NameEquals("hasPhysicalDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasPhysicalDisk = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hasFibreChannelAdapter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasFibreChannelAdapter = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hasSharedVhd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasSharedVhd = new HyperVVmDiskPresenceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hyperVHostId"u8))
                {
                    hyperVHostId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HyperVVmDetails(instanceType, sourceItemId.Value, generation.Value, osDetails.Value, Optional.ToList(diskDetails), Optional.ToNullable(hasPhysicalDisk), Optional.ToNullable(hasFibreChannelAdapter), Optional.ToNullable(hasSharedVhd), hyperVHostId.Value, serializedAdditionalRawData);
        }

        HyperVVmDetails IModelJsonSerializable<HyperVVmDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVVmDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVVmDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVVmDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVVmDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVVmDetails IModelSerializable<HyperVVmDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HyperVVmDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVVmDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HyperVVmDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HyperVVmDetails"/> to convert. </param>
        public static implicit operator RequestContent(HyperVVmDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HyperVVmDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HyperVVmDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVVmDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
