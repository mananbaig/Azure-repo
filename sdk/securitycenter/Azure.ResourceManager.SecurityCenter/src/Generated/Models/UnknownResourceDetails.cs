// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The UnknownResourceDetails. </summary>
    internal partial class UnknownResourceDetails : SecurityCenterResourceDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownResourceDetails"/>. </summary>
        /// <param name="source"> The platform where the assessed resource resides. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownResourceDetails(Source source, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(source, serializedAdditionalRawData)
        {
            Source = source;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownResourceDetails"/> for deserialization. </summary>
        internal UnknownResourceDetails()
        {
        }
    }
}
