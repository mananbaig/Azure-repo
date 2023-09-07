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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseFollowerDatabaseDefinition : IUtf8JsonSerializable, IModelJsonSerializable<SynapseFollowerDatabaseDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseFollowerDatabaseDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseFollowerDatabaseDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseFollowerDatabaseDefinition>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("clusterResourceId"u8);
            writer.WriteStringValue(KustoPoolResourceId);
            writer.WritePropertyName("attachedDatabaseConfigurationName"u8);
            writer.WriteStringValue(AttachedDatabaseConfigurationName);
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

        internal static SynapseFollowerDatabaseDefinition DeserializeSynapseFollowerDatabaseDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier clusterResourceId = default;
            string attachedDatabaseConfigurationName = default;
            Optional<string> databaseName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterResourceId"u8))
                {
                    clusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attachedDatabaseConfigurationName"u8))
                {
                    attachedDatabaseConfigurationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseFollowerDatabaseDefinition(clusterResourceId, attachedDatabaseConfigurationName, databaseName.Value, serializedAdditionalRawData);
        }

        SynapseFollowerDatabaseDefinition IModelJsonSerializable<SynapseFollowerDatabaseDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseFollowerDatabaseDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseFollowerDatabaseDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseFollowerDatabaseDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseFollowerDatabaseDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseFollowerDatabaseDefinition IModelSerializable<SynapseFollowerDatabaseDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseFollowerDatabaseDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseFollowerDatabaseDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseFollowerDatabaseDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseFollowerDatabaseDefinition"/> to convert. </param>
        public static implicit operator RequestContent(SynapseFollowerDatabaseDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseFollowerDatabaseDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseFollowerDatabaseDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseFollowerDatabaseDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
