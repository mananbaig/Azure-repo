// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace OperationalInsightsManagementClient.Models
{
    /// <summary> The shared keys for a workspace. </summary>
    public partial class SharedKeys
    {
        /// <summary> Initializes a new instance of SharedKeys. </summary>
        internal SharedKeys()
        {
        }

        /// <summary> Initializes a new instance of SharedKeys. </summary>
        /// <param name="primarySharedKey"> The primary shared key of a workspace. </param>
        /// <param name="secondarySharedKey"> The secondary shared key of a workspace. </param>
        internal SharedKeys(string primarySharedKey, string secondarySharedKey)
        {
            PrimarySharedKey = primarySharedKey;
            SecondarySharedKey = secondarySharedKey;
        }

        /// <summary> The primary shared key of a workspace. </summary>
        public string PrimarySharedKey { get; }
        /// <summary> The secondary shared key of a workspace. </summary>
        public string SecondarySharedKey { get; }
    }
}
