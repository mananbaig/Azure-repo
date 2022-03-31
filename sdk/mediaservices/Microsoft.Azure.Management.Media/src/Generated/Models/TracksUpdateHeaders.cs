// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Update operation.
    /// </summary>
    public partial class TracksUpdateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the TracksUpdateHeaders class.
        /// </summary>
        public TracksUpdateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TracksUpdateHeaders class.
        /// </summary>
        /// <param name="retryAfter">The recommended number of seconds to wait
        /// before calling the URI specified in Azure-AsyncOperation.</param>
        /// <param name="location">The URI to poll for completion
        /// status.</param>
        /// <param name="azureAsyncOperation">The URI to poll for completion
        /// status.</param>
        public TracksUpdateHeaders(int? retryAfter = default(int?), string location = default(string), string azureAsyncOperation = default(string))
        {
            RetryAfter = retryAfter;
            Location = location;
            AzureAsyncOperation = azureAsyncOperation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recommended number of seconds to wait before
        /// calling the URI specified in Azure-AsyncOperation.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

        /// <summary>
        /// Gets or sets the URI to poll for completion status.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the URI to poll for completion status.
        /// </summary>
        [JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

    }
}
