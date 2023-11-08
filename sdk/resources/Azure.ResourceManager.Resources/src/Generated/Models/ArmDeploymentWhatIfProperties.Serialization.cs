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
    public partial class ArmDeploymentWhatIfProperties : IUtf8JsonSerializable, IJsonModel<ArmDeploymentWhatIfProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmDeploymentWhatIfProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ArmDeploymentWhatIfProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WhatIfSettings))
            {
                writer.WritePropertyName("whatIfSettings"u8);
                writer.WriteObjectValue(WhatIfSettings);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Template);
#else
                using (JsonDocument document = JsonDocument.Parse(Template))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(TemplateLink))
            {
                writer.WritePropertyName("templateLink"u8);
                writer.WriteObjectValue(TemplateLink);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                using (JsonDocument document = JsonDocument.Parse(Parameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ParametersLink))
            {
                writer.WritePropertyName("parametersLink"u8);
                writer.WriteObjectValue(ParametersLink);
            }
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToSerialString());
            if (Optional.IsDefined(DebugSetting))
            {
                writer.WritePropertyName("debugSetting"u8);
                writer.WriteObjectValue(DebugSetting);
            }
            if (Optional.IsDefined(ErrorDeployment))
            {
                writer.WritePropertyName("onErrorDeployment"u8);
                writer.WriteObjectValue(ErrorDeployment);
            }
            if (Optional.IsDefined(ExpressionEvaluation))
            {
                writer.WritePropertyName("expressionEvaluationOptions"u8);
                writer.WriteObjectValue(ExpressionEvaluation);
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

        ArmDeploymentWhatIfProperties IJsonModel<ArmDeploymentWhatIfProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmDeploymentWhatIfProperties(document.RootElement, options);
        }

        internal static ArmDeploymentWhatIfProperties DeserializeArmDeploymentWhatIfProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmDeploymentWhatIfSettings> whatIfSettings = default;
            Optional<BinaryData> template = default;
            Optional<ArmDeploymentTemplateLink> templateLink = default;
            Optional<BinaryData> parameters = default;
            Optional<ArmDeploymentParametersLink> parametersLink = default;
            ArmDeploymentMode mode = default;
            Optional<DebugSetting> debugSetting = default;
            Optional<ErrorDeployment> onErrorDeployment = default;
            Optional<ExpressionEvaluationOptions> expressionEvaluationOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("whatIfSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    whatIfSettings = ArmDeploymentWhatIfSettings.DeserializeArmDeploymentWhatIfSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("template"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("templateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateLink = ArmDeploymentTemplateLink.DeserializeArmDeploymentTemplateLink(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parametersLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parametersLink = ArmDeploymentParametersLink.DeserializeArmDeploymentParametersLink(property.Value);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = property.Value.GetString().ToArmDeploymentMode();
                    continue;
                }
                if (property.NameEquals("debugSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSetting = DebugSetting.DeserializeDebugSetting(property.Value);
                    continue;
                }
                if (property.NameEquals("onErrorDeployment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onErrorDeployment = ErrorDeployment.DeserializeErrorDeployment(property.Value);
                    continue;
                }
                if (property.NameEquals("expressionEvaluationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expressionEvaluationOptions = ExpressionEvaluationOptions.DeserializeExpressionEvaluationOptions(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmDeploymentWhatIfProperties(template.Value, templateLink.Value, parameters.Value, parametersLink.Value, mode, debugSetting.Value, onErrorDeployment.Value, expressionEvaluationOptions.Value, serializedAdditionalRawData, whatIfSettings.Value);
        }

        BinaryData IModel<ArmDeploymentWhatIfProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ArmDeploymentWhatIfProperties IModel<ArmDeploymentWhatIfProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeArmDeploymentWhatIfProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ArmDeploymentWhatIfProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
