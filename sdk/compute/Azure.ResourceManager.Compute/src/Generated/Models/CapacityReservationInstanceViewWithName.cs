// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a capacity reservation that includes the name of the capacity reservation. It is used for the response to the instance view of a capacity reservation group. </summary>
    public partial class CapacityReservationInstanceViewWithName : CapacityReservationInstanceView
    {
        /// <summary> Initializes a new instance of <see cref="CapacityReservationInstanceViewWithName"/>. </summary>
        internal CapacityReservationInstanceViewWithName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationInstanceViewWithName"/>. </summary>
        /// <param name="utilizationInfo"> Unutilized capacity of the capacity reservation. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="name"> The name of the capacity reservation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CapacityReservationInstanceViewWithName(CapacityReservationUtilization utilizationInfo, IReadOnlyList<InstanceViewStatus> statuses, string name, Dictionary<string, BinaryData> rawData) : base(utilizationInfo, statuses, rawData)
        {
            Name = name;
        }

        /// <summary> The name of the capacity reservation. </summary>
        public string Name { get; }
    }
}
