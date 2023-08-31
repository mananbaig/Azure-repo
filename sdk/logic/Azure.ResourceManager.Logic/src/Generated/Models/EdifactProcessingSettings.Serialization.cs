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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactProcessingSettings : IUtf8JsonSerializable, IModelJsonSerializable<EdifactProcessingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EdifactProcessingSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EdifactProcessingSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("maskSecurityInfo"u8);
            writer.WriteBooleanValue(MaskSecurityInfo);
            writer.WritePropertyName("preserveInterchange"u8);
            writer.WriteBooleanValue(PreserveInterchange);
            writer.WritePropertyName("suspendInterchangeOnError"u8);
            writer.WriteBooleanValue(SuspendInterchangeOnError);
            writer.WritePropertyName("createEmptyXmlTagsForTrailingSeparators"u8);
            writer.WriteBooleanValue(CreateEmptyXmlTagsForTrailingSeparators);
            writer.WritePropertyName("useDotAsDecimalSeparator"u8);
            writer.WriteBooleanValue(UseDotAsDecimalSeparator);
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

        internal static EdifactProcessingSettings DeserializeEdifactProcessingSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool maskSecurityInfo = default;
            bool preserveInterchange = default;
            bool suspendInterchangeOnError = default;
            bool createEmptyXmlTagsForTrailingSeparators = default;
            bool useDotAsDecimalSeparator = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maskSecurityInfo"u8))
                {
                    maskSecurityInfo = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preserveInterchange"u8))
                {
                    preserveInterchange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("suspendInterchangeOnError"u8))
                {
                    suspendInterchangeOnError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createEmptyXmlTagsForTrailingSeparators"u8))
                {
                    createEmptyXmlTagsForTrailingSeparators = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("useDotAsDecimalSeparator"u8))
                {
                    useDotAsDecimalSeparator = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EdifactProcessingSettings(maskSecurityInfo, preserveInterchange, suspendInterchangeOnError, createEmptyXmlTagsForTrailingSeparators, useDotAsDecimalSeparator, rawData);
        }

        EdifactProcessingSettings IModelJsonSerializable<EdifactProcessingSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactProcessingSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EdifactProcessingSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EdifactProcessingSettings IModelSerializable<EdifactProcessingSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEdifactProcessingSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EdifactProcessingSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EdifactProcessingSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEdifactProcessingSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
