// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Usages of a vault. </summary>
    public partial class VaultUsage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VaultUsage"/>. </summary>
        internal VaultUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VaultUsage"/>. </summary>
        /// <param name="unit"> Unit of the usage. </param>
        /// <param name="quotaPeriod"> Quota period of usage. </param>
        /// <param name="nextResetOn"> Next reset time of usage. </param>
        /// <param name="currentValue"> Current value of usage. </param>
        /// <param name="limit"> Limit of usage. </param>
        /// <param name="name"> Name of usage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VaultUsage(VaultUsageUnit? unit, string quotaPeriod, DateTimeOffset? nextResetOn, long? currentValue, long? limit, VaultUsageNameInfo name, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Unit = unit;
            QuotaPeriod = quotaPeriod;
            NextResetOn = nextResetOn;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unit of the usage. </summary>
        public VaultUsageUnit? Unit { get; }
        /// <summary> Quota period of usage. </summary>
        public string QuotaPeriod { get; }
        /// <summary> Next reset time of usage. </summary>
        public DateTimeOffset? NextResetOn { get; }
        /// <summary> Current value of usage. </summary>
        public long? CurrentValue { get; }
        /// <summary> Limit of usage. </summary>
        public long? Limit { get; }
        /// <summary> Name of usage. </summary>
        public VaultUsageNameInfo Name { get; }
    }
}
