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
    public partial class InMageFabricSwitchProviderBlockingErrorDetails : IUtf8JsonSerializable, IModelJsonSerializable<InMageFabricSwitchProviderBlockingErrorDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InMageFabricSwitchProviderBlockingErrorDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InMageFabricSwitchProviderBlockingErrorDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageFabricSwitchProviderBlockingErrorDetails>(this, options.Format);

            writer.WriteStartObject();
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

        internal static InMageFabricSwitchProviderBlockingErrorDetails DeserializeInMageFabricSwitchProviderBlockingErrorDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<string> possibleCauses = default;
            Optional<string> recommendedAction = default;
            Optional<IReadOnlyDictionary<string, string>> errorMessageParameters = default;
            Optional<IReadOnlyDictionary<string, string>> errorTags = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleCauses"u8))
                {
                    possibleCauses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessageParameters"u8))
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
                    errorMessageParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("errorTags"u8))
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
                    errorTags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InMageFabricSwitchProviderBlockingErrorDetails(errorCode.Value, errorMessage.Value, possibleCauses.Value, recommendedAction.Value, Optional.ToDictionary(errorMessageParameters), Optional.ToDictionary(errorTags), serializedAdditionalRawData);
        }

        InMageFabricSwitchProviderBlockingErrorDetails IModelJsonSerializable<InMageFabricSwitchProviderBlockingErrorDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageFabricSwitchProviderBlockingErrorDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageFabricSwitchProviderBlockingErrorDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InMageFabricSwitchProviderBlockingErrorDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageFabricSwitchProviderBlockingErrorDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InMageFabricSwitchProviderBlockingErrorDetails IModelSerializable<InMageFabricSwitchProviderBlockingErrorDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InMageFabricSwitchProviderBlockingErrorDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInMageFabricSwitchProviderBlockingErrorDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InMageFabricSwitchProviderBlockingErrorDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InMageFabricSwitchProviderBlockingErrorDetails"/> to convert. </param>
        public static implicit operator RequestContent(InMageFabricSwitchProviderBlockingErrorDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InMageFabricSwitchProviderBlockingErrorDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InMageFabricSwitchProviderBlockingErrorDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInMageFabricSwitchProviderBlockingErrorDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
