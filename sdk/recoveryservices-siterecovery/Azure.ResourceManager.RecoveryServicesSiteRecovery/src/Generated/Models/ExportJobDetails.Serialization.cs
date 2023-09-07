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
    public partial class ExportJobDetails : IUtf8JsonSerializable, IModelJsonSerializable<ExportJobDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExportJobDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExportJobDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportJobDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BlobUri))
            {
                writer.WritePropertyName("blobUri"u8);
                writer.WriteStringValue(BlobUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken"u8);
                writer.WriteStringValue(SasToken);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (Optional.IsCollectionDefined(AffectedObjectDetails))
            {
                writer.WritePropertyName("affectedObjectDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AffectedObjectDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static ExportJobDetails DeserializeExportJobDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> blobUri = default;
            Optional<string> sasToken = default;
            string instanceType = default;
            Optional<IReadOnlyDictionary<string, string>> affectedObjectDetails = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    affectedObjectDetails = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExportJobDetails(instanceType, Optional.ToDictionary(affectedObjectDetails), blobUri.Value, sasToken.Value, serializedAdditionalRawData);
        }

        ExportJobDetails IModelJsonSerializable<ExportJobDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportJobDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExportJobDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExportJobDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportJobDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExportJobDetails IModelSerializable<ExportJobDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExportJobDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExportJobDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExportJobDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExportJobDetails"/> to convert. </param>
        public static implicit operator RequestContent(ExportJobDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExportJobDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExportJobDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExportJobDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
