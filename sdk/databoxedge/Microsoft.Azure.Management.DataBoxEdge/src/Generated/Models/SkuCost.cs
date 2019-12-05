// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The metadata for retrieving price info.
    /// </summary>
    public partial class SkuCost
    {
        /// <summary>
        /// Initializes a new instance of the SkuCost class.
        /// </summary>
        public SkuCost()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuCost class.
        /// </summary>
        /// <param name="meterId">Used for querying price from
        /// commerce.</param>
        /// <param name="quantity">The cost quantity.</param>
        /// <param name="extendedUnit">Restriction of the SKU for the
        /// location/zone</param>
        public SkuCost(string meterId = default(string), long? quantity = default(long?), string extendedUnit = default(string))
        {
            MeterId = meterId;
            Quantity = quantity;
            ExtendedUnit = extendedUnit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets used for querying price from commerce.
        /// </summary>
        [JsonProperty(PropertyName = "meterId")]
        public string MeterId { get; private set; }

        /// <summary>
        /// Gets the cost quantity.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; private set; }

        /// <summary>
        /// Gets restriction of the SKU for the location/zone
        /// </summary>
        [JsonProperty(PropertyName = "extendedUnit")]
        public string ExtendedUnit { get; private set; }

    }
}
