// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionRefreshStatus. </summary>
    public partial class LinkConnectionRefreshStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinkConnectionRefreshStatus"/>. </summary>
        internal LinkConnectionRefreshStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkConnectionRefreshStatus"/>. </summary>
        /// <param name="refreshStatus"> Link connection refresh status. </param>
        /// <param name="errorMessage"> Link connection refresh error message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkConnectionRefreshStatus(string refreshStatus, string errorMessage, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RefreshStatus = refreshStatus;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Link connection refresh status. </summary>
        public string RefreshStatus { get; }
        /// <summary> Link connection refresh error message. </summary>
        public string ErrorMessage { get; }
    }
}
