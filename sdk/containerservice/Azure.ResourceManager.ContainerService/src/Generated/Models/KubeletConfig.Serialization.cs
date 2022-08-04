// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class KubeletConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CpuManagerPolicy))
            {
                writer.WritePropertyName("cpuManagerPolicy");
                writer.WriteStringValue(CpuManagerPolicy);
            }
            if (Optional.IsDefined(CpuCfsQuota))
            {
                writer.WritePropertyName("cpuCfsQuota");
                writer.WriteBooleanValue(CpuCfsQuota.Value);
            }
            if (Optional.IsDefined(CpuCfsQuotaPeriod))
            {
                writer.WritePropertyName("cpuCfsQuotaPeriod");
                writer.WriteStringValue(CpuCfsQuotaPeriod);
            }
            if (Optional.IsDefined(ImageGcHighThreshold))
            {
                writer.WritePropertyName("imageGcHighThreshold");
                writer.WriteNumberValue(ImageGcHighThreshold.Value);
            }
            if (Optional.IsDefined(ImageGcLowThreshold))
            {
                writer.WritePropertyName("imageGcLowThreshold");
                writer.WriteNumberValue(ImageGcLowThreshold.Value);
            }
            if (Optional.IsDefined(TopologyManagerPolicy))
            {
                writer.WritePropertyName("topologyManagerPolicy");
                writer.WriteStringValue(TopologyManagerPolicy);
            }
            if (Optional.IsCollectionDefined(AllowedUnsafeSysctls))
            {
                writer.WritePropertyName("allowedUnsafeSysctls");
                writer.WriteStartArray();
                foreach (var item in AllowedUnsafeSysctls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FailSwapOn))
            {
                writer.WritePropertyName("failSwapOn");
                writer.WriteBooleanValue(FailSwapOn.Value);
            }
            if (Optional.IsDefined(ContainerLogMaxSizeInMB))
            {
                writer.WritePropertyName("containerLogMaxSizeMB");
                writer.WriteNumberValue(ContainerLogMaxSizeInMB.Value);
            }
            if (Optional.IsDefined(ContainerLogMaxFiles))
            {
                writer.WritePropertyName("containerLogMaxFiles");
                writer.WriteNumberValue(ContainerLogMaxFiles.Value);
            }
            if (Optional.IsDefined(PodMaxPids))
            {
                writer.WritePropertyName("podMaxPids");
                writer.WriteNumberValue(PodMaxPids.Value);
            }
            writer.WriteEndObject();
        }

        internal static KubeletConfig DeserializeKubeletConfig(JsonElement element)
        {
            Optional<string> cpuManagerPolicy = default;
            Optional<bool> cpuCfsQuota = default;
            Optional<string> cpuCfsQuotaPeriod = default;
            Optional<int> imageGcHighThreshold = default;
            Optional<int> imageGcLowThreshold = default;
            Optional<string> topologyManagerPolicy = default;
            Optional<IList<string>> allowedUnsafeSysctls = default;
            Optional<bool> failSwapOn = default;
            Optional<int> containerLogMaxSizeMB = default;
            Optional<int> containerLogMaxFiles = default;
            Optional<int> podMaxPids = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuManagerPolicy"))
                {
                    cpuManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuota"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cpuCfsQuota = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cpuCfsQuotaPeriod"))
                {
                    cpuCfsQuotaPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageGcHighThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    imageGcHighThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("imageGcLowThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    imageGcLowThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("topologyManagerPolicy"))
                {
                    topologyManagerPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedUnsafeSysctls"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedUnsafeSysctls = array;
                    continue;
                }
                if (property.NameEquals("failSwapOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failSwapOn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerLogMaxSizeMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerLogMaxSizeMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerLogMaxFiles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    containerLogMaxFiles = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("podMaxPids"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    podMaxPids = property.Value.GetInt32();
                    continue;
                }
            }
            return new KubeletConfig(cpuManagerPolicy.Value, Optional.ToNullable(cpuCfsQuota), cpuCfsQuotaPeriod.Value, Optional.ToNullable(imageGcHighThreshold), Optional.ToNullable(imageGcLowThreshold), topologyManagerPolicy.Value, Optional.ToList(allowedUnsafeSysctls), Optional.ToNullable(failSwapOn), Optional.ToNullable(containerLogMaxSizeMB), Optional.ToNullable(containerLogMaxFiles), Optional.ToNullable(podMaxPids));
        }
    }
}
