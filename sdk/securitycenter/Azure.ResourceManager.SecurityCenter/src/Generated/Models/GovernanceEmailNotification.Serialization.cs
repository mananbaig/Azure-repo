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
    public partial class GovernanceEmailNotification : IUtf8JsonSerializable, IModelJsonSerializable<GovernanceEmailNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GovernanceEmailNotification>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GovernanceEmailNotification>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GovernanceEmailNotification>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsManagerEmailNotificationDisabled))
            {
                writer.WritePropertyName("disableManagerEmailNotification"u8);
                writer.WriteBooleanValue(IsManagerEmailNotificationDisabled.Value);
            }
            if (Optional.IsDefined(IsOwnerEmailNotificationDisabled))
            {
                writer.WritePropertyName("disableOwnerEmailNotification"u8);
                writer.WriteBooleanValue(IsOwnerEmailNotificationDisabled.Value);
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

        internal static GovernanceEmailNotification DeserializeGovernanceEmailNotification(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> disableManagerEmailNotification = default;
            Optional<bool> disableOwnerEmailNotification = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disableManagerEmailNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableManagerEmailNotification = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableOwnerEmailNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableOwnerEmailNotification = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GovernanceEmailNotification(Optional.ToNullable(disableManagerEmailNotification), Optional.ToNullable(disableOwnerEmailNotification), serializedAdditionalRawData);
        }

        GovernanceEmailNotification IModelJsonSerializable<GovernanceEmailNotification>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GovernanceEmailNotification>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGovernanceEmailNotification(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GovernanceEmailNotification>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GovernanceEmailNotification>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GovernanceEmailNotification IModelSerializable<GovernanceEmailNotification>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GovernanceEmailNotification>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGovernanceEmailNotification(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GovernanceEmailNotification"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GovernanceEmailNotification"/> to convert. </param>
        public static implicit operator RequestContent(GovernanceEmailNotification model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GovernanceEmailNotification"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GovernanceEmailNotification(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGovernanceEmailNotification(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
