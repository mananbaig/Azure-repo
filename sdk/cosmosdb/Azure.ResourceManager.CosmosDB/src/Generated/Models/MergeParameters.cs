// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The properties of an Azure Cosmos DB merge operations. </summary>
    public partial class MergeParameters
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MergeParameters"/>. </summary>
        public MergeParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MergeParameters"/>. </summary>
        /// <param name="isDryRun"> Specifies whether the operation is a real merge operation or a simulation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MergeParameters(bool? isDryRun, Dictionary<string, BinaryData> rawData)
        {
            IsDryRun = isDryRun;
            _rawData = rawData;
        }

        /// <summary> Specifies whether the operation is a real merge operation or a simulation. </summary>
        public bool? IsDryRun { get; set; }
    }
}
