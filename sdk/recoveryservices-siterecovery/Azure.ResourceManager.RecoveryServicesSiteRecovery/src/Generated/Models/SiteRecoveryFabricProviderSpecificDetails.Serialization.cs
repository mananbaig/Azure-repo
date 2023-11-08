// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryFabricProviderSpecificDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryFabricProviderSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryFabricProviderSpecificDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SiteRecoveryFabricProviderSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(ContainerIds))
            {
                writer.WritePropertyName("containerIds"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExtendedLocations))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LocationDetails))
            {
                writer.WritePropertyName("locationDetails"u8);
                writer.WriteStartArray();
                foreach (var item in LocationDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SiteRecoveryFabricProviderSpecificDetails IJsonModel<SiteRecoveryFabricProviderSpecificDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryFabricProviderSpecificDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryFabricProviderSpecificDetails(document.RootElement, options);
        }

        internal static SiteRecoveryFabricProviderSpecificDetails DeserializeSiteRecoveryFabricProviderSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyList<ResourceIdentifier>> containerIds = default;
            Optional<IReadOnlyList<A2AZoneDetails>> zones = default;
            Optional<IReadOnlyList<A2AExtendedLocationDetails>> extendedLocations = default;
            Optional<IReadOnlyList<A2AFabricSpecificLocationDetails>> locationDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    containerIds = array;
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AZoneDetails> array = new List<A2AZoneDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AZoneDetails.DeserializeA2AZoneDetails(item));
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AExtendedLocationDetails> array = new List<A2AExtendedLocationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AExtendedLocationDetails.DeserializeA2AExtendedLocationDetails(item));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("locationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AFabricSpecificLocationDetails> array = new List<A2AFabricSpecificLocationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AFabricSpecificLocationDetails.DeserializeA2AFabricSpecificLocationDetails(item));
                    }
                    locationDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryFabricProviderSpecificDetails(instanceType, serializedAdditionalRawData, Optional.ToNullable(location), Optional.ToList(containerIds), Optional.ToList(zones), Optional.ToList(extendedLocations), Optional.ToList(locationDetails));
        }

        BinaryData IModel<SiteRecoveryFabricProviderSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryFabricProviderSpecificDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SiteRecoveryFabricProviderSpecificDetails IModel<SiteRecoveryFabricProviderSpecificDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryFabricProviderSpecificDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryFabricProviderSpecificDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SiteRecoveryFabricProviderSpecificDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
