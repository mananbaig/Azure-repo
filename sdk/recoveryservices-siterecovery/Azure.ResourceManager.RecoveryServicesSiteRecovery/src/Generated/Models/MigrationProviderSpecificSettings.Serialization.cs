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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class MigrationProviderSpecificSettings : IUtf8JsonSerializable, IModelJsonSerializable<MigrationProviderSpecificSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrationProviderSpecificSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrationProviderSpecificSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrationProviderSpecificSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static MigrationProviderSpecificSettings DeserializeMigrationProviderSpecificSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "VMwareCbt": return VMwareCbtMigrationDetails.DeserializeVMwareCbtMigrationDetails(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownMigrationProviderSpecificSettings(instanceType, serializedAdditionalRawData);
        }

        MigrationProviderSpecificSettings IModelJsonSerializable<MigrationProviderSpecificSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrationProviderSpecificSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationProviderSpecificSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrationProviderSpecificSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrationProviderSpecificSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrationProviderSpecificSettings IModelSerializable<MigrationProviderSpecificSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MigrationProviderSpecificSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrationProviderSpecificSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrationProviderSpecificSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrationProviderSpecificSettings"/> to convert. </param>
        public static implicit operator RequestContent(MigrationProviderSpecificSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrationProviderSpecificSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrationProviderSpecificSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrationProviderSpecificSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
