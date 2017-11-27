// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProvisioningServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result of a long running operation.
    /// </summary>
    public partial class AsyncOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the AsyncOperationResult class.
        /// </summary>
        public AsyncOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AsyncOperationResult class.
        /// </summary>
        public AsyncOperationResult(string status = default(string), ErrorMesssage error = default(ErrorMesssage))
        {
            Status = status;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorMesssage Error { get; set; }

    }
}
