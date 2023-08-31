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

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class SelectiveKeyRestoreOperationParameters : IUtf8JsonSerializable, IModelJsonSerializable<SelectiveKeyRestoreOperationParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SelectiveKeyRestoreOperationParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SelectiveKeyRestoreOperationParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sasTokenParameters"u8);
            writer.WriteObjectValue(SasTokenParameters);
            writer.WritePropertyName("folder"u8);
            writer.WriteStringValue(Folder);
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

        internal static SelectiveKeyRestoreOperationParameters DeserializeSelectiveKeyRestoreOperationParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SASTokenParameter sasTokenParameters = default;
            string folder = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasTokenParameters"u8))
                {
                    sasTokenParameters = SASTokenParameter.DeserializeSASTokenParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    folder = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SelectiveKeyRestoreOperationParameters(sasTokenParameters, folder, rawData);
        }

        SelectiveKeyRestoreOperationParameters IModelJsonSerializable<SelectiveKeyRestoreOperationParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSelectiveKeyRestoreOperationParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SelectiveKeyRestoreOperationParameters>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SelectiveKeyRestoreOperationParameters IModelSerializable<SelectiveKeyRestoreOperationParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSelectiveKeyRestoreOperationParameters(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SelectiveKeyRestoreOperationParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SelectiveKeyRestoreOperationParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSelectiveKeyRestoreOperationParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
