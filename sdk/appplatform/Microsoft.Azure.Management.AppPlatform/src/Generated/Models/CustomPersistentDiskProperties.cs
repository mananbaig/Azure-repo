// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Custom persistent disk resource payload.
    /// </summary>
    public partial class CustomPersistentDiskProperties
    {
        /// <summary>
        /// Initializes a new instance of the CustomPersistentDiskProperties
        /// class.
        /// </summary>
        public CustomPersistentDiskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomPersistentDiskProperties
        /// class.
        /// </summary>
        /// <param name="mountPath">The mount path of the persistent
        /// disk.</param>
        /// <param name="readOnlyProperty">Indicates whether the persistent
        /// disk is a readOnly one.</param>
        /// <param name="mountOptions">These are the mount options for a
        /// persistent disk.</param>
        public CustomPersistentDiskProperties(string mountPath, bool? readOnlyProperty = default(bool?), IList<string> mountOptions = default(IList<string>))
        {
            MountPath = mountPath;
            ReadOnlyProperty = readOnlyProperty;
            MountOptions = mountOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mount path of the persistent disk.
        /// </summary>
        [JsonProperty(PropertyName = "mountPath")]
        public string MountPath { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the persistent disk is a readOnly
        /// one.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets these are the mount options for a persistent disk.
        /// </summary>
        [JsonProperty(PropertyName = "mountOptions")]
        public IList<string> MountOptions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MountPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MountPath");
            }
        }
    }
}
