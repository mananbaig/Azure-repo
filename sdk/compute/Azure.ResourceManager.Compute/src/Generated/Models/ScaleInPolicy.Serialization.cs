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
    public partial class ScaleInPolicy : IUtf8JsonSerializable, IModelJsonSerializable<ScaleInPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScaleInPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScaleInPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ForceDeletion))
            {
                writer.WritePropertyName("forceDeletion"u8);
                writer.WriteBooleanValue(ForceDeletion.Value);
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

        internal static ScaleInPolicy DeserializeScaleInPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<VirtualMachineScaleSetScaleInRule>> rules = default;
            Optional<bool> forceDeletion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineScaleSetScaleInRule> array = new List<VirtualMachineScaleSetScaleInRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VirtualMachineScaleSetScaleInRule(item.GetString()));
                    }
                    rules = array;
                    continue;
                }
                if (property.NameEquals("forceDeletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceDeletion = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScaleInPolicy(Optional.ToList(rules), Optional.ToNullable(forceDeletion), rawData);
        }

        ScaleInPolicy IModelJsonSerializable<ScaleInPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScaleInPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScaleInPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScaleInPolicy IModelSerializable<ScaleInPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScaleInPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScaleInPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScaleInPolicy"/> to convert. </param>
        public static implicit operator RequestContent(ScaleInPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScaleInPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScaleInPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScaleInPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
