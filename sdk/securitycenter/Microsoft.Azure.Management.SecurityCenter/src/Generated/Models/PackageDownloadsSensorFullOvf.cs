// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains all OVF (virtual machine) full versions for the sensor
    /// </summary>
    public partial class PackageDownloadsSensorFullOvf
    {
        /// <summary>
        /// Initializes a new instance of the PackageDownloadsSensorFullOvf
        /// class.
        /// </summary>
        public PackageDownloadsSensorFullOvf()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PackageDownloadsSensorFullOvf
        /// class.
        /// </summary>
        /// <param name="enterprise">Enterprise package type</param>
        /// <param name="medium">Medium package type</param>
        /// <param name="line">Line package type</param>
        public PackageDownloadsSensorFullOvf(IList<PackageDownloadInfo> enterprise = default(IList<PackageDownloadInfo>), IList<PackageDownloadInfo> medium = default(IList<PackageDownloadInfo>), IList<PackageDownloadInfo> line = default(IList<PackageDownloadInfo>))
        {
            Enterprise = enterprise;
            Medium = medium;
            Line = line;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets enterprise package type
        /// </summary>
        [JsonProperty(PropertyName = "enterprise")]
        public IList<PackageDownloadInfo> Enterprise { get; private set; }

        /// <summary>
        /// Gets medium package type
        /// </summary>
        [JsonProperty(PropertyName = "medium")]
        public IList<PackageDownloadInfo> Medium { get; private set; }

        /// <summary>
        /// Gets line package type
        /// </summary>
        [JsonProperty(PropertyName = "line")]
        public IList<PackageDownloadInfo> Line { get; private set; }

    }
}
