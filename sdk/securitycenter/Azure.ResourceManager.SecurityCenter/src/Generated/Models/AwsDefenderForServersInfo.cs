// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Defender for servers connection configuration. </summary>
    internal partial class AwsDefenderForServersInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AwsDefenderForServersInfo"/>. </summary>
        public AwsDefenderForServersInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AwsDefenderForServersInfo"/>. </summary>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AwsDefenderForServersInfo(string cloudRoleArn, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CloudRoleArn = cloudRoleArn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string CloudRoleArn { get; set; }
    }
}
