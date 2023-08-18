// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class TrainResult
    {
        internal static TrainResult DeserializeTrainResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TrainingDocumentInfo> trainingDocuments = default;
            Core.Optional<IReadOnlyList<CustomFormModelField>> fields = default;
            Core.Optional<float> averageModelAccuracy = default;
            Core.Optional<string> modelId = default;
            Core.Optional<IReadOnlyList<FormRecognizerError>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trainingDocuments"u8))
                {
                    List<TrainingDocumentInfo> array = new List<TrainingDocumentInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrainingDocumentInfo.DeserializeTrainingDocumentInfo(item));
                    }
                    trainingDocuments = array;
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomFormModelField> array = new List<CustomFormModelField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomFormModelField.DeserializeCustomFormModelField(item));
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("averageModelAccuracy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    averageModelAccuracy = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new TrainResult(trainingDocuments, Core.Optional.ToList(fields), Core.Optional.ToNullable(averageModelAccuracy), modelId.Value, Core.Optional.ToList(errors));
        }
    }
}
