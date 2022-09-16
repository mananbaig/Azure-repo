// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary>
    /// The parameters required to create a new subscription.
    /// Serialized Name: PutAliasRequest
    /// </summary>
    public partial class SubscriptionAliasCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of SubscriptionAliasCreateOrUpdateContent. </summary>
        public SubscriptionAliasCreateOrUpdateContent()
        {
        }

        /// <summary>
        /// The friendly name of the subscription.
        /// Serialized Name: PutAliasRequest.properties.displayName
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The workload type of the subscription. It can be either Production or DevTest.
        /// Serialized Name: PutAliasRequest.properties.workload
        /// </summary>
        public SubscriptionWorkload? Workload { get; set; }
        /// <summary>
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// Serialized Name: PutAliasRequest.properties.billingScope
        /// </summary>
        public string BillingScope { get; set; }
        /// <summary>
        /// This parameter can be used to create alias for existing subscription Id
        /// Serialized Name: PutAliasRequest.properties.subscriptionId
        /// </summary>
        public string SubscriptionId { get; set; }
        /// <summary>
        /// Reseller Id
        /// Serialized Name: PutAliasRequest.properties.resellerId
        /// </summary>
        public string ResellerId { get; set; }
        /// <summary>
        /// Put alias request additional properties.
        /// Serialized Name: PutAliasRequest.properties.additionalProperties
        /// </summary>
        public SubscriptionAliasAdditionalProperties AdditionalProperties { get; set; }
    }
}
