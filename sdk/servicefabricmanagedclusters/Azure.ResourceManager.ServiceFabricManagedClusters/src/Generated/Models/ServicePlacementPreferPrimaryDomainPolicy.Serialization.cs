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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServicePlacementPreferPrimaryDomainPolicy : IUtf8JsonSerializable, IModelJsonSerializable<ServicePlacementPreferPrimaryDomainPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServicePlacementPreferPrimaryDomainPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServicePlacementPreferPrimaryDomainPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPreferPrimaryDomainPolicy>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ServicePlacementPolicyType.ToString());
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

        internal static ServicePlacementPreferPrimaryDomainPolicy DeserializeServicePlacementPreferPrimaryDomainPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            ServicePlacementPolicyType type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServicePlacementPreferPrimaryDomainPolicy(type, domainName, serializedAdditionalRawData);
        }

        ServicePlacementPreferPrimaryDomainPolicy IModelJsonSerializable<ServicePlacementPreferPrimaryDomainPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPreferPrimaryDomainPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServicePlacementPreferPrimaryDomainPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServicePlacementPreferPrimaryDomainPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPreferPrimaryDomainPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServicePlacementPreferPrimaryDomainPolicy IModelSerializable<ServicePlacementPreferPrimaryDomainPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServicePlacementPreferPrimaryDomainPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServicePlacementPreferPrimaryDomainPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServicePlacementPreferPrimaryDomainPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServicePlacementPreferPrimaryDomainPolicy"/> to convert. </param>
        public static implicit operator RequestContent(ServicePlacementPreferPrimaryDomainPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServicePlacementPreferPrimaryDomainPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServicePlacementPreferPrimaryDomainPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServicePlacementPreferPrimaryDomainPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
