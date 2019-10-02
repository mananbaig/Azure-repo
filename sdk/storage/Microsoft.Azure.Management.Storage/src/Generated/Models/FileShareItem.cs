// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The file share properties be listed out.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FileShareItem : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the FileShareItem class.
        /// </summary>
        public FileShareItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileShareItem class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="lastModifiedTime">Returns the date and time the share
        /// was last modified.</param>
        /// <param name="metadata">A name-value pair to associate with the
        /// share as metadata.</param>
        /// <param name="shareQuota">The maximum size of the share, in
        /// gigabytes. Must be greater than 0, and less than or equal to 5TB
        /// (5120).</param>
        public FileShareItem(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), IDictionary<string, string> metadata = default(IDictionary<string, string>), int? shareQuota = default(int?))
            : base(id, name, type, etag)
        {
            LastModifiedTime = lastModifiedTime;
            Metadata = metadata;
            ShareQuota = shareQuota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets returns the date and time the share was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets a name-value pair to associate with the share as
        /// metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the share, in gigabytes. Must be
        /// greater than 0, and less than or equal to 5TB (5120).
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareQuota")]
        public int? ShareQuota { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShareQuota > 5120)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ShareQuota", 5120);
            }
            if (ShareQuota < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ShareQuota", 1);
            }
        }
    }
}
