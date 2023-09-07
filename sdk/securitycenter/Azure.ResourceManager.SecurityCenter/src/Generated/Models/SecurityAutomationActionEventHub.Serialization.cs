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
    public partial class SecurityAutomationActionEventHub : IUtf8JsonSerializable, IModelJsonSerializable<SecurityAutomationActionEventHub>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityAutomationActionEventHub>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityAutomationActionEventHub>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityAutomationActionEventHub>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EventHubResourceId))
            {
                writer.WritePropertyName("eventHubResourceId"u8);
                writer.WriteStringValue(EventHubResourceId);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        internal static SecurityAutomationActionEventHub DeserializeSecurityAutomationActionEventHub(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> eventHubResourceId = default;
            Optional<string> sasPolicyName = default;
            Optional<string> connectionString = default;
            ActionType actionType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHubResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventHubResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasPolicyName"u8))
                {
                    sasPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionString"u8))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityAutomationActionEventHub(actionType, eventHubResourceId.Value, sasPolicyName.Value, connectionString.Value, serializedAdditionalRawData);
        }

        SecurityAutomationActionEventHub IModelJsonSerializable<SecurityAutomationActionEventHub>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityAutomationActionEventHub>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAutomationActionEventHub(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityAutomationActionEventHub>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityAutomationActionEventHub>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityAutomationActionEventHub IModelSerializable<SecurityAutomationActionEventHub>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityAutomationActionEventHub>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityAutomationActionEventHub(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityAutomationActionEventHub"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityAutomationActionEventHub"/> to convert. </param>
        public static implicit operator RequestContent(SecurityAutomationActionEventHub model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityAutomationActionEventHub"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityAutomationActionEventHub(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityAutomationActionEventHub(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
