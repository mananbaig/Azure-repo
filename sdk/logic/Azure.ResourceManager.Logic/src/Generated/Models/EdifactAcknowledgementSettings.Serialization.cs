// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactAcknowledgementSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("needTechnicalAcknowledgement");
            writer.WriteBooleanValue(NeedTechnicalAcknowledgement);
            writer.WritePropertyName("batchTechnicalAcknowledgements");
            writer.WriteBooleanValue(BatchTechnicalAcknowledgements);
            writer.WritePropertyName("needFunctionalAcknowledgement");
            writer.WriteBooleanValue(NeedFunctionalAcknowledgement);
            writer.WritePropertyName("batchFunctionalAcknowledgements");
            writer.WriteBooleanValue(BatchFunctionalAcknowledgements);
            writer.WritePropertyName("needLoopForValidMessages");
            writer.WriteBooleanValue(NeedLoopForValidMessages);
            writer.WritePropertyName("sendSynchronousAcknowledgement");
            writer.WriteBooleanValue(SendSynchronousAcknowledgement);
            if (Optional.IsDefined(AcknowledgementControlNumberPrefix))
            {
                writer.WritePropertyName("acknowledgementControlNumberPrefix");
                writer.WriteStringValue(AcknowledgementControlNumberPrefix);
            }
            if (Optional.IsDefined(AcknowledgementControlNumberSuffix))
            {
                writer.WritePropertyName("acknowledgementControlNumberSuffix");
                writer.WriteStringValue(AcknowledgementControlNumberSuffix);
            }
            writer.WritePropertyName("acknowledgementControlNumberLowerBound");
            writer.WriteNumberValue(AcknowledgementControlNumberLowerBound);
            writer.WritePropertyName("acknowledgementControlNumberUpperBound");
            writer.WriteNumberValue(AcknowledgementControlNumberUpperBound);
            writer.WritePropertyName("rolloverAcknowledgementControlNumber");
            writer.WriteBooleanValue(RolloverAcknowledgementControlNumber);
            writer.WriteEndObject();
        }

        internal static EdifactAcknowledgementSettings DeserializeEdifactAcknowledgementSettings(JsonElement element)
        {
            bool needTechnicalAcknowledgement = default;
            bool batchTechnicalAcknowledgements = default;
            bool needFunctionalAcknowledgement = default;
            bool batchFunctionalAcknowledgements = default;
            bool needLoopForValidMessages = default;
            bool sendSynchronousAcknowledgement = default;
            Optional<string> acknowledgementControlNumberPrefix = default;
            Optional<string> acknowledgementControlNumberSuffix = default;
            int acknowledgementControlNumberLowerBound = default;
            int acknowledgementControlNumberUpperBound = default;
            bool rolloverAcknowledgementControlNumber = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("needTechnicalAcknowledgement"))
                {
                    needTechnicalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("batchTechnicalAcknowledgements"))
                {
                    batchTechnicalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needFunctionalAcknowledgement"))
                {
                    needFunctionalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("batchFunctionalAcknowledgements"))
                {
                    batchFunctionalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needLoopForValidMessages"))
                {
                    needLoopForValidMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendSynchronousAcknowledgement"))
                {
                    sendSynchronousAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberPrefix"))
                {
                    acknowledgementControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberSuffix"))
                {
                    acknowledgementControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberLowerBound"))
                {
                    acknowledgementControlNumberLowerBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberUpperBound"))
                {
                    acknowledgementControlNumberUpperBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rolloverAcknowledgementControlNumber"))
                {
                    rolloverAcknowledgementControlNumber = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EdifactAcknowledgementSettings(needTechnicalAcknowledgement, batchTechnicalAcknowledgements, needFunctionalAcknowledgement, batchFunctionalAcknowledgements, needLoopForValidMessages, sendSynchronousAcknowledgement, acknowledgementControlNumberPrefix.Value, acknowledgementControlNumberSuffix.Value, acknowledgementControlNumberLowerBound, acknowledgementControlNumberUpperBound, rolloverAcknowledgementControlNumber);
        }
    }
}
