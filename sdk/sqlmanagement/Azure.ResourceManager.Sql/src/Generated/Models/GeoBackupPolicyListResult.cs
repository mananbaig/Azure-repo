// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The response to a list geo backup policies request. </summary>
    internal partial class GeoBackupPolicyListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GeoBackupPolicyListResult"/>. </summary>
        internal GeoBackupPolicyListResult()
        {
            Value = new ChangeTrackingList<GeoBackupPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="GeoBackupPolicyListResult"/>. </summary>
        /// <param name="value"> The list of geo backup policies. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoBackupPolicyListResult(IReadOnlyList<GeoBackupPolicyData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of geo backup policies. </summary>
        public IReadOnlyList<GeoBackupPolicyData> Value { get; }
    }
}
