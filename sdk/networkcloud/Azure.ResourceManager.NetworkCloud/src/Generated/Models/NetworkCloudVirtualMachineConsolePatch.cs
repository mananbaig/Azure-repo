// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ConsolePatchParameters represents the body of the request to patch the virtual machine console. </summary>
    public partial class NetworkCloudVirtualMachineConsolePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudVirtualMachineConsolePatch"/>. </summary>
        public NetworkCloudVirtualMachineConsolePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudVirtualMachineConsolePatch"/>. </summary>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        /// <param name="enabled"> The credentials used to login to the image repository that has access to the specified image. </param>
        /// <param name="expireOn"> The date and time after which the key will be disallowed access. </param>
        /// <param name="sshPublicKey"> The SSH public key that will be provisioned for user access. The user is expected to have the corresponding SSH private key for logging in. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudVirtualMachineConsolePatch(IDictionary<string, string> tags, ConsoleEnabled? enabled, DateTimeOffset? expireOn, NetworkCloudSshPublicKey sshPublicKey, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            Enabled = enabled;
            ExpireOn = expireOn;
            SshPublicKey = sshPublicKey;
            _rawData = rawData;
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The credentials used to login to the image repository that has access to the specified image. </summary>
        public ConsoleEnabled? Enabled { get; set; }
        /// <summary> The date and time after which the key will be disallowed access. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> The SSH public key that will be provisioned for user access. The user is expected to have the corresponding SSH private key for logging in. </summary>
        internal NetworkCloudSshPublicKey SshPublicKey { get; set; }
        /// <summary> The SSH public key data. </summary>
        public string KeyData
        {
            get => SshPublicKey is null ? default : SshPublicKey.KeyData;
            set => SshPublicKey = new NetworkCloudSshPublicKey(value);
        }
    }
}
