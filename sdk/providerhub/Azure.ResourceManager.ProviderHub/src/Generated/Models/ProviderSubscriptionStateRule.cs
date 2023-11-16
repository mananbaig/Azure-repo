// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderSubscriptionStateRule. </summary>
    public partial class ProviderSubscriptionStateRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProviderSubscriptionStateRule"/>. </summary>
        public ProviderSubscriptionStateRule()
        {
            AllowedActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderSubscriptionStateRule"/>. </summary>
        /// <param name="state"></param>
        /// <param name="allowedActions"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderSubscriptionStateRule(ProviderSubscriptionState? state, IList<string> allowedActions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            AllowedActions = allowedActions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the state. </summary>
        public ProviderSubscriptionState? State { get; set; }
        /// <summary> Gets the allowed actions. </summary>
        public IList<string> AllowedActions { get; }
    }
}
