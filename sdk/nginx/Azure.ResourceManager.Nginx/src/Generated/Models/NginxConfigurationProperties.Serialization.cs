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

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxConfigurationProperties : IUtf8JsonSerializable, IModelJsonSerializable<NginxConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NginxConfigurationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NginxConfigurationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProtectedFiles))
            {
                writer.WritePropertyName("protectedFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Package))
            {
                writer.WritePropertyName("package"u8);
                writer.WriteObjectValue(Package);
            }
            if (Optional.IsDefined(RootFile))
            {
                writer.WritePropertyName("rootFile"u8);
                writer.WriteStringValue(RootFile);
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

        internal static NginxConfigurationProperties DeserializeNginxConfigurationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<IList<NginxConfigurationFile>> files = default;
            Optional<IList<NginxConfigurationFile>> protectedFiles = default;
            Optional<NginxConfigurationPackage> package = default;
            Optional<string> rootFile = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("files"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxConfigurationFile> array = new List<NginxConfigurationFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxConfigurationFile.DeserializeNginxConfigurationFile(item));
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("protectedFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxConfigurationFile> array = new List<NginxConfigurationFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxConfigurationFile.DeserializeNginxConfigurationFile(item));
                    }
                    protectedFiles = array;
                    continue;
                }
                if (property.NameEquals("package"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    package = NginxConfigurationPackage.DeserializeNginxConfigurationPackage(property.Value);
                    continue;
                }
                if (property.NameEquals("rootFile"u8))
                {
                    rootFile = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NginxConfigurationProperties(Optional.ToNullable(provisioningState), Optional.ToList(files), Optional.ToList(protectedFiles), package.Value, rootFile.Value, rawData);
        }

        NginxConfigurationProperties IModelJsonSerializable<NginxConfigurationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxConfigurationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NginxConfigurationProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NginxConfigurationProperties IModelSerializable<NginxConfigurationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNginxConfigurationProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NginxConfigurationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NginxConfigurationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNginxConfigurationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
