// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Version related deatils.
    /// </summary>
    public partial class VersionDetails
    {
        /// <summary>
        /// Initializes a new instance of the VersionDetails class.
        /// </summary>
        public VersionDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VersionDetails class.
        /// </summary>
        /// <param name="version">The agent version.</param>
        /// <param name="expiryDate">Version expiry date.</param>
        /// <param name="status">A value indicating whether security update
        /// required. Possible values include: 'Supported', 'NotSupported',
        /// 'Deprecated', 'UpdateRequired', 'SecurityUpdateRequired'</param>
        public VersionDetails(string version = default(string), System.DateTime? expiryDate = default(System.DateTime?), AgentVersionStatus? status = default(AgentVersionStatus?))
        {
            Version = version;
            ExpiryDate = expiryDate;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets version expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "expiryDate")]
        public System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether security update required.
        /// Possible values include: 'Supported', 'NotSupported', 'Deprecated',
        /// 'UpdateRequired', 'SecurityUpdateRequired'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AgentVersionStatus? Status { get; set; }

    }
}
