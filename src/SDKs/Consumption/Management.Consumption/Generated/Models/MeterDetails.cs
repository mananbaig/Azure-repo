// MICROSOFT_MIT┬á

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Consumption;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of the meter detail.
    /// </summary>
    public partial class MeterDetails
    {
        /// <summary>
        /// Initializes a new instance of the MeterDetails class.
        /// </summary>
        public MeterDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MeterDetails class.
        /// </summary>
        /// <param name="meterName">The name of the meter, within the given
        /// meter category</param>
        /// <param name="meterCategory">The category of the meter, for example,
        /// 'Cloud services', 'Networking', etc..</param>
        /// <param name="meterSubCategory">The subcategory of the meter, for
        /// example, 'A6 Cloud services', 'ExpressRoute (IXP)', etc..</param>
        /// <param name="unit">The unit in which the meter consumption is
        /// charged, for example, 'Hours', 'GB', etc.</param>
        /// <param name="meterLocation">The location in which the Azure service
        /// is available.</param>
        /// <param name="totalIncludedQuantity">The total included quantity
        /// associated with the offer.</param>
        /// <param name="pretaxStandardRate">The pretax listing price.</param>
        public MeterDetails(string meterName = default(string), string meterCategory = default(string), string meterSubCategory = default(string), string unit = default(string), string meterLocation = default(string), decimal? totalIncludedQuantity = default(decimal?), decimal? pretaxStandardRate = default(decimal?))
        {
            MeterName = meterName;
            MeterCategory = meterCategory;
            MeterSubCategory = meterSubCategory;
            Unit = unit;
            MeterLocation = meterLocation;
            TotalIncludedQuantity = totalIncludedQuantity;
            PretaxStandardRate = pretaxStandardRate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the meter, within the given meter category
        /// </summary>
        [JsonProperty(PropertyName = "meterName")]
        public string MeterName { get; private set; }

        /// <summary>
        /// Gets the category of the meter, for example, 'Cloud services',
        /// 'Networking', etc..
        /// </summary>
        [JsonProperty(PropertyName = "meterCategory")]
        public string MeterCategory { get; private set; }

        /// <summary>
        /// Gets the subcategory of the meter, for example, 'A6 Cloud
        /// services', 'ExpressRoute (IXP)', etc..
        /// </summary>
        [JsonProperty(PropertyName = "meterSubCategory")]
        public string MeterSubCategory { get; private set; }

        /// <summary>
        /// Gets the unit in which the meter consumption is charged, for
        /// example, 'Hours', 'GB', etc.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the location in which the Azure service is available.
        /// </summary>
        [JsonProperty(PropertyName = "meterLocation")]
        public string MeterLocation { get; private set; }

        /// <summary>
        /// Gets the total included quantity associated with the offer.
        /// </summary>
        [JsonProperty(PropertyName = "totalIncludedQuantity")]
        public decimal? TotalIncludedQuantity { get; private set; }

        /// <summary>
        /// Gets the pretax listing price.
        /// </summary>
        [JsonProperty(PropertyName = "pretaxStandardRate")]
        public decimal? PretaxStandardRate { get; private set; }

    }
}
