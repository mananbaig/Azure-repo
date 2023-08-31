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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfile : IUtf8JsonSerializable, IModelJsonSerializable<ManagedClusterSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedClusterSecurityProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedClusterSecurityProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Defender))
            {
                writer.WritePropertyName("defender"u8);
                writer.WriteObjectValue(Defender);
            }
            if (Optional.IsDefined(AzureKeyVaultKms))
            {
                writer.WritePropertyName("azureKeyVaultKms"u8);
                writer.WriteObjectValue(AzureKeyVaultKms);
            }
            if (Optional.IsDefined(WorkloadIdentity))
            {
                writer.WritePropertyName("workloadIdentity"u8);
                writer.WriteObjectValue(WorkloadIdentity);
            }
            if (Optional.IsDefined(ImageCleaner))
            {
                writer.WritePropertyName("imageCleaner"u8);
                writer.WriteObjectValue(ImageCleaner);
            }
            if (Optional.IsDefined(NodeRestriction))
            {
                writer.WritePropertyName("nodeRestriction"u8);
                writer.WriteObjectValue(NodeRestriction);
            }
            if (Optional.IsCollectionDefined(CustomCATrustCertificates))
            {
                writer.WritePropertyName("customCATrustCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in CustomCATrustCertificates)
                {
                    writer.WriteBase64StringValue(item, "D");
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

        internal static ManagedClusterSecurityProfile DeserializeManagedClusterSecurityProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedClusterSecurityProfileDefender> defender = default;
            Optional<ManagedClusterSecurityProfileKeyVaultKms> azureKeyVaultKms = default;
            Optional<ManagedClusterSecurityProfileWorkloadIdentity> workloadIdentity = default;
            Optional<ManagedClusterSecurityProfileImageCleaner> imageCleaner = default;
            Optional<ManagedClusterSecurityProfileNodeRestriction> nodeRestriction = default;
            Optional<IList<byte[]>> customCATrustCertificates = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defender"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defender = ManagedClusterSecurityProfileDefender.DeserializeManagedClusterSecurityProfileDefender(property.Value);
                    continue;
                }
                if (property.NameEquals("azureKeyVaultKms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureKeyVaultKms = ManagedClusterSecurityProfileKeyVaultKms.DeserializeManagedClusterSecurityProfileKeyVaultKms(property.Value);
                    continue;
                }
                if (property.NameEquals("workloadIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadIdentity = ManagedClusterSecurityProfileWorkloadIdentity.DeserializeManagedClusterSecurityProfileWorkloadIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("imageCleaner"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageCleaner = ManagedClusterSecurityProfileImageCleaner.DeserializeManagedClusterSecurityProfileImageCleaner(property.Value);
                    continue;
                }
                if (property.NameEquals("nodeRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeRestriction = ManagedClusterSecurityProfileNodeRestriction.DeserializeManagedClusterSecurityProfileNodeRestriction(property.Value);
                    continue;
                }
                if (property.NameEquals("customCATrustCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<byte[]> array = new List<byte[]>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetBytesFromBase64("D"));
                    }
                    customCATrustCertificates = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedClusterSecurityProfile(defender.Value, azureKeyVaultKms.Value, workloadIdentity.Value, imageCleaner.Value, nodeRestriction.Value, Optional.ToList(customCATrustCertificates), rawData);
        }

        ManagedClusterSecurityProfile IModelJsonSerializable<ManagedClusterSecurityProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedClusterSecurityProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedClusterSecurityProfile IModelSerializable<ManagedClusterSecurityProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedClusterSecurityProfile(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManagedClusterSecurityProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManagedClusterSecurityProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedClusterSecurityProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
