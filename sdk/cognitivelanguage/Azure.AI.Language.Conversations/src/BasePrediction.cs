﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    public partial class BasePrediction
    {
        internal static BasePrediction DeserializeBasePrediction(JsonElement element)
        {
            if (element.TryGetProperty("projectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "workflow":
                        return WorkflowPrediction.DeserializeWorkflowPrediction(element);
                    case "conversation":
                        return DeepstackPrediction.DeserializeDeepstackPrediction(element);
                }
            }
            ProjectKind projectKind = default;
            Optional<string> topIntent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectKind"))
                {
                    projectKind = new ProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("topIntent"))
                {
                    topIntent = property.Value.GetString();
                    continue;
                }
            }
            return new BasePrediction(projectKind, topIntent.Value);
        }
    }
}
