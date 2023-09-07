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

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceMonitorUserInfo : IUtf8JsonSerializable, IModelJsonSerializable<DynatraceMonitorUserInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DynatraceMonitorUserInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DynatraceMonitorUserInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorUserInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FirstName))
            {
                writer.WritePropertyName("firstName"u8);
                writer.WriteStringValue(FirstName);
            }
            if (Optional.IsDefined(LastName))
            {
                writer.WritePropertyName("lastName"u8);
                writer.WriteStringValue(LastName);
            }
            if (Optional.IsDefined(EmailAddress))
            {
                writer.WritePropertyName("emailAddress"u8);
                writer.WriteStringValue(EmailAddress);
            }
            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            if (Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
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

        internal static DynatraceMonitorUserInfo DeserializeDynatraceMonitorUserInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> firstName = default;
            Optional<string> lastName = default;
            Optional<string> emailAddress = default;
            Optional<string> phoneNumber = default;
            Optional<string> country = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstName"u8))
                {
                    firstName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastName"u8))
                {
                    lastName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailAddress"u8))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DynatraceMonitorUserInfo(firstName.Value, lastName.Value, emailAddress.Value, phoneNumber.Value, country.Value, serializedAdditionalRawData);
        }

        DynatraceMonitorUserInfo IModelJsonSerializable<DynatraceMonitorUserInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorUserInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceMonitorUserInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DynatraceMonitorUserInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorUserInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DynatraceMonitorUserInfo IModelSerializable<DynatraceMonitorUserInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceMonitorUserInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDynatraceMonitorUserInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DynatraceMonitorUserInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DynatraceMonitorUserInfo"/> to convert. </param>
        public static implicit operator RequestContent(DynatraceMonitorUserInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DynatraceMonitorUserInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DynatraceMonitorUserInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDynatraceMonitorUserInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
