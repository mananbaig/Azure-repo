// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SsisChildPackageConverter))]
    public partial class SsisChildPackage : IUtf8JsonSerializable, IModelJsonSerializable<SsisChildPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SsisChildPackage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SsisChildPackage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SsisChildPackage>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("packagePath"u8);
            writer.WriteObjectValue(PackagePath);
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            writer.WritePropertyName("packageContent"u8);
            writer.WriteObjectValue(PackageContent);
            if (Optional.IsDefined(PackageLastModifiedDate))
            {
                writer.WritePropertyName("packageLastModifiedDate"u8);
                writer.WriteStringValue(PackageLastModifiedDate);
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

        internal static SsisChildPackage DeserializeSsisChildPackage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object packagePath = default;
            Optional<string> packageName = default;
            object packageContent = default;
            Optional<string> packageLastModifiedDate = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packagePath"u8))
                {
                    packagePath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("packageName"u8))
                {
                    packageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageContent"u8))
                {
                    packageContent = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("packageLastModifiedDate"u8))
                {
                    packageLastModifiedDate = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SsisChildPackage(packagePath, packageName.Value, packageContent, packageLastModifiedDate.Value, serializedAdditionalRawData);
        }

        SsisChildPackage IModelJsonSerializable<SsisChildPackage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SsisChildPackage>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisChildPackage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SsisChildPackage>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SsisChildPackage>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SsisChildPackage IModelSerializable<SsisChildPackage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SsisChildPackage>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSsisChildPackage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SsisChildPackage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SsisChildPackage"/> to convert. </param>
        public static implicit operator RequestContent(SsisChildPackage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SsisChildPackage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SsisChildPackage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSsisChildPackage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SsisChildPackageConverter : JsonConverter<SsisChildPackage>
        {
            public override void Write(Utf8JsonWriter writer, SsisChildPackage model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SsisChildPackage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSsisChildPackage(document.RootElement);
            }
        }
    }
}
