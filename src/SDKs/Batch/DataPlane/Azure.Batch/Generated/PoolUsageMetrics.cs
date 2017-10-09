// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The usage metrics for a single pool in a certain time range.
    /// </summary>
    public partial class PoolUsageMetrics : IPropertyMetadata
    {
        #region Constructors

        internal PoolUsageMetrics(Models.PoolUsageMetrics protocolObject)
        {
            this.DataEgressGiB = protocolObject.DataEgressGiB;
            this.DataIngressGiB = protocolObject.DataIngressGiB;
            this.EndTime = protocolObject.EndTime;
            this.PoolId = protocolObject.PoolId;
            this.StartTime = protocolObject.StartTime;
            this.TotalCoreHours = protocolObject.TotalCoreHours;
            this.VirtualMachineSize = protocolObject.VmSize;
        }

        #endregion Constructors

        #region PoolUsageMetrics

        /// <summary>
        /// Gets the cross data center network egress from the pool during this interval, in gibibytes.
        /// </summary>
        public double DataEgressGiB { get; }

        /// <summary>
        /// Gets the cross data center network ingress to the pool during this interval, in gibibytes.
        /// </summary>
        public double DataIngressGiB { get; }

        /// <summary>
        /// Gets the end time of the aggregation interval for this entry.
        /// </summary>
        public DateTime EndTime { get; }

        /// <summary>
        /// Gets the id of the pool whose metrics are aggregated in this entry.
        /// </summary>
        public string PoolId { get; }

        /// <summary>
        /// Gets the start time of the aggregation interval covered by this entry.
        /// </summary>
        public DateTime StartTime { get; }

        /// <summary>
        /// Gets the total core hours used in the pool during this aggregation interval.
        /// </summary>
        public double TotalCoreHours { get; }

        /// <summary>
        /// Gets the size of the virtual machines in the pool.  All virtual machines in a pool are the same size.
        /// </summary>
        /// <remarks>
        /// <para>For information about available sizes of virtual machines for Cloud Services pools (pools created with 
        /// a <see cref="CloudServiceConfiguration"/>), see https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/. 
        /// Batch supports all Cloud Services VM sizes except ExtraSmall.</para><para>For information about available VM 
        /// sizes for pools using images from the Virtual Machines Marketplace (pools created with a <see cref="VirtualMachineConfiguration"/>) 
        /// see https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/ or https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/. 
        /// Batch supports all Azure VM sizes except STANDARD_A0 and those with premium storage (for example STANDARD_GS, 
        /// STANDARD_DS, and STANDARD_DSV2 series).</para>
        /// </remarks>
        public string VirtualMachineSize { get; }

        #endregion // PoolUsageMetrics

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}