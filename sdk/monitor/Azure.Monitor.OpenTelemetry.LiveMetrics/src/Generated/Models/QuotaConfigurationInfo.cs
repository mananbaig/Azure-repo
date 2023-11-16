// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> Control document quotas for QuickPulse. </summary>
    internal partial class QuotaConfigurationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuotaConfigurationInfo"/>. </summary>
        /// <param name="maxQuota"> Max quota. </param>
        /// <param name="quotaAccrualRatePerSec"> Quota accrual rate per second. </param>
        internal QuotaConfigurationInfo(float maxQuota, float quotaAccrualRatePerSec)
        {
            MaxQuota = maxQuota;
            QuotaAccrualRatePerSec = quotaAccrualRatePerSec;
        }

        /// <summary> Initializes a new instance of <see cref="QuotaConfigurationInfo"/>. </summary>
        /// <param name="initialQuota"> Initial quota. </param>
        /// <param name="maxQuota"> Max quota. </param>
        /// <param name="quotaAccrualRatePerSec"> Quota accrual rate per second. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaConfigurationInfo(float? initialQuota, float maxQuota, float quotaAccrualRatePerSec, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InitialQuota = initialQuota;
            MaxQuota = maxQuota;
            QuotaAccrualRatePerSec = quotaAccrualRatePerSec;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="QuotaConfigurationInfo"/> for deserialization. </summary>
        internal QuotaConfigurationInfo()
        {
        }

        /// <summary> Initial quota. </summary>
        public float? InitialQuota { get; }
        /// <summary> Max quota. </summary>
        public float MaxQuota { get; }
        /// <summary> Quota accrual rate per second. </summary>
        public float QuotaAccrualRatePerSec { get; }
    }
}
