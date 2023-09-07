// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Detail of action on the app. </summary>
    public partial class AppEventTypeDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppEventTypeDetail"/>. </summary>
        internal AppEventTypeDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppEventTypeDetail"/>. </summary>
        /// <param name="action"> Type of action of the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppEventTypeDetail(AppAction? action, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of action of the operation. </summary>
        public AppAction? Action { get; }
    }
}
