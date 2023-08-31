// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Credentials for a user on a lab VM. </summary>
    public partial class LabVirtualMachineCredential
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineCredential"/>. </summary>
        /// <param name="username"> The username to use when signing in to lab VMs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public LabVirtualMachineCredential(string username)
        {
            Argument.AssertNotNull(username, nameof(username));

            Username = username;
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineCredential"/>. </summary>
        /// <param name="username"> The username to use when signing in to lab VMs. </param>
        /// <param name="password"> The password for the user. This is required for the TemplateVM createOption. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LabVirtualMachineCredential(string username, string password, Dictionary<string, BinaryData> rawData)
        {
            Username = username;
            Password = password;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineCredential"/> for deserialization. </summary>
        internal LabVirtualMachineCredential()
        {
        }

        /// <summary> The username to use when signing in to lab VMs. </summary>
        public string Username { get; set; }
        /// <summary> The password for the user. This is required for the TemplateVM createOption. </summary>
        public string Password { get; set; }
    }
}
