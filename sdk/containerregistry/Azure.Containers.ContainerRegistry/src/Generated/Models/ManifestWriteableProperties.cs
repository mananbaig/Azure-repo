// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Changeable attributes. </summary>
    public partial class ManifestWriteableProperties
    {
        /// <summary> Initializes a new instance of ManifestWriteableProperties. </summary>
        public ManifestWriteableProperties()
        {
        }

        /// <summary> Initializes a new instance of ManifestWriteableProperties. </summary>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        /// <param name="quarantineState"> Quarantine state. </param>
        /// <param name="quarantineDetails"> Quarantine details. </param>
        internal ManifestWriteableProperties(bool? canDelete, bool? canWrite, bool? canList, bool? canRead, string quarantineState, string quarantineDetails)
        {
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
            QuarantineState = quarantineState;
            QuarantineDetails = quarantineDetails;
        }

        /// <summary> Delete enabled. </summary>
        public bool? CanDelete { get; set; }
        /// <summary> Write enabled. </summary>
        public bool? CanWrite { get; set; }
        /// <summary> List enabled. </summary>
        public bool? CanList { get; set; }
        /// <summary> Read enabled. </summary>
        public bool? CanRead { get; set; }
    }
}
