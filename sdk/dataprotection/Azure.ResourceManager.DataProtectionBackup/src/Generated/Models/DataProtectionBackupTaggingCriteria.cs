// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Tagging criteria. </summary>
    public partial class DataProtectionBackupTaggingCriteria
    {
        /// <summary> Initializes a new instance of DataProtectionBackupTaggingCriteria. </summary>
        /// <param name="isDefault"> Specifies if tag is default. </param>
        /// <param name="taggingPriority"> Retention Tag priority. </param>
        /// <param name="tagInfo"> Retention tag information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tagInfo"/> is null. </exception>
        public DataProtectionBackupTaggingCriteria(bool isDefault, long taggingPriority, DataProtectionBackupRetentionTag tagInfo)
        {
            Argument.AssertNotNull(tagInfo, nameof(tagInfo));

            Criteria = new Core.ChangeTrackingList<DataProtectionBackupCriteria>();
            IsDefault = isDefault;
            TaggingPriority = taggingPriority;
            TagInfo = tagInfo;
        }

        /// <summary> Initializes a new instance of DataProtectionBackupTaggingCriteria. </summary>
        /// <param name="criteria">
        /// Criteria which decides whether the tag can be applied to a triggered backup.
        /// Please note <see cref="DataProtectionBackupCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduleBasedBackupCriteria"/>.
        /// </param>
        /// <param name="isDefault"> Specifies if tag is default. </param>
        /// <param name="taggingPriority"> Retention Tag priority. </param>
        /// <param name="tagInfo"> Retention tag information. </param>
        internal DataProtectionBackupTaggingCriteria(IList<DataProtectionBackupCriteria> criteria, bool isDefault, long taggingPriority, DataProtectionBackupRetentionTag tagInfo)
        {
            Criteria = criteria;
            IsDefault = isDefault;
            TaggingPriority = taggingPriority;
            TagInfo = tagInfo;
        }

        /// <summary>
        /// Criteria which decides whether the tag can be applied to a triggered backup.
        /// Please note <see cref="DataProtectionBackupCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduleBasedBackupCriteria"/>.
        /// </summary>
        public IList<DataProtectionBackupCriteria> Criteria { get; }
        /// <summary> Specifies if tag is default. </summary>
        public bool IsDefault { get; set; }
        /// <summary> Retention Tag priority. </summary>
        public long TaggingPriority { get; set; }
        /// <summary> Retention tag information. </summary>
        public DataProtectionBackupRetentionTag TagInfo { get; set; }
    }
}
