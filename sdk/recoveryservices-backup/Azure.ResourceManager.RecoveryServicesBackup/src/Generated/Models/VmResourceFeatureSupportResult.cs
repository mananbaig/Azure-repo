// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Response for feature support requests for Azure IaasVm. </summary>
    public partial class VmResourceFeatureSupportResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VmResourceFeatureSupportResult"/>. </summary>
        internal VmResourceFeatureSupportResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VmResourceFeatureSupportResult"/>. </summary>
        /// <param name="supportStatus"> Support status of feature. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VmResourceFeatureSupportResult(VmResourceFeatureSupportStatus? supportStatus, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SupportStatus = supportStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Support status of feature. </summary>
        public VmResourceFeatureSupportStatus? SupportStatus { get; }
    }
}
