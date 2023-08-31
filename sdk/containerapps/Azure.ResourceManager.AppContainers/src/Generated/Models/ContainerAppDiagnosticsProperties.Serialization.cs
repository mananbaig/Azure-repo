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
    public partial class ContainerAppDiagnosticsProperties : IUtf8JsonSerializable, IModelJsonSerializable<ContainerAppDiagnosticsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerAppDiagnosticsProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerAppDiagnosticsProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                if (Metadata is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerAppDiagnosticsMetadata>)Metadata).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteStartArray();
                foreach (var item in Dataset)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ContainerAppDiagnosticsDataApiResult>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                if (Status is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerAppDiagnosticsStatus>)Status).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(DataProviderMetadata))
            {
                writer.WritePropertyName("dataProviderMetadata"u8);
                if (DataProviderMetadata is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerAppDiagnosticDataProviderMetadata>)DataProviderMetadata).Serialize(writer, options);
                }
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

        internal static ContainerAppDiagnosticsProperties DeserializeContainerAppDiagnosticsProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppDiagnosticsMetadata> metadata = default;
            Optional<IList<ContainerAppDiagnosticsDataApiResult>> dataset = default;
            Optional<ContainerAppDiagnosticsStatus> status = default;
            Optional<ContainerAppDiagnosticDataProviderMetadata> dataProviderMetadata = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ContainerAppDiagnosticsMetadata.DeserializeContainerAppDiagnosticsMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppDiagnosticsDataApiResult> array = new List<ContainerAppDiagnosticsDataApiResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppDiagnosticsDataApiResult.DeserializeContainerAppDiagnosticsDataApiResult(item));
                    }
                    dataset = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ContainerAppDiagnosticsStatus.DeserializeContainerAppDiagnosticsStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("dataProviderMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataProviderMetadata = ContainerAppDiagnosticDataProviderMetadata.DeserializeContainerAppDiagnosticDataProviderMetadata(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerAppDiagnosticsProperties(metadata.Value, Optional.ToList(dataset), status.Value, dataProviderMetadata.Value, rawData);
        }

        ContainerAppDiagnosticsProperties IModelJsonSerializable<ContainerAppDiagnosticsProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDiagnosticsProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerAppDiagnosticsProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerAppDiagnosticsProperties IModelSerializable<ContainerAppDiagnosticsProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerAppDiagnosticsProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerAppDiagnosticsProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerAppDiagnosticsProperties"/> to convert. </param>
        public static implicit operator RequestContent(ContainerAppDiagnosticsProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerAppDiagnosticsProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerAppDiagnosticsProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerAppDiagnosticsProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
