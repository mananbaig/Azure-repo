// MICROSOFT_MIT┬á

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Consumption;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The object that represents the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">Service provider:
        /// Microsoft.Consumption.</param>
        /// <param name="resource">Resource on which the operation is
        /// performed: UsageDetail, etc.</param>
        /// <param name="operation">Operation type: Read, write, delete,
        /// etc.</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets service provider: Microsoft.Consumption.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; private set; }

        /// <summary>
        /// Gets resource on which the operation is performed: UsageDetail,
        /// etc.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; private set; }

        /// <summary>
        /// Gets operation type: Read, write, delete, etc.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; private set; }

    }
}
