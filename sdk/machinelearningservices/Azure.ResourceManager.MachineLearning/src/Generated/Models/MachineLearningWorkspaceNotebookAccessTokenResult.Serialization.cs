// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningWorkspaceNotebookAccessTokenResult : IUtf8JsonSerializable, IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken"u8);
                writer.WriteStringValue(AccessToken);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiresIn))
            {
                writer.WritePropertyName("expiresIn"u8);
                writer.WriteNumberValue(ExpiresIn.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format != "W" && Optional.IsDefined(NotebookResourceId))
            {
                writer.WritePropertyName("notebookResourceId"u8);
                writer.WriteStringValue(NotebookResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(PublicDns))
            {
                writer.WritePropertyName("publicDns"u8);
                writer.WriteStringValue(PublicDns);
            }
            if (options.Format != "W" && Optional.IsDefined(RefreshToken))
            {
                writer.WritePropertyName("refreshToken"u8);
                writer.WriteStringValue(RefreshToken);
            }
            if (options.Format != "W" && Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (options.Format != "W" && Optional.IsDefined(TokenType))
            {
                writer.WritePropertyName("tokenType"u8);
                writer.WriteStringValue(TokenType);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        MachineLearningWorkspaceNotebookAccessTokenResult IJsonModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(document.RootElement, options);
        }

        internal static MachineLearningWorkspaceNotebookAccessTokenResult DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accessToken = default;
            int? expiresIn = default;
            string hostName = default;
            string notebookResourceId = default;
            string publicDns = default;
            string refreshToken = default;
            string scope = default;
            string tokenType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiresIn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresIn = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notebookResourceId"u8))
                {
                    notebookResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicDns"u8))
                {
                    publicDns = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshToken"u8))
                {
                    refreshToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenType"u8))
                {
                    tokenType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningWorkspaceNotebookAccessTokenResult(
                accessToken,
                expiresIn,
                hostName,
                notebookResourceId,
                publicDns,
                refreshToken,
                scope,
                tokenType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningWorkspaceNotebookAccessTokenResult IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningWorkspaceNotebookAccessTokenResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceNotebookAccessTokenResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWorkspaceNotebookAccessTokenResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
