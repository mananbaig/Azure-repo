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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricExternalNetworkPatch : IUtf8JsonSerializable, IModelJsonSerializable<NetworkFabricExternalNetworkPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkFabricExternalNetworkPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkFabricExternalNetworkPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(ImportRoutePolicyId))
            {
                writer.WritePropertyName("importRoutePolicyId"u8);
                writer.WriteStringValue(ImportRoutePolicyId);
            }
            if (Optional.IsDefined(ExportRoutePolicyId))
            {
                writer.WritePropertyName("exportRoutePolicyId"u8);
                writer.WriteStringValue(ExportRoutePolicyId);
            }
            if (Optional.IsDefined(ImportRoutePolicy))
            {
                writer.WritePropertyName("importRoutePolicy"u8);
                writer.WriteObjectValue(ImportRoutePolicy);
            }
            if (Optional.IsDefined(ExportRoutePolicy))
            {
                writer.WritePropertyName("exportRoutePolicy"u8);
                writer.WriteObjectValue(ExportRoutePolicy);
            }
            if (Optional.IsDefined(PeeringOption))
            {
                writer.WritePropertyName("peeringOption"u8);
                writer.WriteStringValue(PeeringOption.Value.ToString());
            }
            if (Optional.IsDefined(OptionBProperties))
            {
                writer.WritePropertyName("optionBProperties"u8);
                writer.WriteObjectValue(OptionBProperties);
            }
            if (Optional.IsDefined(OptionAProperties))
            {
                writer.WritePropertyName("optionAProperties"u8);
                writer.WriteObjectValue(OptionAProperties);
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

        internal static NetworkFabricExternalNetworkPatch DeserializeNetworkFabricExternalNetworkPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> annotation = default;
            Optional<ResourceIdentifier> importRoutePolicyId = default;
            Optional<ResourceIdentifier> exportRoutePolicyId = default;
            Optional<ImportRoutePolicy> importRoutePolicy = default;
            Optional<ExportRoutePolicy> exportRoutePolicy = default;
            Optional<PeeringOption> peeringOption = default;
            Optional<L3OptionBProperties> optionBProperties = default;
            Optional<ExternalNetworkPatchOptionAProperties> optionAProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicy = ImportRoutePolicy.DeserializeImportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicy = ExportRoutePolicy.DeserializeExportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peeringOption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peeringOption = new PeeringOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("optionBProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optionBProperties = L3OptionBProperties.DeserializeL3OptionBProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("optionAProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optionAProperties = ExternalNetworkPatchOptionAProperties.DeserializeExternalNetworkPatchOptionAProperties(property0.Value);
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
            return new NetworkFabricExternalNetworkPatch(annotation.Value, importRoutePolicyId.Value, exportRoutePolicyId.Value, importRoutePolicy.Value, exportRoutePolicy.Value, Optional.ToNullable(peeringOption), optionBProperties.Value, optionAProperties.Value, rawData);
        }

        NetworkFabricExternalNetworkPatch IModelJsonSerializable<NetworkFabricExternalNetworkPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricExternalNetworkPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkFabricExternalNetworkPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkFabricExternalNetworkPatch IModelSerializable<NetworkFabricExternalNetworkPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkFabricExternalNetworkPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkFabricExternalNetworkPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkFabricExternalNetworkPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkFabricExternalNetworkPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
