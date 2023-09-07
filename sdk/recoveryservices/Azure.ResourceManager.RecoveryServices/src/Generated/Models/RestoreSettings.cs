// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Restore Settings  of the vault. </summary>
    internal partial class RestoreSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RestoreSettings"/>. </summary>
        public RestoreSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestoreSettings"/>. </summary>
        /// <param name="crossSubscriptionRestoreSettings"> Settings for CrossSubscriptionRestore. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestoreSettings(CrossSubscriptionRestoreSettings crossSubscriptionRestoreSettings, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CrossSubscriptionRestoreSettings = crossSubscriptionRestoreSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Settings for CrossSubscriptionRestore. </summary>
        internal CrossSubscriptionRestoreSettings CrossSubscriptionRestoreSettings { get; set; }
        /// <summary> Gets or sets the cross subscription restore state. </summary>
        public CrossSubscriptionRestoreState? CrossSubscriptionRestoreState
        {
            get => CrossSubscriptionRestoreSettings is null ? default : CrossSubscriptionRestoreSettings.CrossSubscriptionRestoreState;
            set
            {
                if (CrossSubscriptionRestoreSettings is null)
                    CrossSubscriptionRestoreSettings = new CrossSubscriptionRestoreSettings();
                CrossSubscriptionRestoreSettings.CrossSubscriptionRestoreState = value;
            }
        }
    }
}
