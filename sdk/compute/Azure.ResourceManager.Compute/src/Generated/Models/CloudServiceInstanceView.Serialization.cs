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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CloudServiceInstanceView : IUtf8JsonSerializable, IModelJsonSerializable<CloudServiceInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudServiceInstanceView>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudServiceInstanceView>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RoleInstance))
            {
                writer.WritePropertyName("roleInstance"u8);
                writer.WriteObjectValue(RoleInstance);
            }
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

        internal static CloudServiceInstanceView DeserializeCloudServiceInstanceView(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<InstanceViewStatusesSummary> roleInstance = default;
            Optional<string> sdkVersion = default;
            Optional<IReadOnlyList<string>> privateIds = default;
            Optional<IReadOnlyList<ResourceInstanceViewStatus>> statuses = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("roleInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    roleInstance = InstanceViewStatusesSummary.DeserializeInstanceViewStatusesSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("sdkVersion"u8))
                {
                    sdkVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    privateIds = array;
                    continue;
                }
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceInstanceViewStatus> array = new List<ResourceInstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceInstanceViewStatus.DeserializeResourceInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudServiceInstanceView(roleInstance.Value, sdkVersion.Value, Optional.ToList(privateIds), Optional.ToList(statuses), rawData);
        }

        CloudServiceInstanceView IModelJsonSerializable<CloudServiceInstanceView>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudServiceInstanceView(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudServiceInstanceView>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudServiceInstanceView IModelSerializable<CloudServiceInstanceView>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudServiceInstanceView(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CloudServiceInstanceView model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CloudServiceInstanceView(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudServiceInstanceView(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
