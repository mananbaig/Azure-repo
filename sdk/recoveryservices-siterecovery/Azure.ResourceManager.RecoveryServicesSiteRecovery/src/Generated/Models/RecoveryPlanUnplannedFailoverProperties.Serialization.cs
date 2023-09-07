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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanUnplannedFailoverProperties : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryPlanUnplannedFailoverProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryPlanUnplannedFailoverProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryPlanUnplannedFailoverProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanUnplannedFailoverProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("failoverDirection"u8);
            writer.WriteStringValue(FailoverDirection.ToString());
            writer.WritePropertyName("sourceSiteOperations"u8);
            writer.WriteStringValue(SourceSiteOperation.ToString());
            if (Optional.IsCollectionDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RecoveryPlanProviderSpecificFailoverContent>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static RecoveryPlanUnplannedFailoverProperties DeserializeRecoveryPlanUnplannedFailoverProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PossibleOperationsDirection failoverDirection = default;
            SourceSiteOperation sourceSiteOperations = default;
            Optional<IList<RecoveryPlanProviderSpecificFailoverContent>> providerSpecificDetails = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverDirection"u8))
                {
                    failoverDirection = new PossibleOperationsDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceSiteOperations"u8))
                {
                    sourceSiteOperations = new SourceSiteOperation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProviderSpecificFailoverContent> array = new List<RecoveryPlanProviderSpecificFailoverContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProviderSpecificFailoverContent.DeserializeRecoveryPlanProviderSpecificFailoverContent(item));
                    }
                    providerSpecificDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecoveryPlanUnplannedFailoverProperties(failoverDirection, sourceSiteOperations, Optional.ToList(providerSpecificDetails), serializedAdditionalRawData);
        }

        RecoveryPlanUnplannedFailoverProperties IModelJsonSerializable<RecoveryPlanUnplannedFailoverProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanUnplannedFailoverProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanUnplannedFailoverProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryPlanUnplannedFailoverProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanUnplannedFailoverProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryPlanUnplannedFailoverProperties IModelSerializable<RecoveryPlanUnplannedFailoverProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryPlanUnplannedFailoverProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryPlanUnplannedFailoverProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecoveryPlanUnplannedFailoverProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecoveryPlanUnplannedFailoverProperties"/> to convert. </param>
        public static implicit operator RequestContent(RecoveryPlanUnplannedFailoverProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecoveryPlanUnplannedFailoverProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecoveryPlanUnplannedFailoverProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryPlanUnplannedFailoverProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
