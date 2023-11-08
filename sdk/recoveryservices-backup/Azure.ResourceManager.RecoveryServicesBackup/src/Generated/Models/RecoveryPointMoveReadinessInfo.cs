// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The RecoveryPointMoveReadinessInfo. </summary>
    public partial class RecoveryPointMoveReadinessInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryPointMoveReadinessInfo"/>. </summary>
        public RecoveryPointMoveReadinessInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPointMoveReadinessInfo"/>. </summary>
        /// <param name="isReadyForMove"></param>
        /// <param name="additionalInfo"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryPointMoveReadinessInfo(bool? isReadyForMove, string additionalInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsReadyForMove = isReadyForMove;
            AdditionalInfo = additionalInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the is ready for move. </summary>
        public bool? IsReadyForMove { get; set; }
        /// <summary> Gets or sets the additional info. </summary>
        public string AdditionalInfo { get; set; }
    }
}
