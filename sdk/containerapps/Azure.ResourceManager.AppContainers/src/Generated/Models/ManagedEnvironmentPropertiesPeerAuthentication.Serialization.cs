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

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class ManagedEnvironmentPropertiesPeerAuthentication : IUtf8JsonSerializable, IModelJsonSerializable<ManagedEnvironmentPropertiesPeerAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedEnvironmentPropertiesPeerAuthentication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedEnvironmentPropertiesPeerAuthentication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Mtls))
            {
                writer.WritePropertyName("mtls"u8);
                writer.WriteObjectValue(Mtls);
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

        internal static ManagedEnvironmentPropertiesPeerAuthentication DeserializeManagedEnvironmentPropertiesPeerAuthentication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Mtls> mtls = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mtls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mtls = Mtls.DeserializeMtls(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedEnvironmentPropertiesPeerAuthentication(mtls.Value, rawData);
        }

        ManagedEnvironmentPropertiesPeerAuthentication IModelJsonSerializable<ManagedEnvironmentPropertiesPeerAuthentication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedEnvironmentPropertiesPeerAuthentication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedEnvironmentPropertiesPeerAuthentication>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedEnvironmentPropertiesPeerAuthentication IModelSerializable<ManagedEnvironmentPropertiesPeerAuthentication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedEnvironmentPropertiesPeerAuthentication(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ManagedEnvironmentPropertiesPeerAuthentication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ManagedEnvironmentPropertiesPeerAuthentication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedEnvironmentPropertiesPeerAuthentication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
