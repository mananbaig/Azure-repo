// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.AzureStack.Storage.Admin;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class FarmUpdateParameters : ResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the FarmUpdateParameters class.
        /// </summary>
        public FarmUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FarmUpdateParameters class.
        /// </summary>
        public FarmUpdateParameters(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), FarmBase properties = default(FarmBase))
            : base(id, name, type, location, tags)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public FarmBase Properties { get; set; }

    }
}
