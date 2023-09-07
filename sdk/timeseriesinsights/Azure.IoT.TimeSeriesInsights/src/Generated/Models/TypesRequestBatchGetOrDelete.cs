// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Request to get or delete time series types by IDs or type names. Exactly one of "typeIds" or "names" must be set. </summary>
    internal partial class TypesRequestBatchGetOrDelete
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TypesRequestBatchGetOrDelete"/>. </summary>
        public TypesRequestBatchGetOrDelete()
        {
            TypeIds = new ChangeTrackingList<string>();
            Names = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="TypesRequestBatchGetOrDelete"/>. </summary>
        /// <param name="typeIds"> List of IDs of time series types to return or delete. </param>
        /// <param name="names"> List of names of time series types to return or delete. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TypesRequestBatchGetOrDelete(IList<string> typeIds, IList<string> names, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TypeIds = typeIds;
            Names = names;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of IDs of time series types to return or delete. </summary>
        public IList<string> TypeIds { get; }
        /// <summary> List of names of time series types to return or delete. </summary>
        public IList<string> Names { get; }
    }
}
