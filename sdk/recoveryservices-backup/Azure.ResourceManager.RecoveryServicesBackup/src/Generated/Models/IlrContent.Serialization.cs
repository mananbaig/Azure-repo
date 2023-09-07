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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IlrContent : IUtf8JsonSerializable, IModelJsonSerializable<IlrContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IlrContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IlrContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IlrContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static IlrContent DeserializeIlrContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShareProvisionILRRequest": return FileShareProvisionIlrContent.DeserializeFileShareProvisionIlrContent(element);
                    case "IaasVMILRRegistrationRequest": return IaasVmIlrRegistrationContent.DeserializeIaasVmIlrRegistrationContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string objectType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownIlrRequest(objectType, serializedAdditionalRawData);
        }

        IlrContent IModelJsonSerializable<IlrContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IlrContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIlrContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IlrContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IlrContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IlrContent IModelSerializable<IlrContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IlrContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIlrContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IlrContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IlrContent"/> to convert. </param>
        public static implicit operator RequestContent(IlrContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IlrContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IlrContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIlrContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
