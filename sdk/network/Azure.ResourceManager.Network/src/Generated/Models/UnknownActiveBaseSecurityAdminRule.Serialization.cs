// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class UnknownActiveBaseSecurityAdminRule : IUtf8JsonSerializable, IModelJsonSerializable<ActiveBaseSecurityAdminRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ActiveBaseSecurityAdminRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ActiveBaseSecurityAdminRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(CommitOn))
            {
                writer.WritePropertyName("commitTime"u8);
                writer.WriteStringValue(CommitOn.Value, "O");
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(ConfigurationDescription))
            {
                writer.WritePropertyName("configurationDescription"u8);
                writer.WriteStringValue(ConfigurationDescription);
            }
            if (Optional.IsDefined(RuleCollectionDescription))
            {
                writer.WritePropertyName("ruleCollectionDescription"u8);
                writer.WriteStringValue(RuleCollectionDescription);
            }
            if (Optional.IsCollectionDefined(RuleCollectionAppliesToGroups))
            {
                writer.WritePropertyName("ruleCollectionAppliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionAppliesToGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static ActiveBaseSecurityAdminRule DeserializeUnknownActiveBaseSecurityAdminRule(JsonElement element, ModelSerializerOptions options = default) => DeserializeActiveBaseSecurityAdminRule(element, options);

        ActiveBaseSecurityAdminRule IModelJsonSerializable<ActiveBaseSecurityAdminRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownActiveBaseSecurityAdminRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ActiveBaseSecurityAdminRule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ActiveBaseSecurityAdminRule IModelSerializable<ActiveBaseSecurityAdminRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeActiveBaseSecurityAdminRule(doc.RootElement, options);
        }
    }
}
