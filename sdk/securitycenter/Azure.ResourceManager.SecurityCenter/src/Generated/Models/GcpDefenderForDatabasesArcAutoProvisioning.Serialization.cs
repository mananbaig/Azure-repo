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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpDefenderForDatabasesArcAutoProvisioning : IUtf8JsonSerializable, IModelJsonSerializable<GcpDefenderForDatabasesArcAutoProvisioning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GcpDefenderForDatabasesArcAutoProvisioning>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GcpDefenderForDatabasesArcAutoProvisioning>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpDefenderForDatabasesArcAutoProvisioning>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
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

        internal static GcpDefenderForDatabasesArcAutoProvisioning DeserializeGcpDefenderForDatabasesArcAutoProvisioning(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceAccountEmailAddress = default;
            Optional<string> workloadIdentityProviderId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GcpDefenderForDatabasesArcAutoProvisioning(serviceAccountEmailAddress.Value, workloadIdentityProviderId.Value, serializedAdditionalRawData);
        }

        GcpDefenderForDatabasesArcAutoProvisioning IModelJsonSerializable<GcpDefenderForDatabasesArcAutoProvisioning>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpDefenderForDatabasesArcAutoProvisioning>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpDefenderForDatabasesArcAutoProvisioning(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GcpDefenderForDatabasesArcAutoProvisioning>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpDefenderForDatabasesArcAutoProvisioning>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GcpDefenderForDatabasesArcAutoProvisioning IModelSerializable<GcpDefenderForDatabasesArcAutoProvisioning>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GcpDefenderForDatabasesArcAutoProvisioning>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGcpDefenderForDatabasesArcAutoProvisioning(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GcpDefenderForDatabasesArcAutoProvisioning"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GcpDefenderForDatabasesArcAutoProvisioning"/> to convert. </param>
        public static implicit operator RequestContent(GcpDefenderForDatabasesArcAutoProvisioning model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GcpDefenderForDatabasesArcAutoProvisioning"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GcpDefenderForDatabasesArcAutoProvisioning(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGcpDefenderForDatabasesArcAutoProvisioning(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
