// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering.Models
{
    /// <summary> Find QnAs that are associated with the given list of metadata. </summary>
    public partial class MetadataFilter
    {
        /// <summary> Initializes a new instance of MetadataFilter. </summary>
        public MetadataFilter()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> (Optional) Set to &apos;OR&apos; for joining metadata using &apos;OR&apos; operation. </summary>
        public CompoundOperationKind? CompoundOperation { get; set; }
    }
}
