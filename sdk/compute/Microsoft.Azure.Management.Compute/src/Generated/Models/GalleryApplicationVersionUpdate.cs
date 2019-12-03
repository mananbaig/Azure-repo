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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the gallery Application Version that you
    /// want to update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GalleryApplicationVersionUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the GalleryApplicationVersionUpdate
        /// class.
        /// </summary>
        public GalleryApplicationVersionUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryApplicationVersionUpdate
        /// class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="provisioningState">The current state of the gallery
        /// Application Version.</param>
        public GalleryApplicationVersionUpdate(GalleryApplicationVersionPublishingProfile publishingProfile, IDictionary<string, string> tags = default(IDictionary<string, string>), string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string), ReplicationStatus replicationStatus = default(ReplicationStatus))
            : base(tags, id, name, type)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            ReplicationStatus = replicationStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingProfile")]
        public GalleryApplicationVersionPublishingProfile PublishingProfile { get; set; }

        /// <summary>
        /// Gets the current state of the gallery Application Version.
        /// </summary>
        /// <remarks>
        /// The provisioning state, which only appears in the response.
        /// Possible values include: 'Creating', 'Updating', 'Failed',
        /// 'Succeeded', 'Deleting', 'Migrating'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationStatus")]
        public ReplicationStatus ReplicationStatus { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PublishingProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublishingProfile");
            }
            if (PublishingProfile != null)
            {
                PublishingProfile.Validate();
            }
        }
    }
}
