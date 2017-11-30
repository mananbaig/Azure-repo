// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for GetOperationStatus operation.
    /// </summary>
    public partial class SubscriptionDefinitionsGetOperationStatusHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionDefinitionsGetOperationStatusHeaders class.
        /// </summary>
        public SubscriptionDefinitionsGetOperationStatusHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionDefinitionsGetOperationStatusHeaders class.
        /// </summary>
        /// <param name="location">The URL where the status of the asynchronous
        /// operation can be checked.</param>
        /// <param name="retryAfter">The amount of delay to use while the
        /// status of the operation is checked. The value is expressed in
        /// seconds.</param>
        public SubscriptionDefinitionsGetOperationStatusHeaders(string location = default(string), string retryAfter = default(string))
        {
            Location = location;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL where the status of the asynchronous operation
        /// can be checked.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the amount of delay to use while the status of the
        /// operation is checked. The value is expressed in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public string RetryAfter { get; set; }

    }
}
