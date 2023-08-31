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
    public partial class DataboxJobSecrets : IUtf8JsonSerializable, IModelJsonSerializable<DataboxJobSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataboxJobSecrets>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataboxJobSecrets>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataboxJobSecrets>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PodSecrets))
            {
                writer.WritePropertyName("podSecrets"u8);
                writer.WriteStartArray();
                foreach (var item in PodSecrets)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataBoxSecret>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("jobSecretsType"u8);
            writer.WriteStringValue(JobSecretsType.ToSerialString());
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

        internal static DataboxJobSecrets DeserializeDataboxJobSecrets(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DataBoxSecret>> podSecrets = default;
            DataBoxOrderType jobSecretsType = default;
            Optional<DataCenterAccessSecurityCode> dcAccessSecurityCode = default;
            Optional<ResponseError> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("podSecrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxSecret> array = new List<DataBoxSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxSecret.DeserializeDataBoxSecret(item));
                    }
                    podSecrets = array;
                    continue;
                }
                if (property.NameEquals("jobSecretsType"u8))
                {
                    jobSecretsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dcAccessSecurityCode = DataCenterAccessSecurityCode.DeserializeDataCenterAccessSecurityCode(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataboxJobSecrets(jobSecretsType, dcAccessSecurityCode.Value, error.Value, Optional.ToList(podSecrets), rawData);
        }

        DataboxJobSecrets IModelJsonSerializable<DataboxJobSecrets>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataboxJobSecrets>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataboxJobSecrets(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataboxJobSecrets>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataboxJobSecrets>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataboxJobSecrets IModelSerializable<DataboxJobSecrets>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DataboxJobSecrets>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataboxJobSecrets(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataboxJobSecrets"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataboxJobSecrets"/> to convert. </param>
        public static implicit operator RequestContent(DataboxJobSecrets model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataboxJobSecrets"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataboxJobSecrets(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataboxJobSecrets(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
