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
    public partial class ContainerAppJobPatchProperties : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppJobPatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppJobPatchProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppJobPatchProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template"u8);
                writer.WriteObjectValue(Template);
            }
            if (Optional.IsCollectionDefined(OutboundIPAddresses))
            {
                writer.WritePropertyName("outboundIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundIPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EventStreamEndpoint))
            {
                writer.WritePropertyName("eventStreamEndpoint"u8);
                writer.WriteStringValue(EventStreamEndpoint);
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

        internal static ContainerAppJobPatchProperties DeserializeContainerAppJobPatchProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> environmentId = default;
            Optional<ContainerAppJobConfiguration> configuration = default;
            Optional<ContainerAppJobTemplate> template = default;
            Optional<IList<string>> outboundIPAddresses = default;
            Optional<string> eventStreamEndpoint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentId"u8))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = ContainerAppJobConfiguration.DeserializeContainerAppJobConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("template"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = ContainerAppJobTemplate.DeserializeContainerAppJobTemplate(property.Value);
                    continue;
                }
                if (property.NameEquals("outboundIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    outboundIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("eventStreamEndpoint"u8))
                {
                    eventStreamEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppJobPatchProperties(environmentId.Value, configuration.Value, template.Value, Optional.ToList(outboundIPAddresses), eventStreamEndpoint.Value, rawData);
        }

        ContainerAppJobPatchProperties IModelJsonSerializable<ContainerAppJobPatchProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppJobPatchProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppJobPatchProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppJobPatchProperties IModelSerializable<ContainerAppJobPatchProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppJobPatchProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerAppJobPatchProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerAppJobPatchProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppJobPatchProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
