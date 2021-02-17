// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Models
{
    public partial class CombinedManifest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MediaType))
            {
                writer.WritePropertyName("mediaType");
                writer.WriteStringValue(MediaType);
            }
            if (Optional.IsCollectionDefined(Manifests))
            {
                writer.WritePropertyName("manifests");
                writer.WriteStartArray();
                foreach (var item in Manifests)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config");
                writer.WriteObjectValue(Config);
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers");
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotations))
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations");
                    writer.WriteObjectValue(Annotations);
                }
                else
                {
                    writer.WriteNull("annotations");
                }
            }
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion");
                writer.WriteNumberValue(SchemaVersion.Value);
            }
            writer.WriteEndObject();
        }

        internal static CombinedManifest DeserializeCombinedManifest(JsonElement element)
        {
            Optional<string> mediaType = default;
            Optional<IList<ManifestListAttributes>> manifests = default;
            Optional<ContentDescriptor> config = default;
            Optional<IList<ContentDescriptor>> layers = default;
            Optional<Annotations> annotations = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mediaType"))
                {
                    mediaType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManifestListAttributes> array = new List<ManifestListAttributes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManifestListAttributes.DeserializeManifestListAttributes(item));
                    }
                    manifests = array;
                    continue;
                }
                if (property.NameEquals("config"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    config = ContentDescriptor.DeserializeContentDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContentDescriptor> array = new List<ContentDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentDescriptor.DeserializeContentDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = Annotations.DeserializeAnnotations(property.Value);
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new CombinedManifest(Optional.ToNullable(schemaVersion), mediaType.Value, Optional.ToList(manifests), config.Value, Optional.ToList(layers), annotations.Value);
        }
    }
}
