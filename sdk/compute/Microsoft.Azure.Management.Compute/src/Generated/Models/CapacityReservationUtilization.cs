// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Capacity Reservation utilized capacity.
    /// </summary>
    public partial class CapacityReservationUtilization
    {
        /// <summary>
        /// Initializes a new instance of the CapacityReservationUtilization
        /// class.
        /// </summary>
        public CapacityReservationUtilization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityReservationUtilization
        /// class.
        /// </summary>
        /// <param name="virtualMachinesAllocated">A list of references to all
        /// virtual machines allocated in the Capacity reservation.</param>
        public CapacityReservationUtilization(IList<SubResourceReadOnly> virtualMachinesAllocated = default(IList<SubResourceReadOnly>))
        {
            VirtualMachinesAllocated = virtualMachinesAllocated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of references to all virtual machines allocated in the
        /// Capacity reservation.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachinesAllocated")]
        public IList<SubResourceReadOnly> VirtualMachinesAllocated { get; private set; }

    }
}
