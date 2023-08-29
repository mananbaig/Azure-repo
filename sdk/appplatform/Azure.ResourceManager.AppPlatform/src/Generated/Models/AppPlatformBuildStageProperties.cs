// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The build stage (init-container and container) resources in build pod. </summary>
    public partial class AppPlatformBuildStageProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildStageProperties"/>. </summary>
        internal AppPlatformBuildStageProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildStageProperties"/>. </summary>
        /// <param name="name"> The name of this build stage resource. </param>
        /// <param name="status"> The provisioning state of this build stage resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformBuildStageProperties(string name, KPackBuildStageProvisioningState? status, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> The name of this build stage resource. </summary>
        public string Name { get; }
        /// <summary> The provisioning state of this build stage resource. </summary>
        public KPackBuildStageProvisioningState? Status { get; }
    }
}
