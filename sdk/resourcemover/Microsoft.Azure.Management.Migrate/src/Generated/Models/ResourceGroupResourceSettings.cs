// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the resource group resource settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("resourceGroups")]
    public partial class ResourceGroupResourceSettings : ResourceSettings
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupResourceSettings
        /// class.
        /// </summary>
        public ResourceGroupResourceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupResourceSettings
        /// class.
        /// </summary>
        /// <param name="targetResourceName">Gets or sets the target Resource
        /// name.</param>
        public ResourceGroupResourceSettings(string targetResourceName)
            : base(targetResourceName)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
