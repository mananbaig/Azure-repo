// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Resume job properties. </summary>
    internal partial class ReplicationResumeJobProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReplicationResumeJobProperties"/>. </summary>
        public ReplicationResumeJobProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationResumeJobProperties"/>. </summary>
        /// <param name="comments"> Resume job comments. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReplicationResumeJobProperties(string comments, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Comments = comments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resume job comments. </summary>
        public string Comments { get; set; }
    }
}
