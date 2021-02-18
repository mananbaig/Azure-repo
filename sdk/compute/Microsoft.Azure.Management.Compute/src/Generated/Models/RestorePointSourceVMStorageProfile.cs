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
    /// Describes the storage profile.
    /// </summary>
    public partial class RestorePointSourceVMStorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RestorePointSourceVMStorageProfile class.
        /// </summary>
        public RestorePointSourceVMStorageProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RestorePointSourceVMStorageProfile class.
        /// </summary>
        /// <param name="osDisk">Gets the OS disk of the VM captured at the
        /// time of creation of restore point.</param>
        /// <param name="dataDisks">Gets the data disks of the VM captured at
        /// the time of creation of restore point.</param>
        public RestorePointSourceVMStorageProfile(RestorePointSourceVMOSDisk osDisk = default(RestorePointSourceVMOSDisk), IList<RestorePointSourceVMDataDisk> dataDisks = default(IList<RestorePointSourceVMDataDisk>))
        {
            OsDisk = osDisk;
            DataDisks = dataDisks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the OS disk of the VM captured at the time of creation of
        /// restore point.
        /// </summary>
        [JsonProperty(PropertyName = "osDisk")]
        public RestorePointSourceVMOSDisk OsDisk { get; set; }

        /// <summary>
        /// Gets the data disks of the VM captured at the time of creation of
        /// restore point.
        /// </summary>
        [JsonProperty(PropertyName = "dataDisks")]
        public IList<RestorePointSourceVMDataDisk> DataDisks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OsDisk != null)
            {
                OsDisk.Validate();
            }
        }
    }
}
