// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a encoded task step. </summary>
    public partial class ContainerRegistryEncodedTaskStep : ContainerRegistryTaskStepProperties
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncodedTaskStep"/>. </summary>
        /// <param name="encodedTaskContent"> Base64 encoded value of the template/definition file content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="encodedTaskContent"/> is null. </exception>
        public ContainerRegistryEncodedTaskStep(string encodedTaskContent)
        {
            Argument.AssertNotNull(encodedTaskContent, nameof(encodedTaskContent));

            EncodedTaskContent = encodedTaskContent;
            Values = new ChangeTrackingList<ContainerRegistryTaskOverridableValue>();
            ContainerRegistryTaskStepType = ContainerRegistryTaskStepType.EncodedTask;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncodedTaskStep"/>. </summary>
        /// <param name="containerRegistryTaskStepType"> The type of the step. </param>
        /// <param name="baseImageDependencies"> List of base image dependencies for a step. </param>
        /// <param name="contextPath"> The URL(absolute or relative) of the source context for the task step. </param>
        /// <param name="contextAccessToken"> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </param>
        /// <param name="encodedTaskContent"> Base64 encoded value of the template/definition file content. </param>
        /// <param name="encodedValuesContent"> Base64 encoded value of the parameters/values file content. </param>
        /// <param name="values"> The collection of overridable values that can be passed when running a task. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryEncodedTaskStep(ContainerRegistryTaskStepType containerRegistryTaskStepType, IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies, string contextPath, string contextAccessToken, string encodedTaskContent, string encodedValuesContent, IList<ContainerRegistryTaskOverridableValue> values, Dictionary<string, BinaryData> rawData) : base(containerRegistryTaskStepType, baseImageDependencies, contextPath, contextAccessToken, rawData)
        {
            EncodedTaskContent = encodedTaskContent;
            EncodedValuesContent = encodedValuesContent;
            Values = values;
            ContainerRegistryTaskStepType = containerRegistryTaskStepType;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEncodedTaskStep"/> for deserialization. </summary>
        internal ContainerRegistryEncodedTaskStep()
        {
        }

        /// <summary> Base64 encoded value of the template/definition file content. </summary>
        public string EncodedTaskContent { get; set; }
        /// <summary> Base64 encoded value of the parameters/values file content. </summary>
        public string EncodedValuesContent { get; set; }
        /// <summary> The collection of overridable values that can be passed when running a task. </summary>
        public IList<ContainerRegistryTaskOverridableValue> Values { get; }
    }
}
