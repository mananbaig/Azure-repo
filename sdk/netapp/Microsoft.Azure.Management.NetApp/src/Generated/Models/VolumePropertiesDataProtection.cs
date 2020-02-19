// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DataProtection
    /// </summary>
    /// <remarks>
    /// DataProtection type volumes include an object containing details of the
    /// replication
    /// </remarks>
    public partial class VolumePropertiesDataProtection
    {
        /// <summary>
        /// Initializes a new instance of the VolumePropertiesDataProtection
        /// class.
        /// </summary>
        public VolumePropertiesDataProtection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumePropertiesDataProtection
        /// class.
        /// </summary>
        /// <param name="replication">Replication</param>
        public VolumePropertiesDataProtection(ReplicationObject replication = default(ReplicationObject))
        {
            Replication = replication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets replication
        /// </summary>
        /// <remarks>
        /// Replication properties
        /// </remarks>
        [JsonProperty(PropertyName = "replication")]
        public ReplicationObject Replication { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Replication != null)
            {
                Replication.Validate();
            }
        }
    }
}
