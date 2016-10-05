// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for an ApplicationOperations.AddApplication request.
    /// </summary>
    public partial class AddApplicationParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the AddApplicationParametersInner
        /// class.
        /// </summary>
        public AddApplicationParametersInner() { }

        /// <summary>
        /// Initializes a new instance of the AddApplicationParametersInner
        /// class.
        /// </summary>
        /// <param name="allowUpdates">A value indicating whether packages
        /// within the application may be overwritten using the same version
        /// string.</param>
        /// <param name="displayName">The display name for the
        /// application.</param>
        public AddApplicationParametersInner(bool? allowUpdates = default(bool?), string displayName = default(string))
        {
            AllowUpdates = allowUpdates;
            DisplayName = displayName;
        }

        /// <summary>
        /// Gets or sets a value indicating whether packages within the
        /// application may be overwritten using the same version string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowUpdates")]
        public bool? AllowUpdates { get; set; }

        /// <summary>
        /// Gets or sets the display name for the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
