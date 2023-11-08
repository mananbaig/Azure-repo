// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The MoveRPAcrossTiersContent. </summary>
    public partial class MoveRPAcrossTiersContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoveRPAcrossTiersContent"/>. </summary>
        public MoveRPAcrossTiersContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MoveRPAcrossTiersContent"/>. </summary>
        /// <param name="objectType"> Gets the class type. </param>
        /// <param name="sourceTierType"> Source tier from where RP needs to be moved. </param>
        /// <param name="targetTierType"> Target tier where RP needs to be moved. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoveRPAcrossTiersContent(string objectType, RecoveryPointTierType? sourceTierType, RecoveryPointTierType? targetTierType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ObjectType = objectType;
            SourceTierType = sourceTierType;
            TargetTierType = targetTierType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the class type. </summary>
        public string ObjectType { get; set; }
        /// <summary> Source tier from where RP needs to be moved. </summary>
        public RecoveryPointTierType? SourceTierType { get; set; }
        /// <summary> Target tier where RP needs to be moved. </summary>
        public RecoveryPointTierType? TargetTierType { get; set; }
    }
}
