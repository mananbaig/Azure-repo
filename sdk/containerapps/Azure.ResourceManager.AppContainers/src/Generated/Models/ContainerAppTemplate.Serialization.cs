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
    public partial class ContainerAppTemplate : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppTemplate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppTemplate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RevisionSuffix))
            {
                writer.WritePropertyName("revisionSuffix"u8);
                writer.WriteStringValue(RevisionSuffix);
            }
            if (Optional.IsDefined(TerminationGracePeriodSeconds))
            {
                writer.WritePropertyName("terminationGracePeriodSeconds"u8);
                writer.WriteNumberValue(TerminationGracePeriodSeconds.Value);
            }
            if (Optional.IsCollectionDefined(InitContainers))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Scale))
            {
                writer.WritePropertyName("scale"u8);
                writer.WriteObjectValue(Scale);
            }
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceBinds))
            {
                writer.WritePropertyName("serviceBinds"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBinds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static ContainerAppTemplate DeserializeContainerAppTemplate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> revisionSuffix = default;
            Optional<long> terminationGracePeriodSeconds = default;
            Optional<IList<ContainerAppInitContainer>> initContainers = default;
            Optional<IList<ContainerAppContainer>> containers = default;
            Optional<ContainerAppScale> scale = default;
            Optional<IList<ContainerAppVolume>> volumes = default;
            Optional<IList<ContainerAppServiceBind>> serviceBinds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("revisionSuffix"u8))
                {
                    revisionSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("terminationGracePeriodSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminationGracePeriodSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppInitContainer> array = new List<ContainerAppInitContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppInitContainer.DeserializeContainerAppInitContainer(item));
                    }
                    initContainers = array;
                    continue;
                }
                if (property.NameEquals("containers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppContainer> array = new List<ContainerAppContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppContainer.DeserializeContainerAppContainer(item));
                    }
                    containers = array;
                    continue;
                }
                if (property.NameEquals("scale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scale = ContainerAppScale.DeserializeContainerAppScale(property.Value);
                    continue;
                }
                if (property.NameEquals("volumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppVolume> array = new List<ContainerAppVolume>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppVolume.DeserializeContainerAppVolume(item));
                    }
                    volumes = array;
                    continue;
                }
                if (property.NameEquals("serviceBinds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppServiceBind> array = new List<ContainerAppServiceBind>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppServiceBind.DeserializeContainerAppServiceBind(item));
                    }
                    serviceBinds = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppTemplate(revisionSuffix.Value, Optional.ToNullable(terminationGracePeriodSeconds), Optional.ToList(initContainers), Optional.ToList(containers), scale.Value, Optional.ToList(volumes), Optional.ToList(serviceBinds), rawData);
        }

        ContainerAppTemplate IModelJsonSerializable<ContainerAppTemplate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppTemplate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppTemplate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppTemplate IModelSerializable<ContainerAppTemplate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppTemplate(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerAppTemplate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerAppTemplate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppTemplate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
