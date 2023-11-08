// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class OnPremiseSqlResourceDetails : IUtf8JsonSerializable, IJsonModel<OnPremiseSqlResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnPremiseSqlResourceDetails>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<OnPremiseSqlResourceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("serverName"u8);
            writer.WriteStringValue(ServerName);
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("workspaceId"u8);
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("vmuuid"u8);
            writer.WriteStringValue(VmUuid);
            writer.WritePropertyName("sourceComputerId"u8);
            writer.WriteStringValue(SourceComputerId);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        OnPremiseSqlResourceDetails IJsonModel<OnPremiseSqlResourceDetails>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OnPremiseSqlResourceDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnPremiseSqlResourceDetails(document.RootElement, options);
        }

        internal static OnPremiseSqlResourceDetails DeserializeOnPremiseSqlResourceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serverName = default;
            string databaseName = default;
            ResourceIdentifier workspaceId = default;
            Guid vmuuid = default;
            string sourceComputerId = default;
            string machineName = default;
            Source source = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmuuid"u8))
                {
                    vmuuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("sourceComputerId"u8))
                {
                    sourceComputerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = new Source(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OnPremiseSqlResourceDetails(source, serializedAdditionalRawData, workspaceId, vmuuid, sourceComputerId, machineName, serverName, databaseName);
        }

        BinaryData IModel<OnPremiseSqlResourceDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OnPremiseSqlResourceDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OnPremiseSqlResourceDetails IModel<OnPremiseSqlResourceDetails>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OnPremiseSqlResourceDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOnPremiseSqlResourceDetails(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<OnPremiseSqlResourceDetails>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
