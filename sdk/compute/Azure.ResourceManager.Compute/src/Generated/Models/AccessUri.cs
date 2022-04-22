// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> A disk access SAS uri. </summary>
    public partial class AccessUri
    {
        /// <summary> Initializes a new instance of AccessUri. </summary>
        internal AccessUri()
        {
        }

        /// <summary> Initializes a new instance of AccessUri. </summary>
        /// <param name="accessSAS"> A SAS uri for accessing a disk. </param>
        /// <param name="securityDataAccessSAS"> A SAS uri for accessing a VM guest state. </param>
        internal AccessUri(string accessSAS, string securityDataAccessSAS)
        {
            AccessSAS = accessSAS;
            SecurityDataAccessSAS = securityDataAccessSAS;
        }

        /// <summary> A SAS uri for accessing a disk. </summary>
        public string AccessSAS { get; }
        /// <summary> A SAS uri for accessing a VM guest state. </summary>
        public string SecurityDataAccessSAS { get; }
    }
}
