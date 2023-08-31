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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachinePublicIPAddressDnsSettingsConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<VirtualMachinePublicIPAddressDnsSettingsConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualMachinePublicIPAddressDnsSettingsConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("domainNameLabel"u8);
            writer.WriteStringValue(DomainNameLabel);
            if (Optional.IsDefined(DomainNameLabelScope))
            {
                writer.WritePropertyName("domainNameLabelScope"u8);
                writer.WriteStringValue(DomainNameLabelScope.Value.ToString());
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

        internal static VirtualMachinePublicIPAddressDnsSettingsConfiguration DeserializeVirtualMachinePublicIPAddressDnsSettingsConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainNameLabel = default;
            Optional<DomainNameLabelScopeType> domainNameLabelScope = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainNameLabel"u8))
                {
                    domainNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNameLabelScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainNameLabelScope = new DomainNameLabelScopeType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualMachinePublicIPAddressDnsSettingsConfiguration(domainNameLabel, Optional.ToNullable(domainNameLabelScope), rawData);
        }

        VirtualMachinePublicIPAddressDnsSettingsConfiguration IModelJsonSerializable<VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachinePublicIPAddressDnsSettingsConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualMachinePublicIPAddressDnsSettingsConfiguration IModelSerializable<VirtualMachinePublicIPAddressDnsSettingsConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualMachinePublicIPAddressDnsSettingsConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualMachinePublicIPAddressDnsSettingsConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualMachinePublicIPAddressDnsSettingsConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(VirtualMachinePublicIPAddressDnsSettingsConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualMachinePublicIPAddressDnsSettingsConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualMachinePublicIPAddressDnsSettingsConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualMachinePublicIPAddressDnsSettingsConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
