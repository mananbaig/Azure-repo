// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Detail of action on the app service plan. </summary>
    public partial class AppServicePlanEventTypeDetail
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServicePlanEventTypeDetail"/>. </summary>
        internal AppServicePlanEventTypeDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServicePlanEventTypeDetail"/>. </summary>
        /// <param name="stampKind"> Kind of environment where app service plan is. </param>
        /// <param name="action"> Type of action on the app service plan. </param>
        /// <param name="status"> Asynchronous operation status of the operation on the app service plan. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServicePlanEventTypeDetail(StampKind? stampKind, AppServicePlanAction? action, AsyncStatus? status, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StampKind = stampKind;
            Action = action;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Kind of environment where app service plan is. </summary>
        public StampKind? StampKind { get; }
        /// <summary> Type of action on the app service plan. </summary>
        public AppServicePlanAction? Action { get; }
        /// <summary> Asynchronous operation status of the operation on the app service plan. </summary>
        public AsyncStatus? Status { get; }
    }
}
