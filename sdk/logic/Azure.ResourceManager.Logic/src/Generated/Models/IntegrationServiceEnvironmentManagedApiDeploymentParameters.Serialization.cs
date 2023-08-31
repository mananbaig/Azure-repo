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
    internal partial class IntegrationServiceEnvironmentManagedApiDeploymentParameters : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationServiceEnvironmentManagedApiDeploymentParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationServiceEnvironmentManagedApiDeploymentParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ContentLinkDefinition))
            {
                writer.WritePropertyName("contentLinkDefinition"u8);
                writer.WriteObjectValue(ContentLinkDefinition);
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

        internal static IntegrationServiceEnvironmentManagedApiDeploymentParameters DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LogicContentLink> contentLinkDefinition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentLinkDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentLinkDefinition = LogicContentLink.DeserializeLogicContentLink(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentManagedApiDeploymentParameters(contentLinkDefinition.Value, rawData);
        }

        IntegrationServiceEnvironmentManagedApiDeploymentParameters IModelJsonSerializable<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationServiceEnvironmentManagedApiDeploymentParameters IModelSerializable<IntegrationServiceEnvironmentManagedApiDeploymentParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IntegrationServiceEnvironmentManagedApiDeploymentParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IntegrationServiceEnvironmentManagedApiDeploymentParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationServiceEnvironmentManagedApiDeploymentParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
