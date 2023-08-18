// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageClassification : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric"u8);
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Core.Optional.IsDefined(ModelSettings))
            {
                if (ModelSettings != null)
                {
                    writer.WritePropertyName("modelSettings"u8);
                    writer.WriteObjectValue(ModelSettings);
                }
                else
                {
                    writer.WriteNull("modelSettings");
                }
            }
            if (Core.Optional.IsCollectionDefined(SearchSpace))
            {
                if (SearchSpace != null)
                {
                    writer.WritePropertyName("searchSpace"u8);
                    writer.WriteStartArray();
                    foreach (var item in SearchSpace)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("searchSpace");
                }
            }
            writer.WritePropertyName("limitSettings"u8);
            writer.WriteObjectValue(LimitSettings);
            if (Core.Optional.IsDefined(SweepSettings))
            {
                if (SweepSettings != null)
                {
                    writer.WritePropertyName("sweepSettings"u8);
                    writer.WriteObjectValue(SweepSettings);
                }
                else
                {
                    writer.WriteNull("sweepSettings");
                }
            }
            if (Core.Optional.IsDefined(ValidationData))
            {
                if (ValidationData != null)
                {
                    writer.WritePropertyName("validationData"u8);
                    writer.WriteObjectValue(ValidationData);
                }
                else
                {
                    writer.WriteNull("validationData");
                }
            }
            if (Core.Optional.IsDefined(ValidationDataSize))
            {
                if (ValidationDataSize != null)
                {
                    writer.WritePropertyName("validationDataSize"u8);
                    writer.WriteNumberValue(ValidationDataSize.Value);
                }
                else
                {
                    writer.WriteNull("validationDataSize");
                }
            }
            if (Core.Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            if (Core.Optional.IsDefined(TargetColumnName))
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData);
            writer.WriteEndObject();
        }

        internal static ImageClassification DeserializeImageClassification(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ClassificationPrimaryMetric> primaryMetric = default;
            Core.Optional<ImageModelSettingsClassification> modelSettings = default;
            Core.Optional<IList<ImageModelDistributionSettingsClassification>> searchSpace = default;
            ImageLimitSettings limitSettings = default;
            Core.Optional<ImageSweepSettings> sweepSettings = default;
            Core.Optional<MachineLearningTableJobInput> validationData = default;
            Core.Optional<double?> validationDataSize = default;
            Core.Optional<MachineLearningLogVerbosity> logVerbosity = default;
            Core.Optional<string> targetColumnName = default;
            TaskType taskType = default;
            MachineLearningTableJobInput trainingData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryMetric = new ClassificationPrimaryMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelSettings = null;
                        continue;
                    }
                    modelSettings = ImageModelSettingsClassification.DeserializeImageModelSettingsClassification(property.Value);
                    continue;
                }
                if (property.NameEquals("searchSpace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchSpace = null;
                        continue;
                    }
                    List<ImageModelDistributionSettingsClassification> array = new List<ImageModelDistributionSettingsClassification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImageModelDistributionSettingsClassification.DeserializeImageModelDistributionSettingsClassification(item));
                    }
                    searchSpace = array;
                    continue;
                }
                if (property.NameEquals("limitSettings"u8))
                {
                    limitSettings = ImageLimitSettings.DeserializeImageLimitSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sweepSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sweepSettings = null;
                        continue;
                    }
                    sweepSettings = ImageSweepSettings.DeserializeImageSweepSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("validationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationData = null;
                        continue;
                    }
                    validationData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value);
                    continue;
                }
                if (property.NameEquals("validationDataSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationDataSize = null;
                        continue;
                    }
                    validationDataSize = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("logVerbosity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logVerbosity = new MachineLearningLogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetColumnName = null;
                        continue;
                    }
                    targetColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trainingData"u8))
                {
                    trainingData = MachineLearningTableJobInput.DeserializeMachineLearningTableJobInput(property.Value);
                    continue;
                }
            }
            return new ImageClassification(Core.Optional.ToNullable(logVerbosity), targetColumnName.Value, taskType, trainingData, Core.Optional.ToNullable(primaryMetric), modelSettings.Value, Core.Optional.ToList(searchSpace), limitSettings, sweepSettings.Value, validationData.Value, Core.Optional.ToNullable(validationDataSize));
        }
    }
}
