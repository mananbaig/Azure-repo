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
    public partial class JobSecrets : IUtf8JsonSerializable, IModelJsonSerializable<JobSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JobSecrets>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JobSecrets>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static JobSecrets DeserializeJobSecrets(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobSecretsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataBox": return DataboxJobSecrets.DeserializeDataboxJobSecrets(element);
                    case "DataBoxCustomerDisk": return CustomerDiskJobSecrets.DeserializeCustomerDiskJobSecrets(element);
                    case "DataBoxDisk": return DataBoxDiskJobSecrets.DeserializeDataBoxDiskJobSecrets(element);
                    case "DataBoxHeavy": return DataBoxHeavyJobSecrets.DeserializeDataBoxHeavyJobSecrets(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataBoxOrderType jobSecretsType = default;
            Optional<DataCenterAccessSecurityCode> dcAccessSecurityCode = default;
            Optional<ResponseError> error = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownJobSecrets(jobSecretsType, dcAccessSecurityCode.Value, error.Value, rawData);
        }

        JobSecrets IModelJsonSerializable<JobSecrets>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJobSecrets(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JobSecrets>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JobSecrets IModelSerializable<JobSecrets>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJobSecrets(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JobSecrets"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JobSecrets"/> to convert. </param>
        public static implicit operator RequestContent(JobSecrets model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JobSecrets"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JobSecrets(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJobSecrets(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
