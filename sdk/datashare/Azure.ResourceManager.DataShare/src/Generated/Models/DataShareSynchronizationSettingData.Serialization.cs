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
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    public partial class DataShareSynchronizationSettingData : IUtf8JsonSerializable, IModelJsonSerializable<DataShareSynchronizationSettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataShareSynchronizationSettingData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataShareSynchronizationSettingData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataShareSynchronizationSettingData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static DataShareSynchronizationSettingData DeserializeDataShareSynchronizationSettingData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ScheduleBased": return ScheduledSynchronizationSetting.DeserializeScheduledSynchronizationSetting(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            SynchronizationSettingKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SynchronizationSettingKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataShareSynchronizationSettingData(id, name, type, systemData.Value, kind, serializedAdditionalRawData);
        }

        DataShareSynchronizationSettingData IModelJsonSerializable<DataShareSynchronizationSettingData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataShareSynchronizationSettingData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataShareSynchronizationSettingData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataShareSynchronizationSettingData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataShareSynchronizationSettingData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataShareSynchronizationSettingData IModelSerializable<DataShareSynchronizationSettingData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataShareSynchronizationSettingData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataShareSynchronizationSettingData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataShareSynchronizationSettingData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataShareSynchronizationSettingData"/> to convert. </param>
        public static implicit operator RequestContent(DataShareSynchronizationSettingData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataShareSynchronizationSettingData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataShareSynchronizationSettingData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataShareSynchronizationSettingData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
