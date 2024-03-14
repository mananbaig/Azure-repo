// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Unknown version of TaskStepProperties. </summary>
    internal partial class UnknownTaskStepProperties : ContainerRegistryTaskStepProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTaskStepProperties"/>. </summary>
        /// <param name="containerRegistryTaskStepType"> The type of the step. </param>
        /// <param name="baseImageDependencies"> List of base image dependencies for a step. </param>
        /// <param name="contextPath"> The URL(absolute or relative) of the source context for the task step. </param>
        /// <param name="contextAccessToken"> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTaskStepProperties(ContainerRegistryTaskStepType containerRegistryTaskStepType, IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies, string contextPath, string contextAccessToken, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(containerRegistryTaskStepType, baseImageDependencies, contextPath, contextAccessToken, serializedAdditionalRawData)
        {
            ContainerRegistryTaskStepType = containerRegistryTaskStepType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTaskStepProperties"/> for deserialization. </summary>
        internal UnknownTaskStepProperties()
        {
        }
    }
}
