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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AutoHealCustomAction : IUtf8JsonSerializable, IModelJsonSerializable<AutoHealCustomAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AutoHealCustomAction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AutoHealCustomAction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoHealCustomAction>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Exe))
            {
                writer.WritePropertyName("exe"u8);
                writer.WriteStringValue(Exe);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStringValue(Parameters);
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

        internal static AutoHealCustomAction DeserializeAutoHealCustomAction(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> exe = default;
            Optional<string> parameters = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exe"u8))
                {
                    exe = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    parameters = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AutoHealCustomAction(exe.Value, parameters.Value, serializedAdditionalRawData);
        }

        AutoHealCustomAction IModelJsonSerializable<AutoHealCustomAction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoHealCustomAction>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoHealCustomAction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AutoHealCustomAction>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoHealCustomAction>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AutoHealCustomAction IModelSerializable<AutoHealCustomAction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AutoHealCustomAction>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAutoHealCustomAction(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AutoHealCustomAction"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AutoHealCustomAction"/> to convert. </param>
        public static implicit operator RequestContent(AutoHealCustomAction model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AutoHealCustomAction"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AutoHealCustomAction(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAutoHealCustomAction(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
