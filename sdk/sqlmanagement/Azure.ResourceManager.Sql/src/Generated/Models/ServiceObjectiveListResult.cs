// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents the response to a get database service objectives request. </summary>
    internal partial class ServiceObjectiveListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceObjectiveListResult"/>. </summary>
        /// <param name="value"> The list of database service objectives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ServiceObjectiveListResult(IEnumerable<ServiceObjectiveData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceObjectiveListResult"/>. </summary>
        /// <param name="value"> The list of database service objectives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceObjectiveListResult(IReadOnlyList<ServiceObjectiveData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceObjectiveListResult"/> for deserialization. </summary>
        internal ServiceObjectiveListResult()
        {
        }

        /// <summary> The list of database service objectives. </summary>
        public IReadOnlyList<ServiceObjectiveData> Value { get; }
    }
}
