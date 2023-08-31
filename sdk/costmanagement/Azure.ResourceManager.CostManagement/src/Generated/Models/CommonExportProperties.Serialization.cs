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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class CommonExportProperties : IUtf8JsonSerializable, IModelJsonSerializable<CommonExportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommonExportProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommonExportProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            writer.WritePropertyName("deliveryInfo"u8);
            if (DeliveryInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ExportDeliveryInfo>)DeliveryInfo).Serialize(writer, options);
            }
            writer.WritePropertyName("definition"u8);
            if (Definition is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<ExportDefinition>)Definition).Serialize(writer, options);
            }
            if (Optional.IsDefined(RunHistory))
            {
                writer.WritePropertyName("runHistory"u8);
                if (RunHistory is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExportExecutionListResult>)RunHistory).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PartitionData))
            {
                writer.WritePropertyName("partitionData"u8);
                writer.WriteBooleanValue(PartitionData.Value);
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

        internal static CommonExportProperties DeserializeCommonExportProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExportFormatType> format = default;
            ExportDeliveryInfo deliveryInfo = default;
            ExportDefinition definition = default;
            Optional<ExportExecutionListResult> runHistory = default;
            Optional<bool> partitionData = default;
            Optional<DateTimeOffset> nextRunTimeEstimate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    format = new ExportFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deliveryInfo"u8))
                {
                    deliveryInfo = ExportDeliveryInfo.DeserializeExportDeliveryInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = ExportDefinition.DeserializeExportDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("runHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runHistory = ExportExecutionListResult.DeserializeExportExecutionListResult(property.Value);
                    continue;
                }
                if (property.NameEquals("partitionData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionData = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nextRunTimeEstimate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextRunTimeEstimate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommonExportProperties(Optional.ToNullable(format), deliveryInfo, definition, runHistory.Value, Optional.ToNullable(partitionData), Optional.ToNullable(nextRunTimeEstimate), rawData);
        }

        CommonExportProperties IModelJsonSerializable<CommonExportProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonExportProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommonExportProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommonExportProperties IModelSerializable<CommonExportProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommonExportProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CommonExportProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CommonExportProperties"/> to convert. </param>
        public static implicit operator RequestContent(CommonExportProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CommonExportProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CommonExportProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommonExportProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
