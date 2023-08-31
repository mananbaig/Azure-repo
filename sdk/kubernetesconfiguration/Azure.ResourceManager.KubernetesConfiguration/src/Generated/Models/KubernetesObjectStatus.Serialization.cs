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

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesObjectStatus : IUtf8JsonSerializable, IModelJsonSerializable<KubernetesObjectStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KubernetesObjectStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KubernetesObjectStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(ComplianceState))
            {
                writer.WritePropertyName("complianceState"u8);
                writer.WriteStringValue(ComplianceState.Value.ToString());
            }
            if (Optional.IsDefined(AppliedBy))
            {
                if (AppliedBy != null)
                {
                    writer.WritePropertyName("appliedBy"u8);
                    writer.WriteObjectValue(AppliedBy);
                }
                else
                {
                    writer.WriteNull("appliedBy");
                }
            }
            if (Optional.IsCollectionDefined(StatusConditions))
            {
                if (StatusConditions != null)
                {
                    writer.WritePropertyName("statusConditions"u8);
                    writer.WriteStartArray();
                    foreach (var item in StatusConditions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("statusConditions");
                }
            }
            if (Optional.IsDefined(HelmReleaseProperties))
            {
                if (HelmReleaseProperties != null)
                {
                    writer.WritePropertyName("helmReleaseProperties"u8);
                    writer.WriteObjectValue(HelmReleaseProperties);
                }
                else
                {
                    writer.WriteNull("helmReleaseProperties");
                }
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

        internal static KubernetesObjectStatus DeserializeKubernetesObjectStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> @namespace = default;
            Optional<string> kind = default;
            Optional<KubernetesFluxComplianceState> complianceState = default;
            Optional<KubernetesObjectReference> appliedBy = default;
            Optional<IReadOnlyList<KubernetesObjectStatusCondition>> statusConditions = default;
            Optional<HelmReleaseProperties> helmReleaseProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceState = new KubernetesFluxComplianceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appliedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appliedBy = null;
                        continue;
                    }
                    appliedBy = KubernetesObjectReference.DeserializeKubernetesObjectReference(property.Value);
                    continue;
                }
                if (property.NameEquals("statusConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusConditions = null;
                        continue;
                    }
                    List<KubernetesObjectStatusCondition> array = new List<KubernetesObjectStatusCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesObjectStatusCondition.DeserializeKubernetesObjectStatusCondition(item));
                    }
                    statusConditions = array;
                    continue;
                }
                if (property.NameEquals("helmReleaseProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        helmReleaseProperties = null;
                        continue;
                    }
                    helmReleaseProperties = HelmReleaseProperties.DeserializeHelmReleaseProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KubernetesObjectStatus(name.Value, @namespace.Value, kind.Value, Optional.ToNullable(complianceState), appliedBy.Value, Optional.ToList(statusConditions), helmReleaseProperties.Value, rawData);
        }

        KubernetesObjectStatus IModelJsonSerializable<KubernetesObjectStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesObjectStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KubernetesObjectStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KubernetesObjectStatus IModelSerializable<KubernetesObjectStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKubernetesObjectStatus(doc.RootElement, options);
        }

        public static implicit operator RequestContent(KubernetesObjectStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator KubernetesObjectStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKubernetesObjectStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
