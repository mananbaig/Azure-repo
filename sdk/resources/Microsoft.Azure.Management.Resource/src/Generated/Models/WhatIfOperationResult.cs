// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Resources.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of the What-If operation. Contains a list of predicted changes
    /// and a URL link to get to the next set of results.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WhatIfOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the WhatIfOperationResult class.
        /// </summary>
        public WhatIfOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WhatIfOperationResult class.
        /// </summary>
        /// <param name="status">Status of the What-If operation.</param>
        /// <param name="changes">List of resource changes predicted by What-If
        /// operation.</param>
        /// <param name="error">Error when What-If operation fails.</param>
        public WhatIfOperationResult(string status = default(string), IList<WhatIfChange> changes = default(IList<WhatIfChange>), ErrorResponse error = default(ErrorResponse))
        {
            Status = status;
            Changes = changes;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the What-If operation.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets list of resource changes predicted by What-If
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changes")]
        public IList<WhatIfChange> Changes { get; set; }

        /// <summary>
        /// Gets or sets error when What-If operation fails.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

    }
}
