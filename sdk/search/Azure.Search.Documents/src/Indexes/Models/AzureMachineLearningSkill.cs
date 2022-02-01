﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using static System.Net.WebRequestMethods;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// <see href="https://docs.microsoft.com/azure/search/cognitive-search-aml-skill">AzureMachineLearningSkill</see> allows you to extend AI enrichment with a
    /// custom <see href="https://docs.microsoft.com/azure/machine-learning/overview-what-is-azure-machine-learning">Azure Machine Learning</see> (AML) model.
    /// <para>Once an AML model is <see href="https://docs.microsoft.com/azure/machine-learning/concept-azure-machine-learning-architecture#workspace">trained and deployed</see>,
    /// an AML skill integrates it into AI enrichment.</para>
    /// </summary>
    public partial class AzureMachineLearningSkill : IUtf8JsonSerializable
    {
        /// <summary>The key for the Azure Machine Learning service. This is required for key-based authentication.</summary>
        [CodeGenMember("AuthenticationKey")]
        public string AuthenticationKey { get; }

        /// <summary>The scoring URI of the Azure Machine Learning service to which the JSON payload will be sent.
        /// This is required when using no authentication or key-based authentication.
        /// <para>Only the https URI scheme is allowed.</para>
        /// </summary>
        [CodeGenMember("ScoringUri")]
        public Uri ScoringUri { get; }

        /// <summary>The <see href="https://docs.microsoft.com/dotnet/api/azure.core.resourceidentifier">Azure Resource Manager resource ID</see> of the Azure Machine Learning service.
        /// This is required for token-based authentication.
        /// <para>It should be in the format "subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.MachineLearningServices/workspaces/{workspace-name}/services/{service_name}".</para>
        /// </summary>
        [CodeGenMember("ResourceId")]
        public ResourceIdentifier ResourceId { get; }

        /// <summary> The <see href="https://docs.microsoft.com/dotnet/api/azure.core.azurelocation">region</see> the Azure Machine Learning service is deployed in.
        /// This is optional for token-based authentication.
        /// </summary>
        [CodeGenMember("Region")]
        public AzureLocation? Location { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureMachineLearningSkill"/> class.
        /// </summary>
        /// <param name="inputs">Inputs of the skills could be a column in the source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill.</param>
        /// <param name="authenticationKey">The key for the AML service.</param>
        /// <param name="scoringUri">The scoring URI of the AML service to which the JSON payload will be sent. Only the https URI scheme is allowed.</param>
        public AzureMachineLearningSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs, Uri scoringUri, string authenticationKey = default) :
            this(inputs, outputs)
        {
            ScoringUri = scoringUri ?? throw new ArgumentNullException(nameof(scoringUri));
            AuthenticationKey = authenticationKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureMachineLearningSkill"/> class.
        /// </summary>
        /// <param name="inputs">Inputs of the skills could be a column in the source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill.</param>
        /// <param name="resourceId">The Azure Resource Manager resource Id of the AML service.
        /// It should be in the format subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.MachineLearningServices/workspaces/{workspace-name}/services/{service_name}.</param>
        /// <param name="location">The region the AML service is deployed in.</param>
        public AzureMachineLearningSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs, ResourceIdentifier resourceId, AzureLocation? location = default) :
            this(inputs, outputs)
        {
            ResourceId = resourceId ?? throw new ArgumentNullException(nameof(resourceId));
            Location = location;
        }

        /// <summary> Initializes a new instance of AmlSkill. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        internal AzureMachineLearningSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (outputs == null)
            {
                throw new ArgumentNullException(nameof(outputs));
            }

            ODataType = "#Microsoft.Skills.Custom.AmlSkill";
        }

        void global::Azure.Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScoringUri))
            {
                if (ScoringUri != null)
                {
                    writer.WritePropertyName("uri");
                    writer.WriteStringValue(ScoringUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("uri");
                }
            }
            if (Optional.IsDefined(AuthenticationKey))
            {
                if (AuthenticationKey != null)
                {
                    writer.WritePropertyName("key");
                    writer.WriteStringValue(AuthenticationKey);
                }
                else
                {
                    writer.WriteNull("key");
                }
            }
            if (Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId");
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout");
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("region");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(DegreeOfParallelism))
            {
                if (DegreeOfParallelism != null)
                {
                    writer.WritePropertyName("degreeOfParallelism");
                    writer.WriteNumberValue(DegreeOfParallelism.Value);
                }
                else
                {
                    writer.WriteNull("degreeOfParallelism");
                }
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context");
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs");
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static AzureMachineLearningSkill DeserializeAzureMachineLearningSkill(JsonElement element)
        {
            Optional<Uri> uri = default;
            Optional<string> key = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<TimeSpan?> timeout = default;
            Optional<AzureLocation?> region = default;
            Optional<int?> degreeOfParallelism = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        key = null;
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("region"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        region = null;
                        continue;
                    }
                    region = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("degreeOfParallelism"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        degreeOfParallelism = null;
                        continue;
                    }
                    degreeOfParallelism = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
            }
            return new AzureMachineLearningSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, uri.Value, key.Value, resourceId.Value, Optional.ToNullable(timeout), region, Optional.ToNullable(degreeOfParallelism));
        }
    }
}
