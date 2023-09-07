// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownSoftwareConfiguration. </summary>
    internal partial class UnknownSoftwareConfiguration : SapSoftwareConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSoftwareConfiguration"/>. </summary>
        /// <param name="softwareInstallationType"> The SAP software installation Type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSoftwareConfiguration(SapSoftwareInstallationType softwareInstallationType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(softwareInstallationType, serializedAdditionalRawData)
        {
            SoftwareInstallationType = softwareInstallationType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSoftwareConfiguration"/> for deserialization. </summary>
        internal UnknownSoftwareConfiguration()
        {
        }
    }
}
