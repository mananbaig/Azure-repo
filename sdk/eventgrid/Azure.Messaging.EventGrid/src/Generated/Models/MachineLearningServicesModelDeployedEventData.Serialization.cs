// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MachineLearningServicesModelDeployedEventDataConverter))]
    public partial class MachineLearningServicesModelDeployedEventData
    {
        internal static MachineLearningServicesModelDeployedEventData DeserializeMachineLearningServicesModelDeployedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> serviceName = default;
            Core.Optional<string> serviceComputeType = default;
            Core.Optional<string> modelIds = default;
            Core.Optional<object> serviceTags = default;
            Core.Optional<object> serviceProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceComputeType"u8))
                {
                    serviceComputeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelIds"u8))
                {
                    modelIds = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTags = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("serviceProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceProperties = property.Value.GetObject();
                    continue;
                }
            }
            return new MachineLearningServicesModelDeployedEventData(serviceName.Value, serviceComputeType.Value, modelIds.Value, serviceTags.Value, serviceProperties.Value);
        }

        internal partial class MachineLearningServicesModelDeployedEventDataConverter : JsonConverter<MachineLearningServicesModelDeployedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MachineLearningServicesModelDeployedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MachineLearningServicesModelDeployedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMachineLearningServicesModelDeployedEventData(document.RootElement);
            }
        }
    }
}
