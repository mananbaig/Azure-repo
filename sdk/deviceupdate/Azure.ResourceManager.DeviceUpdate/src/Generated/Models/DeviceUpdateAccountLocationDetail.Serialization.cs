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

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class DeviceUpdateAccountLocationDetail : IUtf8JsonSerializable, IModelJsonSerializable<DeviceUpdateAccountLocationDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeviceUpdateAccountLocationDetail>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeviceUpdateAccountLocationDetail>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateAccountLocationDetail>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToString());
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

        internal static DeviceUpdateAccountLocationDetail DeserializeDeviceUpdateAccountLocationDetail(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<DeviceUpdateAccountLocationRole> role = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = new DeviceUpdateAccountLocationRole(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeviceUpdateAccountLocationDetail(name.Value, Optional.ToNullable(role), serializedAdditionalRawData);
        }

        DeviceUpdateAccountLocationDetail IModelJsonSerializable<DeviceUpdateAccountLocationDetail>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateAccountLocationDetail>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdateAccountLocationDetail(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeviceUpdateAccountLocationDetail>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateAccountLocationDetail>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeviceUpdateAccountLocationDetail IModelSerializable<DeviceUpdateAccountLocationDetail>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceUpdateAccountLocationDetail>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeviceUpdateAccountLocationDetail(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeviceUpdateAccountLocationDetail"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeviceUpdateAccountLocationDetail"/> to convert. </param>
        public static implicit operator RequestContent(DeviceUpdateAccountLocationDetail model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeviceUpdateAccountLocationDetail"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeviceUpdateAccountLocationDetail(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeviceUpdateAccountLocationDetail(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
