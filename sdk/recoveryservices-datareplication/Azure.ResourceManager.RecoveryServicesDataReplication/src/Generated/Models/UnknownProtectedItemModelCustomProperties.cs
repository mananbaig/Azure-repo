// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Unknown version of ProtectedItemModelCustomProperties. </summary>
    internal partial class UnknownProtectedItemModelCustomProperties : ProtectedItemModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownProtectedItemModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownProtectedItemModelCustomProperties(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownProtectedItemModelCustomProperties"/> for deserialization. </summary>
        internal UnknownProtectedItemModelCustomProperties()
        {
        }
    }
}
