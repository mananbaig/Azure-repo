// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Keys extracted by the custom model. </summary>
    internal partial class KeysResult
    {
        /// <summary> Initializes a new instance of <see cref="KeysResult"/>. </summary>
        /// <param name="clusters"> Object mapping clusterIds to a list of keys. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusters"/> is null. </exception>
        internal KeysResult(IReadOnlyDictionary<string, IList<string>> clusters)
        {
            Argument.AssertNotNull(clusters, nameof(clusters));

            Clusters = clusters;
        }

        /// <summary> Object mapping clusterIds to a list of keys. </summary>
        public IReadOnlyDictionary<string, IList<string>> Clusters { get; }
    }
}
