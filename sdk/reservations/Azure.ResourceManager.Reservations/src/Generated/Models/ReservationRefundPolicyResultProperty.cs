// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Refund policy result property. </summary>
    public partial class ReservationRefundPolicyResultProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReservationRefundPolicyResultProperty"/>. </summary>
        internal ReservationRefundPolicyResultProperty()
        {
            PolicyErrors = new ChangeTrackingList<ReservationRefundPolicyError>();
        }

        /// <summary> Initializes a new instance of <see cref="ReservationRefundPolicyResultProperty"/>. </summary>
        /// <param name="consumedRefundsTotal"> Pricing information containing the amount and the currency code. </param>
        /// <param name="maxRefundLimit"> Pricing information containing the amount and the currency code. </param>
        /// <param name="policyErrors"> Refund Policy errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationRefundPolicyResultProperty(PurchasePrice consumedRefundsTotal, PurchasePrice maxRefundLimit, IReadOnlyList<ReservationRefundPolicyError> policyErrors, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConsumedRefundsTotal = consumedRefundsTotal;
            MaxRefundLimit = maxRefundLimit;
            PolicyErrors = policyErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice ConsumedRefundsTotal { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice MaxRefundLimit { get; }
        /// <summary> Refund Policy errors. </summary>
        public IReadOnlyList<ReservationRefundPolicyError> PolicyErrors { get; }
    }
}
