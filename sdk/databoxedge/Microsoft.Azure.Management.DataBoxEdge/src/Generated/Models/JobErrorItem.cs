// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The job error items.
    /// </summary>
    public partial class JobErrorItem
    {
        /// <summary>
        /// Initializes a new instance of the JobErrorItem class.
        /// </summary>
        public JobErrorItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobErrorItem class.
        /// </summary>
        /// <param name="recommendations">The recommended actions.</param>
        /// <param name="code">The code intended for programmatic
        /// access.</param>
        /// <param name="message">The message that describes the error in
        /// detail.</param>
        public JobErrorItem(IList<string> recommendations = default(IList<string>), string code = default(string), string message = default(string))
        {
            Recommendations = recommendations;
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the recommended actions.
        /// </summary>
        [JsonProperty(PropertyName = "recommendations")]
        public IList<string> Recommendations { get; private set; }

        /// <summary>
        /// Gets the code intended for programmatic access.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the message that describes the error in detail.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
