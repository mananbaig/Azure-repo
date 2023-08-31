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

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class RemediationDeploymentSummary : IUtf8JsonSerializable, IModelJsonSerializable<RemediationDeploymentSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RemediationDeploymentSummary>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RemediationDeploymentSummary>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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

        internal static RemediationDeploymentSummary DeserializeRemediationDeploymentSummary(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> totalDeployments = default;
            Optional<int> successfulDeployments = default;
            Optional<int> failedDeployments = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeployments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successfulDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successfulDeployments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failedDeployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedDeployments = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RemediationDeploymentSummary(Optional.ToNullable(totalDeployments), Optional.ToNullable(successfulDeployments), Optional.ToNullable(failedDeployments), rawData);
        }

        RemediationDeploymentSummary IModelJsonSerializable<RemediationDeploymentSummary>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRemediationDeploymentSummary(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RemediationDeploymentSummary>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RemediationDeploymentSummary IModelSerializable<RemediationDeploymentSummary>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRemediationDeploymentSummary(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RemediationDeploymentSummary"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RemediationDeploymentSummary"/> to convert. </param>
        public static implicit operator RequestContent(RemediationDeploymentSummary model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RemediationDeploymentSummary"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RemediationDeploymentSummary(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRemediationDeploymentSummary(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
