// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> A Metadata for temporal set entity instances. </summary>
    public partial class TemporalSetMetadata : BaseMetadata
    {
        /// <summary> Initializes a new instance of <see cref="TemporalSetMetadata"/>. </summary>
        internal TemporalSetMetadata()
        {
            MetadataKind = MetadataKind.TemporalSetMetadata;
            Dates = new ChangeTrackingList<DateValue>();
        }

        /// <summary> Initializes a new instance of <see cref="TemporalSetMetadata"/>. </summary>
        /// <param name="metadataKind"> The entity Metadata object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dates"> List of date values. </param>
        internal TemporalSetMetadata(MetadataKind metadataKind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<DateValue> dates) : base(metadataKind, serializedAdditionalRawData)
        {
            Dates = dates;
        }

        /// <summary> List of date values. </summary>
        public IReadOnlyList<DateValue> Dates { get; }
    }
}
