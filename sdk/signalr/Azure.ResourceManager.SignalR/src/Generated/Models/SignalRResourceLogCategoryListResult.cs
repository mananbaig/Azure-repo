// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Resource log configuration of a Microsoft.SignalRService resource. </summary>
    internal partial class SignalRResourceLogCategoryListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRResourceLogCategoryListResult"/>. </summary>
        public SignalRResourceLogCategoryListResult()
        {
            Categories = new ChangeTrackingList<SignalRResourceLogCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="SignalRResourceLogCategoryListResult"/>. </summary>
        /// <param name="categories"> Gets or sets the list of category configurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRResourceLogCategoryListResult(IList<SignalRResourceLogCategory> categories, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Categories = categories;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the list of category configurations. </summary>
        public IList<SignalRResourceLogCategory> Categories { get; }
    }
}
