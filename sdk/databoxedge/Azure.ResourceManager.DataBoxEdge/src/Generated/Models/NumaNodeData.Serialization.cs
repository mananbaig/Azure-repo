// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class NumaNodeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NumaNodeIndex))
            {
                writer.WritePropertyName("numaNodeIndex");
                writer.WriteNumberValue(NumaNodeIndex.Value);
            }
            if (Optional.IsDefined(TotalMemoryInMb))
            {
                writer.WritePropertyName("totalMemoryInMb");
                writer.WriteNumberValue(TotalMemoryInMb.Value);
            }
            if (Optional.IsDefined(LogicalCoreCountPerCore))
            {
                writer.WritePropertyName("logicalCoreCountPerCore");
                writer.WriteNumberValue(LogicalCoreCountPerCore.Value);
            }
            if (Optional.IsDefined(EffectiveAvailableMemoryInMB))
            {
                writer.WritePropertyName("effectiveAvailableMemoryInMb");
                writer.WriteNumberValue(EffectiveAvailableMemoryInMB.Value);
            }
            if (Optional.IsCollectionDefined(FreeVCpuIndexesForHpn))
            {
                writer.WritePropertyName("freeVCpuIndexesForHpn");
                writer.WriteStartArray();
                foreach (var item in FreeVCpuIndexesForHpn)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VCpuIndexesForHpn))
            {
                writer.WritePropertyName("vCpuIndexesForHpn");
                writer.WriteStartArray();
                foreach (var item in VCpuIndexesForHpn)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VCpuIndexesForRoot))
            {
                writer.WritePropertyName("vCpuIndexesForRoot");
                writer.WriteStartArray();
                foreach (var item in VCpuIndexesForRoot)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NumaNodeData DeserializeNumaNodeData(JsonElement element)
        {
            Optional<int> numaNodeIndex = default;
            Optional<long> totalMemoryInMb = default;
            Optional<int> logicalCoreCountPerCore = default;
            Optional<long> effectiveAvailableMemoryInMb = default;
            Optional<IList<int>> freeVCpuIndexesForHpn = default;
            Optional<IList<int>> vCpuIndexesForHpn = default;
            Optional<IList<int>> vCpuIndexesForRoot = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numaNodeIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numaNodeIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalMemoryInMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalMemoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logicalCoreCountPerCore"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logicalCoreCountPerCore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("effectiveAvailableMemoryInMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    effectiveAvailableMemoryInMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("freeVCpuIndexesForHpn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    freeVCpuIndexesForHpn = array;
                    continue;
                }
                if (property.NameEquals("vCpuIndexesForHpn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    vCpuIndexesForHpn = array;
                    continue;
                }
                if (property.NameEquals("vCpuIndexesForRoot"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    vCpuIndexesForRoot = array;
                    continue;
                }
            }
            return new NumaNodeData(Optional.ToNullable(numaNodeIndex), Optional.ToNullable(totalMemoryInMb), Optional.ToNullable(logicalCoreCountPerCore), Optional.ToNullable(effectiveAvailableMemoryInMb), Optional.ToList(freeVCpuIndexesForHpn), Optional.ToList(vCpuIndexesForHpn), Optional.ToList(vCpuIndexesForRoot));
        }
    }
}
