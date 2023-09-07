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
    public partial class DefenderForDatabasesAwsOfferingRds : IUtf8JsonSerializable, IModelJsonSerializable<DefenderForDatabasesAwsOfferingRds>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderForDatabasesAwsOfferingRds>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderForDatabasesAwsOfferingRds>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForDatabasesAwsOfferingRds>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
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

        internal static DefenderForDatabasesAwsOfferingRds DeserializeDefenderForDatabasesAwsOfferingRds(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> cloudRoleArn = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderForDatabasesAwsOfferingRds(Optional.ToNullable(enabled), cloudRoleArn.Value, serializedAdditionalRawData);
        }

        DefenderForDatabasesAwsOfferingRds IModelJsonSerializable<DefenderForDatabasesAwsOfferingRds>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForDatabasesAwsOfferingRds>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForDatabasesAwsOfferingRds(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderForDatabasesAwsOfferingRds>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForDatabasesAwsOfferingRds>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderForDatabasesAwsOfferingRds IModelSerializable<DefenderForDatabasesAwsOfferingRds>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForDatabasesAwsOfferingRds>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderForDatabasesAwsOfferingRds(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefenderForDatabasesAwsOfferingRds"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefenderForDatabasesAwsOfferingRds"/> to convert. </param>
        public static implicit operator RequestContent(DefenderForDatabasesAwsOfferingRds model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefenderForDatabasesAwsOfferingRds"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefenderForDatabasesAwsOfferingRds(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderForDatabasesAwsOfferingRds(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
