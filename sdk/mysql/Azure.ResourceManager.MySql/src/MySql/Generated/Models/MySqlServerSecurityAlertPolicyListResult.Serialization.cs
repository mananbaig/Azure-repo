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
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    internal partial class MySqlServerSecurityAlertPolicyListResult : IUtf8JsonSerializable, IModelJsonSerializable<MySqlServerSecurityAlertPolicyListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MySqlServerSecurityAlertPolicyListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MySqlServerSecurityAlertPolicyListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static MySqlServerSecurityAlertPolicyListResult DeserializeMySqlServerSecurityAlertPolicyListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MySqlServerSecurityAlertPolicyData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlServerSecurityAlertPolicyData> array = new List<MySqlServerSecurityAlertPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlServerSecurityAlertPolicyData.DeserializeMySqlServerSecurityAlertPolicyData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MySqlServerSecurityAlertPolicyListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        MySqlServerSecurityAlertPolicyListResult IModelJsonSerializable<MySqlServerSecurityAlertPolicyListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlServerSecurityAlertPolicyListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MySqlServerSecurityAlertPolicyListResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MySqlServerSecurityAlertPolicyListResult IModelSerializable<MySqlServerSecurityAlertPolicyListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMySqlServerSecurityAlertPolicyListResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MySqlServerSecurityAlertPolicyListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MySqlServerSecurityAlertPolicyListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMySqlServerSecurityAlertPolicyListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
