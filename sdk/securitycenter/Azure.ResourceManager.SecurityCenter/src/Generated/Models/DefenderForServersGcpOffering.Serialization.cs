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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersGcpOffering : IUtf8JsonSerializable, IModelJsonSerializable<DefenderForServersGcpOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderForServersGcpOffering>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderForServersGcpOffering>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersGcpOffering>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DefenderForServers))
            {
                writer.WritePropertyName("defenderForServers"u8);
                if (DefenderForServers is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GcpDefenderForServersInfo>)DefenderForServers).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                if (ArcAutoProvisioning is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersGcpOfferingArcAutoProvisioning>)ArcAutoProvisioning).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VulnerabilityAssessmentAutoProvisioning))
            {
                writer.WritePropertyName("vaAutoProvisioning"u8);
                if (VulnerabilityAssessmentAutoProvisioning is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning>)VulnerabilityAssessmentAutoProvisioning).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MdeAutoProvisioning))
            {
                writer.WritePropertyName("mdeAutoProvisioning"u8);
                if (MdeAutoProvisioning is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersGcpOfferingMdeAutoProvisioning>)MdeAutoProvisioning).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SubPlan))
            {
                writer.WritePropertyName("subPlan"u8);
                if (SubPlan is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersGcpOfferingSubPlan>)SubPlan).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
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

        internal static DefenderForServersGcpOffering DeserializeDefenderForServersGcpOffering(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GcpDefenderForServersInfo> defenderForServers = default;
            Optional<DefenderForServersGcpOfferingArcAutoProvisioning> arcAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning> vaAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingMdeAutoProvisioning> mdeAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingSubPlan> subPlan = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defenderForServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defenderForServers = GcpDefenderForServersInfo.DeserializeGcpDefenderForServersInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForServersGcpOfferingArcAutoProvisioning.DeserializeDefenderForServersGcpOfferingArcAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("vaAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaAutoProvisioning = DefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning.DeserializeDefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("mdeAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdeAutoProvisioning = DefenderForServersGcpOfferingMdeAutoProvisioning.DeserializeDefenderForServersGcpOfferingMdeAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("subPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subPlan = DefenderForServersGcpOfferingSubPlan.DeserializeDefenderForServersGcpOfferingSubPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderForServersGcpOffering(offeringType, description.Value, defenderForServers.Value, arcAutoProvisioning.Value, vaAutoProvisioning.Value, mdeAutoProvisioning.Value, subPlan.Value, serializedAdditionalRawData);
        }

        DefenderForServersGcpOffering IModelJsonSerializable<DefenderForServersGcpOffering>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersGcpOffering>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersGcpOffering(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderForServersGcpOffering>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersGcpOffering>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderForServersGcpOffering IModelSerializable<DefenderForServersGcpOffering>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersGcpOffering>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderForServersGcpOffering(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefenderForServersGcpOffering"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefenderForServersGcpOffering"/> to convert. </param>
        public static implicit operator RequestContent(DefenderForServersGcpOffering model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefenderForServersGcpOffering"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefenderForServersGcpOffering(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderForServersGcpOffering(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
