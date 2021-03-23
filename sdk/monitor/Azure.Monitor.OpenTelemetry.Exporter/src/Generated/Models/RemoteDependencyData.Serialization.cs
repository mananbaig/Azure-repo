// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class RemoteDependencyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(ResultCode))
            {
                writer.WritePropertyName("resultCode");
                writer.WriteStringValue(ResultCode);
            }
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteStringValue(Data);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteStringValue(Target);
            }
            writer.WritePropertyName("duration");
            writer.WriteStringValue(Duration);
            if (Optional.IsDefined(Success))
            {
                writer.WritePropertyName("success");
                writer.WriteBooleanValue(Success.Value);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Measurements))
            {
                writer.WritePropertyName("measurements");
                writer.WriteStartObject();
                foreach (var item in Measurements)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("ver");
            writer.WriteNumberValue(Version);
            writer.WriteEndObject();
        }
    }
}
