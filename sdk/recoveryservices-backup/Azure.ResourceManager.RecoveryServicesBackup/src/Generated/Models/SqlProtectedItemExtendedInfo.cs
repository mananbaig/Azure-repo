// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information on Azure Sql specific protected item. </summary>
    public partial class SqlProtectedItemExtendedInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlProtectedItemExtendedInfo"/>. </summary>
        public SqlProtectedItemExtendedInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlProtectedItemExtendedInfo"/>. </summary>
        /// <param name="oldestRecoverOn"> The oldest backup copy available for this item in the service. </param>
        /// <param name="recoveryPointCount"> Number of available backup copies associated with this backup item. </param>
        /// <param name="policyState"> State of the backup policy associated with this backup item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlProtectedItemExtendedInfo(DateTimeOffset? oldestRecoverOn, int? recoveryPointCount, string policyState, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OldestRecoverOn = oldestRecoverOn;
            RecoveryPointCount = recoveryPointCount;
            PolicyState = policyState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The oldest backup copy available for this item in the service. </summary>
        public DateTimeOffset? OldestRecoverOn { get; set; }
        /// <summary> Number of available backup copies associated with this backup item. </summary>
        public int? RecoveryPointCount { get; set; }
        /// <summary> State of the backup policy associated with this backup item. </summary>
        public string PolicyState { get; set; }
    }
}
