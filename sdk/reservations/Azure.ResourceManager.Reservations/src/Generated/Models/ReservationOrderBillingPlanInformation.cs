// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Information describing the type of billing plan for this reservation. </summary>
    public partial class ReservationOrderBillingPlanInformation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReservationOrderBillingPlanInformation"/>. </summary>
        internal ReservationOrderBillingPlanInformation()
        {
            Transactions = new ChangeTrackingList<PaymentDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="ReservationOrderBillingPlanInformation"/>. </summary>
        /// <param name="pricingCurrencyTotal"> Amount of money to be paid for the Order. Tax is not included. </param>
        /// <param name="startOn"> Date when the billing plan has started. </param>
        /// <param name="nextPaymentDueOn"> For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off. </param>
        /// <param name="transactions"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationOrderBillingPlanInformation(PurchasePrice pricingCurrencyTotal, DateTimeOffset? startOn, DateTimeOffset? nextPaymentDueOn, IReadOnlyList<PaymentDetail> transactions, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PricingCurrencyTotal = pricingCurrencyTotal;
            StartOn = startOn;
            NextPaymentDueOn = nextPaymentDueOn;
            Transactions = transactions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Amount of money to be paid for the Order. Tax is not included. </summary>
        public PurchasePrice PricingCurrencyTotal { get; }
        /// <summary> Date when the billing plan has started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> For recurring billing plans, indicates the date when next payment will be processed. Null when total is paid off. </summary>
        public DateTimeOffset? NextPaymentDueOn { get; }
        /// <summary> Gets the transactions. </summary>
        public IReadOnlyList<PaymentDetail> Transactions { get; }
    }
}
