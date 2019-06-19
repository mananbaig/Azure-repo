// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Download operation.
    /// </summary>
    public partial class UsageDetailsDownloadHeaders
    {
        /// <summary>
        /// Initializes a new instance of the UsageDetailsDownloadHeaders
        /// class.
        /// </summary>
        public UsageDetailsDownloadHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageDetailsDownloadHeaders
        /// class.
        /// </summary>
        /// <param name="location">GET this URL to retrieve the status of the
        /// asynchronous operation.</param>
        /// <param name="retryAfter">The amount of delay to use while the
        /// status of the operation is checked. The value is expressed in
        /// seconds.</param>
        /// <param name="azureAsyncOperation">To get the progress of the
        /// operation, call GET operation on the URL in Azure-AsyncOperation
        /// header field.</param>
        public UsageDetailsDownloadHeaders(string location = default(string), string retryAfter = default(string), string azureAsyncOperation = default(string))
        {
            Location = location;
            RetryAfter = retryAfter;
            AzureAsyncOperation = azureAsyncOperation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets GET this URL to retrieve the status of the
        /// asynchronous operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the amount of delay to use while the status of the
        /// operation is checked. The value is expressed in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public string RetryAfter { get; set; }

        /// <summary>
        /// Gets or sets to get the progress of the operation, call GET
        /// operation on the URL in Azure-AsyncOperation header field.
        /// </summary>
        [JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

    }
}
