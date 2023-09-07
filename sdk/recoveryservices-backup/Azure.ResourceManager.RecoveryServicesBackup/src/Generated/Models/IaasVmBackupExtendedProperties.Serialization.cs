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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmBackupExtendedProperties : IUtf8JsonSerializable, IModelJsonSerializable<IaasVmBackupExtendedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IaasVmBackupExtendedProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IaasVmBackupExtendedProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmBackupExtendedProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskExclusionProperties))
            {
                writer.WritePropertyName("diskExclusionProperties"u8);
                if (DiskExclusionProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DiskExclusionProperties>)DiskExclusionProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(LinuxVmApplicationName))
            {
                writer.WritePropertyName("linuxVmApplicationName"u8);
                writer.WriteStringValue(LinuxVmApplicationName);
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

        internal static IaasVmBackupExtendedProperties DeserializeIaasVmBackupExtendedProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DiskExclusionProperties> diskExclusionProperties = default;
            Optional<string> linuxVmApplicationName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskExclusionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskExclusionProperties = DiskExclusionProperties.DeserializeDiskExclusionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxVmApplicationName"u8))
                {
                    linuxVmApplicationName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IaasVmBackupExtendedProperties(diskExclusionProperties.Value, linuxVmApplicationName.Value, serializedAdditionalRawData);
        }

        IaasVmBackupExtendedProperties IModelJsonSerializable<IaasVmBackupExtendedProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmBackupExtendedProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmBackupExtendedProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IaasVmBackupExtendedProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmBackupExtendedProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IaasVmBackupExtendedProperties IModelSerializable<IaasVmBackupExtendedProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IaasVmBackupExtendedProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIaasVmBackupExtendedProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IaasVmBackupExtendedProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IaasVmBackupExtendedProperties"/> to convert. </param>
        public static implicit operator RequestContent(IaasVmBackupExtendedProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IaasVmBackupExtendedProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IaasVmBackupExtendedProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIaasVmBackupExtendedProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
