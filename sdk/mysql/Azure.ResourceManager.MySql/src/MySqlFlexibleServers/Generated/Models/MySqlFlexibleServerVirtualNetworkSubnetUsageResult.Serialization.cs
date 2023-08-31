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

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerVirtualNetworkSubnetUsageResult : IUtf8JsonSerializable, IModelJsonSerializable<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static MySqlFlexibleServerVirtualNetworkSubnetUsageResult DeserializeMySqlFlexibleServerVirtualNetworkSubnetUsageResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<string> subscriptionId = default;
            Optional<IReadOnlyList<MySqlFlexibleServerDelegatedSubnetUsage>> delegatedSubnetsUsage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delegatedSubnetsUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerDelegatedSubnetUsage> array = new List<MySqlFlexibleServerDelegatedSubnetUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerDelegatedSubnetUsage.DeserializeMySqlFlexibleServerDelegatedSubnetUsage(item));
                    }
                    delegatedSubnetsUsage = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MySqlFlexibleServerVirtualNetworkSubnetUsageResult(Optional.ToNullable(location), subscriptionId.Value, Optional.ToList(delegatedSubnetsUsage), rawData);
        }

        MySqlFlexibleServerVirtualNetworkSubnetUsageResult IModelJsonSerializable<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerVirtualNetworkSubnetUsageResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MySqlFlexibleServerVirtualNetworkSubnetUsageResult IModelSerializable<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMySqlFlexibleServerVirtualNetworkSubnetUsageResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MySqlFlexibleServerVirtualNetworkSubnetUsageResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MySqlFlexibleServerVirtualNetworkSubnetUsageResult"/> to convert. </param>
        public static implicit operator RequestContent(MySqlFlexibleServerVirtualNetworkSubnetUsageResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MySqlFlexibleServerVirtualNetworkSubnetUsageResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MySqlFlexibleServerVirtualNetworkSubnetUsageResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMySqlFlexibleServerVirtualNetworkSubnetUsageResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
