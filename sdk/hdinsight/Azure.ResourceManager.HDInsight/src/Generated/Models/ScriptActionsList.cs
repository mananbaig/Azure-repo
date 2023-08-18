// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The persisted script action for the cluster. </summary>
    internal partial class ScriptActionsList
    {
        /// <summary> Initializes a new instance of ScriptActionsList. </summary>
        internal ScriptActionsList()
        {
            Value = new Core.ChangeTrackingList<RuntimeScriptActionDetail>();
        }

        /// <summary> Initializes a new instance of ScriptActionsList. </summary>
        /// <param name="value"> The list of persisted script action details for the cluster. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal ScriptActionsList(IReadOnlyList<RuntimeScriptActionDetail> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of persisted script action details for the cluster. </summary>
        public IReadOnlyList<RuntimeScriptActionDetail> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
