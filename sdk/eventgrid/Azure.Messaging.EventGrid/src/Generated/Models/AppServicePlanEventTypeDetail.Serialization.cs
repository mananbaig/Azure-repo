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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AppServicePlanEventTypeDetail : IUtf8JsonSerializable, IModelJsonSerializable<AppServicePlanEventTypeDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServicePlanEventTypeDetail>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServicePlanEventTypeDetail>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServicePlanEventTypeDetail>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StampKind))
            {
                writer.WritePropertyName("stampKind"u8);
                writer.WriteStringValue(StampKind.Value.ToString());
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        internal static AppServicePlanEventTypeDetail DeserializeAppServicePlanEventTypeDetail(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StampKind> stampKind = default;
            Optional<AppServicePlanAction> action = default;
            Optional<AsyncStatus> status = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stampKind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stampKind = new StampKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new AppServicePlanAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AsyncStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServicePlanEventTypeDetail(Optional.ToNullable(stampKind), Optional.ToNullable(action), Optional.ToNullable(status), serializedAdditionalRawData);
        }

        AppServicePlanEventTypeDetail IModelJsonSerializable<AppServicePlanEventTypeDetail>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServicePlanEventTypeDetail>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServicePlanEventTypeDetail(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServicePlanEventTypeDetail>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServicePlanEventTypeDetail>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServicePlanEventTypeDetail IModelSerializable<AppServicePlanEventTypeDetail>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServicePlanEventTypeDetail>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServicePlanEventTypeDetail(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServicePlanEventTypeDetail"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServicePlanEventTypeDetail"/> to convert. </param>
        public static implicit operator RequestContent(AppServicePlanEventTypeDetail model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServicePlanEventTypeDetail"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServicePlanEventTypeDetail(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServicePlanEventTypeDetail(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
