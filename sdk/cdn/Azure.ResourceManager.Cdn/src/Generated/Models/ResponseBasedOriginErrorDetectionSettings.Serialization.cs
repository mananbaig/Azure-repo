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

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResponseBasedOriginErrorDetectionSettings : IUtf8JsonSerializable, IModelJsonSerializable<ResponseBasedOriginErrorDetectionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResponseBasedOriginErrorDetectionSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResponseBasedOriginErrorDetectionSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResponseBasedDetectedErrorType))
            {
                writer.WritePropertyName("responseBasedDetectedErrorTypes"u8);
                writer.WriteStringValue(ResponseBasedDetectedErrorType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ResponseBasedFailoverThresholdPercentage))
            {
                writer.WritePropertyName("responseBasedFailoverThresholdPercentage"u8);
                writer.WriteNumberValue(ResponseBasedFailoverThresholdPercentage.Value);
            }
            if (Optional.IsCollectionDefined(HttpErrorRanges))
            {
                writer.WritePropertyName("httpErrorRanges"u8);
                writer.WriteStartArray();
                foreach (var item in HttpErrorRanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static ResponseBasedOriginErrorDetectionSettings DeserializeResponseBasedOriginErrorDetectionSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResponseBasedDetectedErrorType> responseBasedDetectedErrorTypes = default;
            Optional<int> responseBasedFailoverThresholdPercentage = default;
            Optional<IList<HttpErrorRange>> httpErrorRanges = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("responseBasedDetectedErrorTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseBasedDetectedErrorTypes = property.Value.GetString().ToResponseBasedDetectedErrorType();
                    continue;
                }
                if (property.NameEquals("responseBasedFailoverThresholdPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseBasedFailoverThresholdPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpErrorRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HttpErrorRange> array = new List<HttpErrorRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HttpErrorRange.DeserializeHttpErrorRange(item));
                    }
                    httpErrorRanges = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResponseBasedOriginErrorDetectionSettings(Optional.ToNullable(responseBasedDetectedErrorTypes), Optional.ToNullable(responseBasedFailoverThresholdPercentage), Optional.ToList(httpErrorRanges), rawData);
        }

        ResponseBasedOriginErrorDetectionSettings IModelJsonSerializable<ResponseBasedOriginErrorDetectionSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResponseBasedOriginErrorDetectionSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResponseBasedOriginErrorDetectionSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResponseBasedOriginErrorDetectionSettings IModelSerializable<ResponseBasedOriginErrorDetectionSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResponseBasedOriginErrorDetectionSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ResponseBasedOriginErrorDetectionSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ResponseBasedOriginErrorDetectionSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResponseBasedOriginErrorDetectionSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
