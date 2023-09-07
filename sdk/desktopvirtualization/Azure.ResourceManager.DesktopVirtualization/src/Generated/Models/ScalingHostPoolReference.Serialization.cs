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

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ScalingHostPoolReference : IUtf8JsonSerializable, IModelJsonSerializable<ScalingHostPoolReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScalingHostPoolReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScalingHostPoolReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScalingHostPoolReference>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(HostPoolId))
            {
                writer.WritePropertyName("hostPoolArmPath"u8);
                writer.WriteStringValue(HostPoolId);
            }
            if (Optional.IsDefined(IsScalingPlanEnabled))
            {
                writer.WritePropertyName("scalingPlanEnabled"u8);
                writer.WriteBooleanValue(IsScalingPlanEnabled.Value);
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

        internal static ScalingHostPoolReference DeserializeScalingHostPoolReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> hostPoolArmPath = default;
            Optional<bool> scalingPlanEnabled = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostPoolArmPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostPoolArmPath = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scalingPlanEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingPlanEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScalingHostPoolReference(hostPoolArmPath.Value, Optional.ToNullable(scalingPlanEnabled), serializedAdditionalRawData);
        }

        ScalingHostPoolReference IModelJsonSerializable<ScalingHostPoolReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScalingHostPoolReference>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingHostPoolReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScalingHostPoolReference>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScalingHostPoolReference>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScalingHostPoolReference IModelSerializable<ScalingHostPoolReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScalingHostPoolReference>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScalingHostPoolReference(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScalingHostPoolReference"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScalingHostPoolReference"/> to convert. </param>
        public static implicit operator RequestContent(ScalingHostPoolReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScalingHostPoolReference"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScalingHostPoolReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScalingHostPoolReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
