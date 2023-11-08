// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Settings for Cross Subscription Restore Settings. </summary>
    internal partial class CrossSubscriptionRestoreSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CrossSubscriptionRestoreSettings"/>. </summary>
        public CrossSubscriptionRestoreSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CrossSubscriptionRestoreSettings"/>. </summary>
        /// <param name="crossSubscriptionRestoreState"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CrossSubscriptionRestoreSettings(CrossSubscriptionRestoreState? crossSubscriptionRestoreState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CrossSubscriptionRestoreState = crossSubscriptionRestoreState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the cross subscription restore state. </summary>
        public CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
    }
}
