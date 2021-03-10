// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for rename artifact. </summary>
    public partial class ArtifactRenameRequest
    {
        /// <summary> Initializes a new instance of ArtifactRenameRequest. </summary>
        public ArtifactRenameRequest()
        {
        }

        /// <summary> Initializes a new instance of ArtifactRenameRequest. </summary>
        /// <param name="newName"> New name of the artifact. </param>
        internal ArtifactRenameRequest(string newName)
        {
            NewName = newName;
        }

        /// <summary> New name of the artifact. </summary>
        public string NewName { get; set; }
    }
}
