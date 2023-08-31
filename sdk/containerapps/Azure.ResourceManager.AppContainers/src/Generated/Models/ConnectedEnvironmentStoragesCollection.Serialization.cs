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
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class ConnectedEnvironmentStoragesCollection : IUtf8JsonSerializable, IModelJsonSerializable<ConnectedEnvironmentStoragesCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectedEnvironmentStoragesCollection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectedEnvironmentStoragesCollection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerAppConnectedEnvironmentStorageData>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static ConnectedEnvironmentStoragesCollection DeserializeConnectedEnvironmentStoragesCollection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerAppConnectedEnvironmentStorageData> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ContainerAppConnectedEnvironmentStorageData> array = new List<ContainerAppConnectedEnvironmentStorageData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppConnectedEnvironmentStorageData.DeserializeContainerAppConnectedEnvironmentStorageData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectedEnvironmentStoragesCollection(value, rawData);
        }

        ConnectedEnvironmentStoragesCollection IModelJsonSerializable<ConnectedEnvironmentStoragesCollection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectedEnvironmentStoragesCollection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectedEnvironmentStoragesCollection>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectedEnvironmentStoragesCollection IModelSerializable<ConnectedEnvironmentStoragesCollection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectedEnvironmentStoragesCollection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectedEnvironmentStoragesCollection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectedEnvironmentStoragesCollection"/> to convert. </param>
        public static implicit operator RequestContent(ConnectedEnvironmentStoragesCollection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectedEnvironmentStoragesCollection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectedEnvironmentStoragesCollection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectedEnvironmentStoragesCollection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
