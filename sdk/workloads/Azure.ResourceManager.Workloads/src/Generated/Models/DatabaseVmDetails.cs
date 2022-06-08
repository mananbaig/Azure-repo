// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The Database VM Details. </summary>
    public partial class DatabaseVmDetails
    {
        /// <summary> Initializes a new instance of <see cref="DatabaseVmDetails"/>. </summary>
        internal DatabaseVmDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseVmDetails"/>. </summary>
        /// <param name="virtualMachineId"></param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        internal DatabaseVmDetails(ResourceIdentifier virtualMachineId, SapVirtualInstanceStatus? status)
        {
            VirtualMachineId = virtualMachineId;
            Status = status;
        }

        /// <summary> Gets the virtual machine id. </summary>
        public ResourceIdentifier VirtualMachineId { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
    }
}
