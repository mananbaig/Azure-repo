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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningManagedIdentity : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningManagedIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningManagedIdentity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningManagedIdentity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningManagedIdentity>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (Optional.IsDefined(ObjectId))
            {
                if (ObjectId != null)
                {
                    writer.WritePropertyName("objectId"u8);
                    writer.WriteStringValue(ObjectId.Value);
                }
                else
                {
                    writer.WriteNull("objectId");
                }
            }
            if (Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            writer.WritePropertyName("identityType"u8);
            writer.WriteStringValue(IdentityType.ToString());
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

        internal static MachineLearningManagedIdentity DeserializeMachineLearningManagedIdentity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid?> clientId = default;
            Optional<Guid?> objectId = default;
            Optional<ResourceIdentifier> resourceId = default;
            IdentityConfigurationType identityType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        objectId = null;
                        continue;
                    }
                    objectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityType"u8))
                {
                    identityType = new IdentityConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningManagedIdentity(identityType, Optional.ToNullable(clientId), Optional.ToNullable(objectId), resourceId.Value, rawData);
        }

        MachineLearningManagedIdentity IModelJsonSerializable<MachineLearningManagedIdentity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningManagedIdentity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningManagedIdentity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningManagedIdentity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningManagedIdentity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningManagedIdentity IModelSerializable<MachineLearningManagedIdentity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MachineLearningManagedIdentity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningManagedIdentity(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MachineLearningManagedIdentity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MachineLearningManagedIdentity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningManagedIdentity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
