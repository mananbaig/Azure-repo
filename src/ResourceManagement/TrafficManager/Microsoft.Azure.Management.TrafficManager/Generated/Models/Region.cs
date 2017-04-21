// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a region in the Geographic hierarchy used with the
    /// Geographic traffic routing method.
    /// </summary>
    public partial class Region
    {
        /// <summary>
        /// Initializes a new instance of the Region class.
        /// </summary>
        public Region()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Region class.
        /// </summary>
        /// <param name="code">The code of the region</param>
        /// <param name="name">The name of the region</param>
        /// <param name="regions">The list of Regions grouped under this Region
        /// in the Geographic Hierarchy.</param>
        public Region(string code = default(string), string name = default(string), IList<Region> regions = default(IList<Region>))
        {
            Code = code;
            Name = name;
            Regions = regions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the code of the region
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name of the region
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of Regions grouped under this Region in the
        /// Geographic Hierarchy.
        /// </summary>
        [JsonProperty(PropertyName = "regions")]
        public IList<Region> Regions { get; set; }

    }
}
