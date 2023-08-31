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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskCopyLogDetails : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxDiskCopyLogDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxDiskCopyLogDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxDiskCopyLogDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskCopyLogDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("copyLogDetailsType"u8);
            writer.WriteStringValue(CopyLogDetailsType.ToSerialString());
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

        internal static DataBoxDiskCopyLogDetails DeserializeDataBoxDiskCopyLogDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskSerialNumber = default;
            Optional<string> errorLogLink = default;
            Optional<string> verboseLogLink = default;
            DataBoxOrderType copyLogDetailsType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSerialNumber"u8))
                {
                    diskSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorLogLink"u8))
                {
                    errorLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verboseLogLink"u8))
                {
                    verboseLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyLogDetailsType"u8))
                {
                    copyLogDetailsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxDiskCopyLogDetails(copyLogDetailsType, diskSerialNumber.Value, errorLogLink.Value, verboseLogLink.Value, rawData);
        }

        DataBoxDiskCopyLogDetails IModelJsonSerializable<DataBoxDiskCopyLogDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskCopyLogDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxDiskCopyLogDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxDiskCopyLogDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskCopyLogDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxDiskCopyLogDetails IModelSerializable<DataBoxDiskCopyLogDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataBoxDiskCopyLogDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxDiskCopyLogDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxDiskCopyLogDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxDiskCopyLogDetails"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxDiskCopyLogDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxDiskCopyLogDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxDiskCopyLogDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxDiskCopyLogDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
