// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Result of the What-If operation. Contains a list of predicted changes and a URL link to get to the next set of results. </summary>
    public partial class WhatIfOperationResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WhatIfOperationResult"/>. </summary>
        internal WhatIfOperationResult()
        {
            Changes = new ChangeTrackingList<WhatIfChange>();
        }

        /// <summary> Initializes a new instance of <see cref="WhatIfOperationResult"/>. </summary>
        /// <param name="status"> Status of the What-If operation. </param>
        /// <param name="error"> Error when What-If operation fails. </param>
        /// <param name="changes"> List of resource changes predicted by What-If operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WhatIfOperationResult(string status, ResponseError error, IReadOnlyList<WhatIfChange> changes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Error = error;
            Changes = changes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status of the What-If operation. </summary>
        public string Status { get; }
        /// <summary> Error when What-If operation fails. </summary>
        public ResponseError Error { get; }
        /// <summary> List of resource changes predicted by What-If operation. </summary>
        public IReadOnlyList<WhatIfChange> Changes { get; }
    }
}
