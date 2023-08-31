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
    internal partial class DedicatedHostAvailableCapacity : IUtf8JsonSerializable, IModelJsonSerializable<DedicatedHostAvailableCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DedicatedHostAvailableCapacity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DedicatedHostAvailableCapacity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllocatableVms))
            {
                writer.WritePropertyName("allocatableVMs"u8);
                writer.WriteStartArray();
                foreach (var item in AllocatableVms)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static DedicatedHostAvailableCapacity DeserializeDedicatedHostAvailableCapacity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DedicatedHostAllocatableVm>> allocatableVms = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocatableVMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DedicatedHostAllocatableVm> array = new List<DedicatedHostAllocatableVm>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHostAllocatableVm.DeserializeDedicatedHostAllocatableVm(item));
                    }
                    allocatableVms = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DedicatedHostAvailableCapacity(Optional.ToList(allocatableVms), rawData);
        }

        DedicatedHostAvailableCapacity IModelJsonSerializable<DedicatedHostAvailableCapacity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHostAvailableCapacity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DedicatedHostAvailableCapacity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DedicatedHostAvailableCapacity IModelSerializable<DedicatedHostAvailableCapacity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDedicatedHostAvailableCapacity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DedicatedHostAvailableCapacity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DedicatedHostAvailableCapacity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDedicatedHostAvailableCapacity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
