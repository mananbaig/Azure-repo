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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedServerDnsAliasAcquisition : IUtf8JsonSerializable, IModelJsonSerializable<ManagedServerDnsAliasAcquisition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedServerDnsAliasAcquisition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedServerDnsAliasAcquisition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServerDnsAliasAcquisition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("oldManagedServerDnsAliasResourceId"u8);
            writer.WriteStringValue(OldManagedServerDnsAliasResourceId);
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

        internal static ManagedServerDnsAliasAcquisition DeserializeManagedServerDnsAliasAcquisition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier oldManagedServerDnsAliasResourceId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oldManagedServerDnsAliasResourceId"u8))
                {
                    oldManagedServerDnsAliasResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedServerDnsAliasAcquisition(oldManagedServerDnsAliasResourceId, serializedAdditionalRawData);
        }

        ManagedServerDnsAliasAcquisition IModelJsonSerializable<ManagedServerDnsAliasAcquisition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServerDnsAliasAcquisition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServerDnsAliasAcquisition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedServerDnsAliasAcquisition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServerDnsAliasAcquisition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedServerDnsAliasAcquisition IModelSerializable<ManagedServerDnsAliasAcquisition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServerDnsAliasAcquisition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedServerDnsAliasAcquisition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedServerDnsAliasAcquisition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedServerDnsAliasAcquisition"/> to convert. </param>
        public static implicit operator RequestContent(ManagedServerDnsAliasAcquisition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedServerDnsAliasAcquisition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedServerDnsAliasAcquisition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedServerDnsAliasAcquisition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
