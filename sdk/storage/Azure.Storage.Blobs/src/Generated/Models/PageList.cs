// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> the list of pages. </summary>
    internal partial class PageList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PageList"/>. </summary>
        internal PageList()
        {
            PageRange = new ChangeTrackingList<PageRange>();
            ClearRange = new ChangeTrackingList<ClearRange>();
        }

        /// <summary> Initializes a new instance of <see cref="PageList"/>. </summary>
        /// <param name="pageRange"></param>
        /// <param name="clearRange"></param>
        /// <param name="nextMarker"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PageList(IReadOnlyList<PageRange> pageRange, IReadOnlyList<ClearRange> clearRange, string nextMarker, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PageRange = pageRange;
            ClearRange = clearRange;
            NextMarker = nextMarker;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the page range. </summary>
        public IReadOnlyList<PageRange> PageRange { get; }
        /// <summary> Gets the clear range. </summary>
        public IReadOnlyList<ClearRange> ClearRange { get; }
        /// <summary> Gets the next marker. </summary>
        public string NextMarker { get; }
    }
}
