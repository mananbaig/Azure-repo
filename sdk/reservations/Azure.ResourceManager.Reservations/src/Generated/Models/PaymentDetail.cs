// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Information about payment related to a reservation order. </summary>
    public partial class PaymentDetail
    {
        /// <summary> Initializes a new instance of PaymentDetail. </summary>
        internal PaymentDetail()
        {
        }

        /// <summary> Initializes a new instance of PaymentDetail. </summary>
        /// <param name="dueOn"> Date when the payment needs to be done. </param>
        /// <param name="paymentOn"> Date when the transaction is completed. Is null when it is scheduled. </param>
        /// <param name="pricingCurrencyTotal"> Amount in pricing currency. Tax not included. </param>
        /// <param name="billingCurrencyTotal"> Amount charged in Billing currency. Tax not included. Is null for future payments. </param>
        /// <param name="billingAccount"> Shows the Account that is charged for this payment. </param>
        /// <param name="status"> Describes whether the payment is completed, failed, cancelled or scheduled in the future. </param>
        /// <param name="extendedStatusInfo"></param>
        internal PaymentDetail(DateTimeOffset? dueOn, DateTimeOffset? paymentOn, PurchasePrice pricingCurrencyTotal, PurchasePrice billingCurrencyTotal, string billingAccount, PaymentStatus? status, ExtendedStatusInfo extendedStatusInfo)
        {
            DueOn = dueOn;
            PaymentOn = paymentOn;
            PricingCurrencyTotal = pricingCurrencyTotal;
            BillingCurrencyTotal = billingCurrencyTotal;
            BillingAccount = billingAccount;
            Status = status;
            ExtendedStatusInfo = extendedStatusInfo;
        }

        /// <summary> Date when the payment needs to be done. </summary>
        public DateTimeOffset? DueOn { get; }
        /// <summary> Date when the transaction is completed. Is null when it is scheduled. </summary>
        public DateTimeOffset? PaymentOn { get; }
        /// <summary> Amount in pricing currency. Tax not included. </summary>
        public PurchasePrice PricingCurrencyTotal { get; }
        /// <summary> Amount charged in Billing currency. Tax not included. Is null for future payments. </summary>
        public PurchasePrice BillingCurrencyTotal { get; }
        /// <summary> Shows the Account that is charged for this payment. </summary>
        public string BillingAccount { get; }
        /// <summary> Describes whether the payment is completed, failed, cancelled or scheduled in the future. </summary>
        public PaymentStatus? Status { get; }
        /// <summary> Gets the extended status info. </summary>
        public ExtendedStatusInfo ExtendedStatusInfo { get; }
    }
}
