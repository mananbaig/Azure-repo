// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Configuration Options for Spot instances in Azure Fleet. </summary>
    public partial class SpotPriorityProfile
    {
        /// <summary> Initializes a new instance of <see cref="SpotPriorityProfile"/>. </summary>
        public SpotPriorityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SpotPriorityProfile"/>. </summary>
        /// <param name="capacity"> Total capacity to achieve. It is currently in terms of number of VMs. </param>
        /// <param name="minCapacity"> Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject the request in the sync path itself. </param>
        /// <param name="maxPricePerVm"> Price per hour of each Spot VM will never exceed this. </param>
        /// <param name="evictionPolicy"> Eviction Policy to follow when evicting Spot VMs. </param>
        /// <param name="allocationStrategy"> Allocation strategy to follow when determining the sku split for Spot VMs. </param>
        internal SpotPriorityProfile(int? capacity, int? minCapacity, float? maxPricePerVm, EvictionPolicy? evictionPolicy, SpotAllocationStrategy? allocationStrategy)
        {
            Capacity = capacity;
            MinCapacity = minCapacity;
            MaxPricePerVm = maxPricePerVm;
            EvictionPolicy = evictionPolicy;
            AllocationStrategy = allocationStrategy;
        }

        /// <summary> Total capacity to achieve. It is currently in terms of number of VMs. </summary>
        public int? Capacity { get; set; }
        /// <summary> Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject the request in the sync path itself. </summary>
        public int? MinCapacity { get; set; }
        /// <summary> Price per hour of each Spot VM will never exceed this. </summary>
        public float? MaxPricePerVm { get; set; }
        /// <summary> Eviction Policy to follow when evicting Spot VMs. </summary>
        public EvictionPolicy? EvictionPolicy { get; set; }
        /// <summary> Allocation strategy to follow when determining the sku split for Spot VMs. </summary>
        public SpotAllocationStrategy? AllocationStrategy { get; set; }
    }
}
