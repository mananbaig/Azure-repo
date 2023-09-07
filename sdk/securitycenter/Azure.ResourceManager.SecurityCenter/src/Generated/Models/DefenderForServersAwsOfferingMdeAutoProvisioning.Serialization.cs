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
    public partial class DefenderForServersAwsOfferingMdeAutoProvisioning : IUtf8JsonSerializable, IModelJsonSerializable<DefenderForServersAwsOfferingMdeAutoProvisioning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderForServersAwsOfferingMdeAutoProvisioning>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderForServersAwsOfferingMdeAutoProvisioning>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOfferingMdeAutoProvisioning>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Configuration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Configuration.ToString()).RootElement);
#endif
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

        internal static DefenderForServersAwsOfferingMdeAutoProvisioning DeserializeDefenderForServersAwsOfferingMdeAutoProvisioning(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<BinaryData> configuration = default;
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
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderForServersAwsOfferingMdeAutoProvisioning(Optional.ToNullable(enabled), configuration.Value, serializedAdditionalRawData);
        }

        DefenderForServersAwsOfferingMdeAutoProvisioning IModelJsonSerializable<DefenderForServersAwsOfferingMdeAutoProvisioning>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOfferingMdeAutoProvisioning>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersAwsOfferingMdeAutoProvisioning(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderForServersAwsOfferingMdeAutoProvisioning>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOfferingMdeAutoProvisioning>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderForServersAwsOfferingMdeAutoProvisioning IModelSerializable<DefenderForServersAwsOfferingMdeAutoProvisioning>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOfferingMdeAutoProvisioning>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderForServersAwsOfferingMdeAutoProvisioning(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefenderForServersAwsOfferingMdeAutoProvisioning"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefenderForServersAwsOfferingMdeAutoProvisioning"/> to convert. </param>
        public static implicit operator RequestContent(DefenderForServersAwsOfferingMdeAutoProvisioning model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefenderForServersAwsOfferingMdeAutoProvisioning"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefenderForServersAwsOfferingMdeAutoProvisioning(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderForServersAwsOfferingMdeAutoProvisioning(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
