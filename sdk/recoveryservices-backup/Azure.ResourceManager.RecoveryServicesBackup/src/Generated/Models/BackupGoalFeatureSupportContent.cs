// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure backup goal feature specific request. </summary>
    public partial class BackupGoalFeatureSupportContent : FeatureSupportContent
    {
        /// <summary> Initializes a new instance of <see cref="BackupGoalFeatureSupportContent"/>. </summary>
        public BackupGoalFeatureSupportContent()
        {
            FeatureType = "AzureBackupGoals";
        }

        /// <summary> Initializes a new instance of <see cref="BackupGoalFeatureSupportContent"/>. </summary>
        /// <param name="featureType"> backup support feature type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupGoalFeatureSupportContent(string featureType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(featureType, serializedAdditionalRawData)
        {
            FeatureType = featureType ?? "AzureBackupGoals";
        }
    }
}
