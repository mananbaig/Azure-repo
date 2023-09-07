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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class DefenderForContainersAwsOfferingCloudWatchToKinesis : IUtf8JsonSerializable, IModelJsonSerializable<DefenderForContainersAwsOfferingCloudWatchToKinesis>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderForContainersAwsOfferingCloudWatchToKinesis>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForContainersAwsOfferingCloudWatchToKinesis>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
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

        internal static DefenderForContainersAwsOfferingCloudWatchToKinesis DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cloudRoleArn = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderForContainersAwsOfferingCloudWatchToKinesis(cloudRoleArn.Value, serializedAdditionalRawData);
        }

        DefenderForContainersAwsOfferingCloudWatchToKinesis IModelJsonSerializable<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForContainersAwsOfferingCloudWatchToKinesis>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForContainersAwsOfferingCloudWatchToKinesis>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderForContainersAwsOfferingCloudWatchToKinesis IModelSerializable<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefenderForContainersAwsOfferingCloudWatchToKinesis>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefenderForContainersAwsOfferingCloudWatchToKinesis"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefenderForContainersAwsOfferingCloudWatchToKinesis"/> to convert. </param>
        public static implicit operator RequestContent(DefenderForContainersAwsOfferingCloudWatchToKinesis model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefenderForContainersAwsOfferingCloudWatchToKinesis"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefenderForContainersAwsOfferingCloudWatchToKinesis(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
