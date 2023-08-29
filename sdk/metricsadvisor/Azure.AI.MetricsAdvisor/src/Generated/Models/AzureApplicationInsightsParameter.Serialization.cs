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

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureApplicationInsightsParameter : IUtf8JsonSerializable, IModelJsonSerializable<AzureApplicationInsightsParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureApplicationInsightsParameter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureApplicationInsightsParameter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureCloud))
            {
                if (AzureCloud != null)
                {
                    writer.WritePropertyName("azureCloud"u8);
                    writer.WriteStringValue(AzureCloud);
                }
                else
                {
                    writer.WriteNull("azureCloud");
                }
            }
            if (Optional.IsDefined(ApplicationId))
            {
                if (ApplicationId != null)
                {
                    writer.WritePropertyName("applicationId"u8);
                    writer.WriteStringValue(ApplicationId);
                }
                else
                {
                    writer.WriteNull("applicationId");
                }
            }
            if (Optional.IsDefined(ApiKey))
            {
                if (ApiKey != null)
                {
                    writer.WritePropertyName("apiKey"u8);
                    writer.WriteStringValue(ApiKey);
                }
                else
                {
                    writer.WriteNull("apiKey");
                }
            }
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            else
            {
                writer.WriteNull("query");
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

        internal static AzureApplicationInsightsParameter DeserializeAzureApplicationInsightsParameter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> azureCloud = default;
            Optional<string> applicationId = default;
            Optional<string> apiKey = default;
            string query = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureCloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        azureCloud = null;
                        continue;
                    }
                    azureCloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        applicationId = null;
                        continue;
                    }
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        apiKey = null;
                        continue;
                    }
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        query = null;
                        continue;
                    }
                    query = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureApplicationInsightsParameter(azureCloud.Value, applicationId.Value, apiKey.Value, query, rawData);
        }

        AzureApplicationInsightsParameter IModelJsonSerializable<AzureApplicationInsightsParameter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureApplicationInsightsParameter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureApplicationInsightsParameter>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureApplicationInsightsParameter IModelSerializable<AzureApplicationInsightsParameter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureApplicationInsightsParameter(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AzureApplicationInsightsParameter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AzureApplicationInsightsParameter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureApplicationInsightsParameter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
