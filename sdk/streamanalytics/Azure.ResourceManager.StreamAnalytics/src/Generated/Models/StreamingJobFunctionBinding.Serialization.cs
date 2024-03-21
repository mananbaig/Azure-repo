// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    [PersistableModelProxy(typeof(UnknownFunctionBinding))]
    public partial class StreamingJobFunctionBinding : IUtf8JsonSerializable, IJsonModel<StreamingJobFunctionBinding>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobFunctionBinding>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobFunctionBinding>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionBinding)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionBindingType);
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

        StreamingJobFunctionBinding IJsonModel<StreamingJobFunctionBinding>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionBinding)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobFunctionBinding(document.RootElement, options);
        }

        internal static StreamingJobFunctionBinding DeserializeStreamingJobFunctionBinding(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.MachineLearning/WebService": return EMachineLearningStudioFunctionBinding.DeserializeEMachineLearningStudioFunctionBinding(element, options);
                    case "Microsoft.MachineLearningServices": return MachineLearningServiceFunctionBinding.DeserializeMachineLearningServiceFunctionBinding(element, options);
                    case "Microsoft.StreamAnalytics/CLRUdf": return CSharpFunctionBinding.DeserializeCSharpFunctionBinding(element, options);
                    case "Microsoft.StreamAnalytics/JavascriptUdf": return JavaScriptFunctionBinding.DeserializeJavaScriptFunctionBinding(element, options);
                }
            }
            return UnknownFunctionBinding.DeserializeUnknownFunctionBinding(element, options);
        }

        BinaryData IPersistableModel<StreamingJobFunctionBinding>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionBinding)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingJobFunctionBinding IPersistableModel<StreamingJobFunctionBinding>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobFunctionBinding(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionBinding)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobFunctionBinding>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
