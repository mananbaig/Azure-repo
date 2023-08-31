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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class CreateJobValidationContent : IUtf8JsonSerializable, IModelJsonSerializable<CreateJobValidationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CreateJobValidationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CreateJobValidationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CreateJobValidationContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("validationCategory"u8);
            writer.WriteStringValue(ValidationCategory.ToString());
            writer.WritePropertyName("individualRequestDetails"u8);
            writer.WriteStartArray();
            foreach (var item in IndividualRequestDetails)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        internal static CreateJobValidationContent DeserializeCreateJobValidationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxValidationCategory validationCategory = default;
            IList<DataBoxValidationInputContent> individualRequestDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationCategory"u8))
                {
                    validationCategory = new DataBoxValidationCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("individualRequestDetails"u8))
                {
                    List<DataBoxValidationInputContent> array = new List<DataBoxValidationInputContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxValidationInputContent.DeserializeDataBoxValidationInputContent(item));
                    }
                    individualRequestDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CreateJobValidationContent(validationCategory, individualRequestDetails, rawData);
        }

        CreateJobValidationContent IModelJsonSerializable<CreateJobValidationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CreateJobValidationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateJobValidationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CreateJobValidationContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CreateJobValidationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CreateJobValidationContent IModelSerializable<CreateJobValidationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CreateJobValidationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCreateJobValidationContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CreateJobValidationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CreateJobValidationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCreateJobValidationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
