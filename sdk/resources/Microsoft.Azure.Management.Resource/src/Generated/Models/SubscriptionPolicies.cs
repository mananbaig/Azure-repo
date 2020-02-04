// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Resources.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subscription policies.
    /// </summary>
    public partial class SubscriptionPolicies
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionPolicies class.
        /// </summary>
        public SubscriptionPolicies()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionPolicies class.
        /// </summary>
        /// <param name="locationPlacementId">The subscription location
        /// placement ID. The ID indicates which regions are visible for a
        /// subscription. For example, a subscription with a location placement
        /// Id of Public_2014-09-01 has access to Azure public regions.</param>
        /// <param name="quotaId">The subscription quota ID.</param>
        /// <param name="spendingLimit">The subscription spending limit.
        /// Possible values include: 'On', 'Off', 'CurrentPeriodOff'</param>
        public SubscriptionPolicies(string locationPlacementId = default(string), string quotaId = default(string), SpendingLimit? spendingLimit = default(SpendingLimit?))
        {
            LocationPlacementId = locationPlacementId;
            QuotaId = quotaId;
            SpendingLimit = spendingLimit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the subscription location placement ID. The ID indicates which
        /// regions are visible for a subscription. For example, a subscription
        /// with a location placement Id of Public_2014-09-01 has access to
        /// Azure public regions.
        /// </summary>
        [JsonProperty(PropertyName = "locationPlacementId")]
        public string LocationPlacementId { get; private set; }

        /// <summary>
        /// Gets the subscription quota ID.
        /// </summary>
        [JsonProperty(PropertyName = "quotaId")]
        public string QuotaId { get; private set; }

        /// <summary>
        /// Gets the subscription spending limit. Possible values include:
        /// 'On', 'Off', 'CurrentPeriodOff'
        /// </summary>
        [JsonProperty(PropertyName = "spendingLimit")]
        public SpendingLimit? SpendingLimit { get; private set; }

    }
}
