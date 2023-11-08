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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmDeploymentTemplateLink : IUtf8JsonSerializable, IJsonModel<ArmDeploymentTemplateLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmDeploymentTemplateLink>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ArmDeploymentTemplateLink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            if (Optional.IsDefined(ContentVersion))
            {
                writer.WritePropertyName("contentVersion"u8);
                writer.WriteStringValue(ContentVersion);
            }
            if (Optional.IsDefined(QueryString))
            {
                writer.WritePropertyName("queryString"u8);
                writer.WriteStringValue(QueryString);
            }
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

        ArmDeploymentTemplateLink IJsonModel<ArmDeploymentTemplateLink>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArmDeploymentTemplateLink)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmDeploymentTemplateLink(document.RootElement, options);
        }

        internal static ArmDeploymentTemplateLink DeserializeArmDeploymentTemplateLink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> uri = default;
            Optional<string> id = default;
            Optional<string> relativePath = default;
            Optional<string> contentVersion = default;
            Optional<string> queryString = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentVersion"u8))
                {
                    contentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryString"u8))
                {
                    queryString = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmDeploymentTemplateLink(uri.Value, id.Value, relativePath.Value, contentVersion.Value, queryString.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ArmDeploymentTemplateLink>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArmDeploymentTemplateLink)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ArmDeploymentTemplateLink IModel<ArmDeploymentTemplateLink>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArmDeploymentTemplateLink)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeArmDeploymentTemplateLink(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ArmDeploymentTemplateLink>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
