// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A flag to indicate where the container task working directory is. The default is &apos;taskWorkingDirectory&apos;. </summary>
    public enum BatchContainerWorkingDirectory
    {
        /// <summary> Use the standard Batch service task working directory, which will contain the Task resource files populated by Batch. </summary>
        TaskWorkingDirectory,
        /// <summary> Using container image defined working directory. Beware that this directory will not contain the resource files downloaded by Batch. </summary>
        ContainerImageDefault
    }
}
