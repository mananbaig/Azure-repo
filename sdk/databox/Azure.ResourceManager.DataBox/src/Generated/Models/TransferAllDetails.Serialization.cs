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
    public partial class TransferAllDetails : IUtf8JsonSerializable, IModelJsonSerializable<TransferAllDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TransferAllDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TransferAllDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("dataAccountType"u8);
            writer.WriteStringValue(DataAccountType.ToSerialString());
            if (Optional.IsDefined(TransferAllBlobs))
            {
                writer.WritePropertyName("transferAllBlobs"u8);
                writer.WriteBooleanValue(TransferAllBlobs.Value);
            }
            if (Optional.IsDefined(TransferAllFiles))
            {
                writer.WritePropertyName("transferAllFiles"u8);
                writer.WriteBooleanValue(TransferAllFiles.Value);
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

        internal static TransferAllDetails DeserializeTransferAllDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataAccountType dataAccountType = default;
            Optional<bool> transferAllBlobs = default;
            Optional<bool> transferAllFiles = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataAccountType"u8))
                {
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("transferAllBlobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferAllBlobs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("transferAllFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferAllFiles = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TransferAllDetails(dataAccountType, Optional.ToNullable(transferAllBlobs), Optional.ToNullable(transferAllFiles), rawData);
        }

        TransferAllDetails IModelJsonSerializable<TransferAllDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferAllDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TransferAllDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TransferAllDetails IModelSerializable<TransferAllDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTransferAllDetails(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TransferAllDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TransferAllDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTransferAllDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
