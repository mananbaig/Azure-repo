// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> An Access policy. </summary>
    public partial class ShareAccessPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ShareAccessPolicy"/>. </summary>
        public ShareAccessPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ShareAccessPolicy"/>. </summary>
        /// <param name="policyStartsOn"> The date-time the policy is active. </param>
        /// <param name="policyExpiresOn"> The date-time the policy expires. </param>
        /// <param name="permissions"> The permissions for the ACL policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareAccessPolicy(DateTimeOffset? policyStartsOn, DateTimeOffset? policyExpiresOn, string permissions, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyStartsOn = policyStartsOn;
            PolicyExpiresOn = policyExpiresOn;
            Permissions = permissions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
