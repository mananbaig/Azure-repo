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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryPointRehydrationInfo : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryPointRehydrationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryPointRehydrationInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryPointRehydrationInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPointRehydrationInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RehydrationRetentionDuration))
            {
                writer.WritePropertyName("rehydrationRetentionDuration"u8);
                writer.WriteStringValue(RehydrationRetentionDuration.Value, "P");
            }
            if (Optional.IsDefined(RehydrationPriority))
            {
                writer.WritePropertyName("rehydrationPriority"u8);
                writer.WriteStringValue(RehydrationPriority.Value.ToString());
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

        internal static RecoveryPointRehydrationInfo DeserializeRecoveryPointRehydrationInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> rehydrationRetentionDuration = default;
            Optional<RehydrationPriority> rehydrationPriority = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rehydrationRetentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationRetentionDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationPriority = new RehydrationPriority(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecoveryPointRehydrationInfo(Optional.ToNullable(rehydrationRetentionDuration), Optional.ToNullable(rehydrationPriority), serializedAdditionalRawData);
        }

        RecoveryPointRehydrationInfo IModelJsonSerializable<RecoveryPointRehydrationInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPointRehydrationInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointRehydrationInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryPointRehydrationInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPointRehydrationInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryPointRehydrationInfo IModelSerializable<RecoveryPointRehydrationInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPointRehydrationInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryPointRehydrationInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecoveryPointRehydrationInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecoveryPointRehydrationInfo"/> to convert. </param>
        public static implicit operator RequestContent(RecoveryPointRehydrationInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecoveryPointRehydrationInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecoveryPointRehydrationInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryPointRehydrationInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
