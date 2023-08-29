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

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscNodeReport : IUtf8JsonSerializable, IModelJsonSerializable<DscNodeReport>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DscNodeReport>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DscNodeReport>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EndOn))
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(StartOn))
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(DscNodeReportType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(DscNodeReportType);
            }
            if (Optional.IsDefined(ReportId))
            {
                writer.WritePropertyName("reportId"u8);
                writer.WriteStringValue(ReportId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(RefreshMode))
            {
                writer.WritePropertyName("refreshMode"u8);
                writer.WriteStringValue(RefreshMode);
            }
            if (Optional.IsDefined(RebootRequested))
            {
                writer.WritePropertyName("rebootRequested"u8);
                writer.WriteStringValue(RebootRequested);
            }
            if (Optional.IsDefined(ReportFormatVersion))
            {
                writer.WritePropertyName("reportFormatVersion"u8);
                writer.WriteStringValue(ReportFormatVersion);
            }
            if (Optional.IsDefined(ConfigurationVersion))
            {
                writer.WritePropertyName("configurationVersion"u8);
                writer.WriteStringValue(ConfigurationVersion);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MetaConfiguration))
            {
                writer.WritePropertyName("metaConfiguration"u8);
                writer.WriteObjectValue(MetaConfiguration);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsCollectionDefined(IPV4Addresses))
            {
                writer.WritePropertyName("iPV4Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPV4Addresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPV6Addresses))
            {
                writer.WritePropertyName("iPV6Addresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPV6Addresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NumberOfResources))
            {
                writer.WritePropertyName("numberOfResources"u8);
                writer.WriteNumberValue(NumberOfResources.Value);
            }
            if (Optional.IsDefined(RawErrors))
            {
                writer.WritePropertyName("rawErrors"u8);
                writer.WriteStringValue(RawErrors);
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

        internal static DscNodeReport DeserializeDscNodeReport(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> endTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<string> type = default;
            Optional<string> reportId = default;
            Optional<string> status = default;
            Optional<string> refreshMode = default;
            Optional<string> rebootRequested = default;
            Optional<string> reportFormatVersion = default;
            Optional<string> configurationVersion = default;
            Optional<string> id = default;
            Optional<IReadOnlyList<DscReportError>> errors = default;
            Optional<IReadOnlyList<DscReportResource>> resources = default;
            Optional<DscMetaConfiguration> metaConfiguration = default;
            Optional<string> hostName = default;
            Optional<IReadOnlyList<string>> ipV4Addresses = default;
            Optional<IReadOnlyList<string>> ipV6Addresses = default;
            Optional<int> numberOfResources = default;
            Optional<string> rawErrors = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportId"u8))
                {
                    reportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshMode"u8))
                {
                    refreshMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootRequested"u8))
                {
                    rebootRequested = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reportFormatVersion"u8))
                {
                    reportFormatVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationVersion"u8))
                {
                    configurationVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportError> array = new List<DscReportError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportError.DeserializeDscReportError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DscReportResource> array = new List<DscReportResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DscReportResource.DeserializeDscReportResource(item));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("metaConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metaConfiguration = DscMetaConfiguration.DeserializeDscMetaConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iPV4Addresses"u8))
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
                    ipV4Addresses = array;
                    continue;
                }
                if (property.NameEquals("iPV6Addresses"u8))
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
                    ipV6Addresses = array;
                    continue;
                }
                if (property.NameEquals("numberOfResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfResources = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rawErrors"u8))
                {
                    rawErrors = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DscNodeReport(Optional.ToNullable(endTime), Optional.ToNullable(lastModifiedTime), Optional.ToNullable(startTime), type.Value, reportId.Value, status.Value, refreshMode.Value, rebootRequested.Value, reportFormatVersion.Value, configurationVersion.Value, id.Value, Optional.ToList(errors), Optional.ToList(resources), metaConfiguration.Value, hostName.Value, Optional.ToList(ipV4Addresses), Optional.ToList(ipV6Addresses), Optional.ToNullable(numberOfResources), rawErrors.Value, rawData);
        }

        DscNodeReport IModelJsonSerializable<DscNodeReport>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDscNodeReport(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DscNodeReport>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DscNodeReport IModelSerializable<DscNodeReport>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDscNodeReport(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DscNodeReport model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DscNodeReport(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDscNodeReport(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
