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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryDataPlaneAccessPolicyResult : IUtf8JsonSerializable, IModelJsonSerializable<DataFactoryDataPlaneAccessPolicyResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFactoryDataPlaneAccessPolicyResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFactoryDataPlaneAccessPolicyResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                if (Policy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DataFactoryDataPlaneUserAccessPolicy>)Policy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken"u8);
                writer.WriteStringValue(AccessToken);
            }
            if (Optional.IsDefined(DataPlaneUri))
            {
                writer.WritePropertyName("dataPlaneUrl"u8);
                writer.WriteStringValue(DataPlaneUri.AbsoluteUri);
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

        internal static DataFactoryDataPlaneAccessPolicyResult DeserializeDataFactoryDataPlaneAccessPolicyResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryDataPlaneUserAccessPolicy> policy = default;
            Optional<string> accessToken = default;
            Optional<Uri> dataPlaneUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = DataFactoryDataPlaneUserAccessPolicy.DeserializeDataFactoryDataPlaneUserAccessPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPlaneUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPlaneUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataFactoryDataPlaneAccessPolicyResult(policy.Value, accessToken.Value, dataPlaneUrl.Value, rawData);
        }

        DataFactoryDataPlaneAccessPolicyResult IModelJsonSerializable<DataFactoryDataPlaneAccessPolicyResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataPlaneAccessPolicyResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFactoryDataPlaneAccessPolicyResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFactoryDataPlaneAccessPolicyResult IModelSerializable<DataFactoryDataPlaneAccessPolicyResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFactoryDataPlaneAccessPolicyResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataFactoryDataPlaneAccessPolicyResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataFactoryDataPlaneAccessPolicyResult"/> to convert. </param>
        public static implicit operator RequestContent(DataFactoryDataPlaneAccessPolicyResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataFactoryDataPlaneAccessPolicyResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataFactoryDataPlaneAccessPolicyResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFactoryDataPlaneAccessPolicyResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
