// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Spark Configuration resource type. </summary>
    public partial class SparkConfigurationResource : SubResource
    {
        /// <summary> Initializes a new instance of SparkConfigurationResource. </summary>
        /// <param name="properties"> Properties of Spark Configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SparkConfigurationResource(SparkConfiguration properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of SparkConfigurationResource. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="properties"> Properties of Spark Configuration. </param>
        internal SparkConfigurationResource(string id, string name, string type, string etag, SparkConfiguration properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Properties of Spark Configuration. </summary>
        public SparkConfiguration Properties { get; set; }
    }
}
