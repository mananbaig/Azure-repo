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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ScriptActionProfile : IUtf8JsonSerializable, IModelJsonSerializable<ScriptActionProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScriptActionProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScriptActionProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptActionProfile>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ScriptActionProfileType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(UriString);
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStringValue(Parameters);
            }
            writer.WritePropertyName("services"u8);
            writer.WriteStartArray();
            foreach (var item in Services)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(TimeoutInMinutes))
            {
                writer.WritePropertyName("timeoutInMinutes"u8);
                writer.WriteNumberValue(TimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(ShouldPersist))
            {
                writer.WritePropertyName("shouldPersist"u8);
                writer.WriteBooleanValue(ShouldPersist.Value);
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

        internal static ScriptActionProfile DeserializeScriptActionProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string name = default;
            string url = default;
            Optional<string> parameters = default;
            IList<string> services = default;
            Optional<int> timeoutInMinutes = default;
            Optional<bool> shouldPersist = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    parameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("services"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    services = array;
                    continue;
                }
                if (property.NameEquals("timeoutInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeoutInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("shouldPersist"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shouldPersist = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ScriptActionProfile(type, name, url, parameters.Value, services, Optional.ToNullable(timeoutInMinutes), Optional.ToNullable(shouldPersist), serializedAdditionalRawData);
        }

        ScriptActionProfile IModelJsonSerializable<ScriptActionProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptActionProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptActionProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScriptActionProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptActionProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScriptActionProfile IModelSerializable<ScriptActionProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ScriptActionProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScriptActionProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ScriptActionProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ScriptActionProfile"/> to convert. </param>
        public static implicit operator RequestContent(ScriptActionProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ScriptActionProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ScriptActionProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScriptActionProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
