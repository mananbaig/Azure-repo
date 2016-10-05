// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Contains the os disk image information.
    /// </summary>
    public partial class OSDiskImage
    {
        /// <summary>
        /// Initializes a new instance of the OSDiskImage class.
        /// </summary>
        public OSDiskImage() { }

        /// <summary>
        /// Initializes a new instance of the OSDiskImage class.
        /// </summary>
        /// <param name="operatingSystem">the operating system of the
        /// osDiskImage. Possible values include: 'Windows', 'Linux'</param>
        public OSDiskImage(OperatingSystemTypes? operatingSystem)
        {
            OperatingSystem = operatingSystem;
        }

        /// <summary>
        /// Gets or sets the operating system of the osDiskImage. Possible
        /// values include: 'Windows', 'Linux'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operatingSystem")]
        public OperatingSystemTypes? OperatingSystem { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
