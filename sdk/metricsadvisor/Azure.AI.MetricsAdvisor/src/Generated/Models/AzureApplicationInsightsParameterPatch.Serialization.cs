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
    internal partial class AzureApplicationInsightsParameterPatch : IUtf8JsonSerializable, IModelJsonSerializable<AzureApplicationInsightsParameterPatch>
    {
        void IModelJsonSerializable<AzureApplicationInsightsParameterPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureCloud))
            {
                writer.WritePropertyName("azureCloud"u8);
                writer.WriteStringValue(AzureCloud);
            }
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
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

        internal static AzureApplicationInsightsParameterPatch DeserializeAzureApplicationInsightsParameterPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> azureCloud = default;
            Optional<string> applicationId = default;
            Optional<string> apiKey = default;
            Optional<string> query = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureCloud"u8))
                {
                    azureCloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"u8))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureApplicationInsightsParameterPatch(azureCloud.Value, applicationId.Value, apiKey.Value, query.Value, rawData);
        }

        AzureApplicationInsightsParameterPatch IModelJsonSerializable<AzureApplicationInsightsParameterPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureApplicationInsightsParameterPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureApplicationInsightsParameterPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureApplicationInsightsParameterPatch IModelSerializable<AzureApplicationInsightsParameterPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureApplicationInsightsParameterPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureApplicationInsightsParameterPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureApplicationInsightsParameterPatch"/> to convert. </param>
        public static implicit operator RequestContent(AzureApplicationInsightsParameterPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureApplicationInsightsParameterPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureApplicationInsightsParameterPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureApplicationInsightsParameterPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
