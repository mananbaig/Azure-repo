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
    /// The restore point properties.
    /// </summary>
    public partial class RestorePoint : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RestorePoint class.
        /// </summary>
        public RestorePoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorePoint class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="optionalProperties">Optional properties to be passed
        /// for restore point creation (raw JSON)</param>
        /// <param name="sourceMetadata">Gets the details of the VM captured at
        /// the time of creation of restore point.</param>
        /// <param name="provisioningState">Gets the provisioning state of
        /// restore point, which only appears in the response.</param>
        /// <param name="consistencyMode">Gets or sets the consistency mode for
        /// the restore point. Possible values include: 'CrashConsistent',
        /// 'FileSystemConsistent', 'ApplicationConsistent'</param>
        /// <param name="provisioningDetails">Gets the provisioning details set
        /// by the server during Create restore point operation.</param>
        /// <param name="excludeDisks">List of disk resource ids that the
        /// customer wishes to exclude from the restore point. If no disks are
        /// specified, all disks will be included.</param>
        public RestorePoint(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), object optionalProperties = default(object), RestorePointSourceMetadata sourceMetadata = default(RestorePointSourceMetadata), string provisioningState = default(string), ConsistencyModeTypes? consistencyMode = default(ConsistencyModeTypes?), RestorePointProvisioningDetails provisioningDetails = default(RestorePointProvisioningDetails), IList<ApiEntityReference> excludeDisks = default(IList<ApiEntityReference>))
            : base(location, id, name, type, tags)
        {
            OptionalProperties = optionalProperties;
            SourceMetadata = sourceMetadata;
            ProvisioningState = provisioningState;
            ConsistencyMode = consistencyMode;
            ProvisioningDetails = provisioningDetails;
            ExcludeDisks = excludeDisks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional properties to be passed for restore point
        /// creation (raw JSON)
        /// </summary>
        [JsonProperty(PropertyName = "optionalProperties")]
        public object OptionalProperties { get; set; }

        /// <summary>
        /// Gets the details of the VM captured at the time of creation of
        /// restore point.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMetadata")]
        public RestorePointSourceMetadata SourceMetadata { get; private set; }

        /// <summary>
        /// Gets the provisioning state of restore point, which only appears in
        /// the response.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the consistency mode for the restore point. Possible
        /// values include: 'CrashConsistent', 'FileSystemConsistent',
        /// 'ApplicationConsistent'
        /// </summary>
        [JsonProperty(PropertyName = "consistencyMode")]
        public ConsistencyModeTypes? ConsistencyMode { get; private set; }

        /// <summary>
        /// Gets the provisioning details set by the server during Create
        /// restore point operation.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningDetails")]
        public RestorePointProvisioningDetails ProvisioningDetails { get; private set; }

        /// <summary>
        /// Gets list of disk resource ids that the customer wishes to exclude
        /// from the restore point. If no disks are specified, all disks will
        /// be included.
        /// </summary>
        [JsonProperty(PropertyName = "excludeDisks")]
        public IList<ApiEntityReference> ExcludeDisks { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (SourceMetadata != null)
            {
                SourceMetadata.Validate();
            }
        }
    }
}
