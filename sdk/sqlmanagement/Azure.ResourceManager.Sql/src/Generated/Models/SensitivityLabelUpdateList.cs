// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of sensitivity label update operations. </summary>
    public partial class SensitivityLabelUpdateList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SensitivityLabelUpdateList"/>. </summary>
        public SensitivityLabelUpdateList()
        {
            Operations = new ChangeTrackingList<SensitivityLabelUpdate>();
        }

        /// <summary> Initializes a new instance of <see cref="SensitivityLabelUpdateList"/>. </summary>
        /// <param name="operations"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SensitivityLabelUpdateList(IList<SensitivityLabelUpdate> operations, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Operations = operations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the operations. </summary>
        public IList<SensitivityLabelUpdate> Operations { get; }
    }
}
