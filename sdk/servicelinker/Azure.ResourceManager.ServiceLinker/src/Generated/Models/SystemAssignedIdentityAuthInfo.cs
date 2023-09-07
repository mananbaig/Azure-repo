// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The authentication info when authType is systemAssignedIdentity. </summary>
    public partial class SystemAssignedIdentityAuthInfo : AuthBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="SystemAssignedIdentityAuthInfo"/>. </summary>
        public SystemAssignedIdentityAuthInfo()
        {
            AuthType = LinkerAuthType.SystemAssignedIdentity;
        }

        /// <summary> Initializes a new instance of <see cref="SystemAssignedIdentityAuthInfo"/>. </summary>
        /// <param name="authType"> The authentication type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SystemAssignedIdentityAuthInfo(LinkerAuthType authType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(authType, serializedAdditionalRawData)
        {
            AuthType = authType;
        }
    }
}
