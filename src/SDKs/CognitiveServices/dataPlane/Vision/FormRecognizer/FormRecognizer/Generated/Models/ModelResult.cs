// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result of a model status query operation.
    /// </summary>
    public partial class ModelResult
    {
        /// <summary>
        /// Initializes a new instance of the ModelResult class.
        /// </summary>
        public ModelResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelResult class.
        /// </summary>
        /// <param name="modelId">Get or set model identifier.</param>
        /// <param name="status">Get or set the status of model. Possible
        /// values include: 'created', 'ready', 'invalid'</param>
        /// <param name="createdDateTime">Get or set the created date time of
        /// the model.</param>
        /// <param name="lastUpdatedDateTime">Get or set the model last updated
        /// datetime.</param>
        public ModelResult(System.Guid modelId = default(System.Guid), string status = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastUpdatedDateTime = default(System.DateTime?))
        {
            ModelId = modelId;
            Status = status;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets get or set model identifier.
        /// </summary>
        [JsonProperty(PropertyName = "modelId")]
        public System.Guid ModelId { get; set; }

        /// <summary>
        /// Gets or sets get or set the status of model. Possible values
        /// include: 'created', 'ready', 'invalid'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets get or set the created date time of the model.
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets get or set the model last updated datetime.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedDateTime")]
        public System.DateTime? LastUpdatedDateTime { get; set; }

    }
}
