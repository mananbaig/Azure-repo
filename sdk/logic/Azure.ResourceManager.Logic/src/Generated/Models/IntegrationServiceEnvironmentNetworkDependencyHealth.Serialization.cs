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
    public partial class IntegrationServiceEnvironmentNetworkDependencyHealth : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        internal static IntegrationServiceEnvironmentNetworkDependencyHealth DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IntegrationServiceErrorInfo> error = default;
            Optional<IntegrationServiceEnvironmentNetworkDependencyHealthState> state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = IntegrationServiceErrorInfo.DeserializeIntegrationServiceErrorInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationServiceEnvironmentNetworkDependencyHealthState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationServiceEnvironmentNetworkDependencyHealth(error.Value, Optional.ToNullable(state), rawData);
        }

        IntegrationServiceEnvironmentNetworkDependencyHealth IModelJsonSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationServiceEnvironmentNetworkDependencyHealth IModelSerializable<IntegrationServiceEnvironmentNetworkDependencyHealth>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IntegrationServiceEnvironmentNetworkDependencyHealth model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IntegrationServiceEnvironmentNetworkDependencyHealth(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
