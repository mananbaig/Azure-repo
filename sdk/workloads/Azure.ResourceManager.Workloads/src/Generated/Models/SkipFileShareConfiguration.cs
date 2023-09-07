// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the file share configuration for scenarios where transport directory fileshare is not created or required. </summary>
    public partial class SkipFileShareConfiguration : FileShareConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SkipFileShareConfiguration"/>. </summary>
        public SkipFileShareConfiguration()
        {
            ConfigurationType = ConfigurationType.Skip;
        }

        /// <summary> Initializes a new instance of <see cref="SkipFileShareConfiguration"/>. </summary>
        /// <param name="configurationType"> The type of file share config. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SkipFileShareConfiguration(ConfigurationType configurationType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(configurationType, serializedAdditionalRawData)
        {
            ConfigurationType = configurationType;
        }
    }
}
