// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The account endpoints. </summary>
    public partial class PurviewAccountEndpoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PurviewAccountEndpoint"/>. </summary>
        internal PurviewAccountEndpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountEndpoint"/>. </summary>
        /// <param name="catalog"> Gets the catalog endpoint. </param>
        /// <param name="guardian"> Gets the guardian endpoint. </param>
        /// <param name="scan"> Gets the scan endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewAccountEndpoint(string catalog, string guardian, string scan, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Catalog = catalog;
            Guardian = guardian;
            Scan = scan;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the catalog endpoint. </summary>
        public string Catalog { get; }
        /// <summary> Gets the guardian endpoint. </summary>
        public string Guardian { get; }
        /// <summary> Gets the scan endpoint. </summary>
        public string Scan { get; }
    }
}
