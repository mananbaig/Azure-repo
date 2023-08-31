// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataLakeGen2SharedKeyParamPatch. </summary>
    internal partial class DataLakeGen2SharedKeyParamPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeGen2SharedKeyParamPatch"/>. </summary>
        public DataLakeGen2SharedKeyParamPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeGen2SharedKeyParamPatch"/>. </summary>
        /// <param name="accountKey"> The account key to access the Azure Data Lake Storage Gen2. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeGen2SharedKeyParamPatch(string accountKey, Dictionary<string, BinaryData> rawData)
        {
            AccountKey = accountKey;
            _rawData = rawData;
        }

        /// <summary> The account key to access the Azure Data Lake Storage Gen2. </summary>
        public string AccountKey { get; set; }
    }
}
