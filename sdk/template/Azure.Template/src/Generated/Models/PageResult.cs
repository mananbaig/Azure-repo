// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Extracted information from a single page. </summary>
    public partial class PageResult
    {
        /// <summary> Page number. </summary>
        public int Page { get; set; }
        /// <summary> Cluster identifier. </summary>
        public int? ClusterId { get; set; }
        /// <summary> List of key-value pairs extracted from the page. </summary>
        public ICollection<KeyValuePair> KeyValuePairs { get; set; }
        /// <summary> List of data tables extracted from the page. </summary>
        public ICollection<DataTable> Tables { get; set; }
    }
}
