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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ArcAgentProfile : IUtf8JsonSerializable, IModelJsonSerializable<ArcAgentProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ArcAgentProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ArcAgentProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(AgentAutoUpgrade))
            {
                writer.WritePropertyName("agentAutoUpgrade"u8);
                writer.WriteStringValue(AgentAutoUpgrade.Value.ToString());
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

        internal static ArcAgentProfile DeserializeArcAgentProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> agentVersion = default;
            Optional<AutoUpgradeOption> agentAutoUpgrade = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentAutoUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentAutoUpgrade = new AutoUpgradeOption(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ArcAgentProfile(agentVersion.Value, Optional.ToNullable(agentAutoUpgrade), rawData);
        }

        ArcAgentProfile IModelJsonSerializable<ArcAgentProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeArcAgentProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ArcAgentProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ArcAgentProfile IModelSerializable<ArcAgentProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeArcAgentProfile(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ArcAgentProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ArcAgentProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeArcAgentProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
