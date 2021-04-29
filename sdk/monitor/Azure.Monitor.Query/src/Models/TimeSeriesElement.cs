﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace Azure.Monitor.Query.Models
{
    public partial class TimeSeriesElement
    {
        private Dictionary<string,string> _metadata;
        private IReadOnlyList<MetadataValue> Metadatavalues { get; }

        /// <summary> the metadata values returned if $filter was specified in the call. </summary>
        public IReadOnlyDictionary<string, string> Metadata => _metadata ??= Metadatavalues.ToDictionary(m => m.Name.Value, m => m.Value);
    }
}