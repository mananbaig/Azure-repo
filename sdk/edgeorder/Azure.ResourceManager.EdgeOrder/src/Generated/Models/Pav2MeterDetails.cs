// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Billing type PAV2 meter details. </summary>
    public partial class Pav2MeterDetails : EdgeOrderProductMeterDetails
    {
        /// <summary> Initializes a new instance of <see cref="Pav2MeterDetails"/>. </summary>
        internal Pav2MeterDetails()
        {
            BillingType = BillingType.Pav2;
        }

        /// <summary> Initializes a new instance of <see cref="Pav2MeterDetails"/>. </summary>
        /// <param name="billingType"> Represents billing type. </param>
        /// <param name="multiplier"> Billing unit applicable for Pav2 billing. </param>
        /// <param name="chargingType"> Charging type. </param>
        /// <param name="meterGuid"> Validation status of requested data center and transport. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Pav2MeterDetails(BillingType billingType, double? multiplier, EdgeOrderProductChargingType? chargingType, Guid? meterGuid, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(billingType, multiplier, chargingType, serializedAdditionalRawData)
        {
            MeterGuid = meterGuid;
            BillingType = billingType;
        }

        /// <summary> Validation status of requested data center and transport. </summary>
        public Guid? MeterGuid { get; }
    }
}
