// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Represents the health policy used to evaluate the health of services belonging to a service type.
    ///
    /// </summary>
    public partial class ServiceTypeHealthPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceTypeHealthPolicy"/>. </summary>
        public ServiceTypeHealthPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceTypeHealthPolicy"/>. </summary>
        /// <param name="maxPercentUnhealthyServices">
        /// The maximum percentage of services allowed to be unhealthy before your application is considered in error.
        ///
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceTypeHealthPolicy(int? maxPercentUnhealthyServices, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxPercentUnhealthyServices = maxPercentUnhealthyServices;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The maximum percentage of services allowed to be unhealthy before your application is considered in error.
        ///
        /// </summary>
        public int? MaxPercentUnhealthyServices { get; set; }
    }
}
