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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GrantAccessData : IUtf8JsonSerializable, IModelJsonSerializable<GrantAccessData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GrantAccessData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GrantAccessData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("access"u8);
            writer.WriteStringValue(Access.ToString());
            writer.WritePropertyName("durationInSeconds"u8);
            writer.WriteNumberValue(DurationInSeconds);
            if (Optional.IsDefined(GetSecureVmGuestStateSas))
            {
                writer.WritePropertyName("getSecureVMGuestStateSAS"u8);
                writer.WriteBooleanValue(GetSecureVmGuestStateSas.Value);
            }
            if (Optional.IsDefined(FileFormat))
            {
                writer.WritePropertyName("fileFormat"u8);
                writer.WriteStringValue(FileFormat.Value.ToString());
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

        internal static GrantAccessData DeserializeGrantAccessData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AccessLevel access = default;
            int durationInSeconds = default;
            Optional<bool> getSecureVmGuestStateSas = default;
            Optional<DiskImageFileFormat> fileFormat = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("access"u8))
                {
                    access = new AccessLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("durationInSeconds"u8))
                {
                    durationInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("getSecureVMGuestStateSAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    getSecureVmGuestStateSas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fileFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileFormat = new DiskImageFileFormat(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GrantAccessData(access, durationInSeconds, Optional.ToNullable(getSecureVmGuestStateSas), Optional.ToNullable(fileFormat), rawData);
        }

        GrantAccessData IModelJsonSerializable<GrantAccessData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGrantAccessData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GrantAccessData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GrantAccessData IModelSerializable<GrantAccessData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGrantAccessData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GrantAccessData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GrantAccessData"/> to convert. </param>
        public static implicit operator RequestContent(GrantAccessData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GrantAccessData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GrantAccessData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGrantAccessData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
