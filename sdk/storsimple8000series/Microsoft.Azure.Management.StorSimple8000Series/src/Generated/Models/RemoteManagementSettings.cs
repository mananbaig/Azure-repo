// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple8000Series.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The settings for remote management of a device.
    /// </summary>
    public partial class RemoteManagementSettings
    {
        /// <summary>
        /// Initializes a new instance of the RemoteManagementSettings class.
        /// </summary>
        public RemoteManagementSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RemoteManagementSettings class.
        /// </summary>
        /// <param name="remoteManagementMode">The remote management mode.
        /// Possible values include: 'Unknown', 'Disabled', 'HttpsEnabled',
        /// 'HttpsAndHttpEnabled'</param>
        /// <param name="remoteManagementCertificate">The remote management
        /// certificates.</param>
        public RemoteManagementSettings(RemoteManagementModeConfiguration remoteManagementMode, string remoteManagementCertificate = default(string))
        {
            RemoteManagementMode = remoteManagementMode;
            RemoteManagementCertificate = remoteManagementCertificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the remote management mode. Possible values include:
        /// 'Unknown', 'Disabled', 'HttpsEnabled', 'HttpsAndHttpEnabled'
        /// </summary>
        [JsonProperty(PropertyName = "remoteManagementMode")]
        public RemoteManagementModeConfiguration RemoteManagementMode { get; set; }

        /// <summary>
        /// Gets or sets the remote management certificates.
        /// </summary>
        [JsonProperty(PropertyName = "remoteManagementCertificate")]
        public string RemoteManagementCertificate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
