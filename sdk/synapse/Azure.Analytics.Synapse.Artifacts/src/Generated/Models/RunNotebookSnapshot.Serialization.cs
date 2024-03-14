// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunNotebookSnapshotConverter))]
    public partial class RunNotebookSnapshot
    {
        internal static RunNotebookSnapshot DeserializeRunNotebookSnapshot(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string exitValue = default;
            string id = default;
            string notebook = default;
            RunNotebookSparkSessionOptions sessionOptions = default;
            bool? honorSessionTimeToLive = default;
            string sessionId = default;
            string sparkPool = default;
            IReadOnlyDictionary<string, RunNotebookParameter> parameters = default;
            NotebookResource notebookContent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exitValue"u8))
                {
                    exitValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notebook"u8))
                {
                    notebook = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionOptions = RunNotebookSparkSessionOptions.DeserializeRunNotebookSparkSessionOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("honorSessionTimeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    honorSessionTimeToLive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPool"u8))
                {
                    sparkPool = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RunNotebookParameter> dictionary = new Dictionary<string, RunNotebookParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, RunNotebookParameter.DeserializeRunNotebookParameter(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("notebookContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notebookContent = NotebookResource.DeserializeNotebookResource(property.Value);
                    continue;
                }
            }
            return new RunNotebookSnapshot(
                exitValue,
                id,
                notebook,
                sessionOptions,
                honorSessionTimeToLive,
                sessionId,
                sparkPool,
                parameters ?? new ChangeTrackingDictionary<string, RunNotebookParameter>(),
                notebookContent);
        }

        internal partial class RunNotebookSnapshotConverter : JsonConverter<RunNotebookSnapshot>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookSnapshot model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override RunNotebookSnapshot Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookSnapshot(document.RootElement);
            }
        }
    }
}
