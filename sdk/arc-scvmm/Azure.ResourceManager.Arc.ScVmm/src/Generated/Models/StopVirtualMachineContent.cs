// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Arc.ScVmm.Models
{
    /// <summary> Defines the stop action properties. </summary>
    public partial class StopVirtualMachineContent
    {
        /// <summary> Initializes a new instance of StopVirtualMachineContent. </summary>
        public StopVirtualMachineContent()
        {
        }

        /// <summary> Gets or sets a value indicating whether to request non-graceful VM shutdown. True value for this flag indicates non-graceful shutdown whereas false indicates otherwise. Defaults to false. </summary>
        public bool? SkipShutdown { get; set; }
    }
}
