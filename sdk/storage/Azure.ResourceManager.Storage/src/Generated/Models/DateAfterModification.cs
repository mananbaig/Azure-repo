// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan. </summary>
    public partial class DateAfterModification
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DateAfterModification"/>. </summary>
        public DateAfterModification()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DateAfterModification"/>. </summary>
        /// <param name="daysAfterModificationGreaterThan"> Value indicating the age in days after last modification. </param>
        /// <param name="daysAfterLastAccessTimeGreaterThan"> Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy. </param>
        /// <param name="daysAfterLastTierChangeGreaterThan"> Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based actions. The blob will be archived if both the conditions are satisfied. </param>
        /// <param name="daysAfterCreationGreaterThan"> Value indicating the age in days after blob creation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DateAfterModification(float? daysAfterModificationGreaterThan, float? daysAfterLastAccessTimeGreaterThan, float? daysAfterLastTierChangeGreaterThan, float? daysAfterCreationGreaterThan, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DaysAfterModificationGreaterThan = daysAfterModificationGreaterThan;
            DaysAfterLastAccessTimeGreaterThan = daysAfterLastAccessTimeGreaterThan;
            DaysAfterLastTierChangeGreaterThan = daysAfterLastTierChangeGreaterThan;
            DaysAfterCreationGreaterThan = daysAfterCreationGreaterThan;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Value indicating the age in days after last modification. </summary>
        public float? DaysAfterModificationGreaterThan { get; set; }
        /// <summary> Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy. </summary>
        public float? DaysAfterLastAccessTimeGreaterThan { get; set; }
        /// <summary> Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based actions. The blob will be archived if both the conditions are satisfied. </summary>
        public float? DaysAfterLastTierChangeGreaterThan { get; set; }
        /// <summary> Value indicating the age in days after blob creation. </summary>
        public float? DaysAfterCreationGreaterThan { get; set; }
    }
}
