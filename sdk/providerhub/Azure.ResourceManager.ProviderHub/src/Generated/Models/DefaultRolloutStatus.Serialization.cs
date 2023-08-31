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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class DefaultRolloutStatus : IUtf8JsonSerializable, IModelJsonSerializable<DefaultRolloutStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefaultRolloutStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefaultRolloutStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefaultRolloutStatus>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NextTrafficRegion))
            {
                writer.WritePropertyName("nextTrafficRegion"u8);
                writer.WriteStringValue(NextTrafficRegion.Value.ToString());
            }
            if (Optional.IsDefined(NextTrafficRegionScheduledOn))
            {
                writer.WritePropertyName("nextTrafficRegionScheduledTime"u8);
                writer.WriteStringValue(NextTrafficRegionScheduledOn.Value, "O");
            }
            if (Optional.IsDefined(SubscriptionReregistrationResult))
            {
                writer.WritePropertyName("subscriptionReregistrationResult"u8);
                writer.WriteStringValue(SubscriptionReregistrationResult.Value.ToString());
            }
            if (Optional.IsCollectionDefined(CompletedRegions))
            {
                writer.WritePropertyName("completedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in CompletedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FailedOrSkippedRegions))
            {
                writer.WritePropertyName("failedOrSkippedRegions"u8);
                writer.WriteStartObject();
                foreach (var item in FailedOrSkippedRegions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ExtendedErrorInfo>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
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

        internal static DefaultRolloutStatus DeserializeDefaultRolloutStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TrafficRegionCategory> nextTrafficRegion = default;
            Optional<DateTimeOffset> nextTrafficRegionScheduledTime = default;
            Optional<SubscriptionReregistrationResult> subscriptionReregistrationResult = default;
            Optional<IList<AzureLocation>> completedRegions = default;
            Optional<IDictionary<string, ExtendedErrorInfo>> failedOrSkippedRegions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextTrafficRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTrafficRegion = new TrafficRegionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextTrafficRegionScheduledTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTrafficRegionScheduledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptionReregistrationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionReregistrationResult = new SubscriptionReregistrationResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    completedRegions = array;
                    continue;
                }
                if (property.NameEquals("failedOrSkippedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ExtendedErrorInfo> dictionary = new Dictionary<string, ExtendedErrorInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ExtendedErrorInfo.DeserializeExtendedErrorInfo(property0.Value));
                    }
                    failedOrSkippedRegions = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefaultRolloutStatus(Optional.ToList(completedRegions), Optional.ToDictionary(failedOrSkippedRegions), Optional.ToNullable(nextTrafficRegion), Optional.ToNullable(nextTrafficRegionScheduledTime), Optional.ToNullable(subscriptionReregistrationResult), rawData);
        }

        DefaultRolloutStatus IModelJsonSerializable<DefaultRolloutStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefaultRolloutStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefaultRolloutStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefaultRolloutStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefaultRolloutStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefaultRolloutStatus IModelSerializable<DefaultRolloutStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefaultRolloutStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefaultRolloutStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefaultRolloutStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefaultRolloutStatus"/> to convert. </param>
        public static implicit operator RequestContent(DefaultRolloutStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefaultRolloutStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefaultRolloutStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefaultRolloutStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
