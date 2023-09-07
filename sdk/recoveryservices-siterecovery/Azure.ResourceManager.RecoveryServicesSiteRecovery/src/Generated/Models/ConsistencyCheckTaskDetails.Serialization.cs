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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ConsistencyCheckTaskDetails : IUtf8JsonSerializable, IModelJsonSerializable<ConsistencyCheckTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConsistencyCheckTaskDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConsistencyCheckTaskDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsistencyCheckTaskDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VmDetails))
            {
                writer.WritePropertyName("vmDetails"u8);
                writer.WriteStartArray();
                foreach (var item in VmDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<InconsistentVmDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static ConsistencyCheckTaskDetails DeserializeConsistencyCheckTaskDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<InconsistentVmDetails>> vmDetails = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InconsistentVmDetails> array = new List<InconsistentVmDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InconsistentVmDetails.DeserializeInconsistentVmDetails(item));
                    }
                    vmDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConsistencyCheckTaskDetails(instanceType, Optional.ToList(vmDetails), serializedAdditionalRawData);
        }

        ConsistencyCheckTaskDetails IModelJsonSerializable<ConsistencyCheckTaskDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsistencyCheckTaskDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConsistencyCheckTaskDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConsistencyCheckTaskDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsistencyCheckTaskDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConsistencyCheckTaskDetails IModelSerializable<ConsistencyCheckTaskDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConsistencyCheckTaskDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConsistencyCheckTaskDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConsistencyCheckTaskDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConsistencyCheckTaskDetails"/> to convert. </param>
        public static implicit operator RequestContent(ConsistencyCheckTaskDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConsistencyCheckTaskDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConsistencyCheckTaskDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConsistencyCheckTaskDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
