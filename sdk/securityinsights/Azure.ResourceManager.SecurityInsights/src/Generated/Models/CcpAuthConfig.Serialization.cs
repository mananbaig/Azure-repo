// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    [PersistableModelProxy(typeof(UnknownCcpAuthConfig))]
    public partial class CcpAuthConfig : IUtf8JsonSerializable, IJsonModel<CcpAuthConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CcpAuthConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CcpAuthConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CcpAuthConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CcpAuthConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AuthType.ToString());
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

        CcpAuthConfig IJsonModel<CcpAuthConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CcpAuthConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CcpAuthConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCcpAuthConfig(document.RootElement, options);
        }

        internal static CcpAuthConfig DeserializeCcpAuthConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "APIKey": return SecurityInsightsApiKeyAuthModel.DeserializeSecurityInsightsApiKeyAuthModel(element, options);
                    case "AWS": return AwsAuthModel.DeserializeAwsAuthModel(element, options);
                    case "Basic": return BasicAuthModel.DeserializeBasicAuthModel(element, options);
                    case "GCP": return GcpAuthModel.DeserializeGcpAuthModel(element, options);
                    case "GitHub": return GitHubAuthModel.DeserializeGitHubAuthModel(element, options);
                    case "JwtToken": return JwtAuthModel.DeserializeJwtAuthModel(element, options);
                    case "None": return NoneAuthModel.DeserializeNoneAuthModel(element, options);
                    case "OAuth2": return OAuthModel.DeserializeOAuthModel(element, options);
                    case "Oracle": return OracleAuthModel.DeserializeOracleAuthModel(element, options);
                    case "ServiceBus": return GenericBlobSbsAuthModel.DeserializeGenericBlobSbsAuthModel(element, options);
                    case "Session": return SessionAuthModel.DeserializeSessionAuthModel(element, options);
                }
            }
            return UnknownCcpAuthConfig.DeserializeUnknownCcpAuthConfig(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{AuthType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CcpAuthConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CcpAuthConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CcpAuthConfig)} does not support writing '{options.Format}' format.");
            }
        }

        CcpAuthConfig IPersistableModel<CcpAuthConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CcpAuthConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCcpAuthConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CcpAuthConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CcpAuthConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
