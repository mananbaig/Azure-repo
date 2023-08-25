// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machines network configuration's DNS settings. </summary>
    public partial class VirtualMachinePublicIPAddressDnsSettingsConfiguration
    {
        /// <summary> Initializes a new instance of VirtualMachinePublicIPAddressDnsSettingsConfiguration. </summary>
        /// <param name="domainNameLabel"> The Domain name label prefix of the PublicIPAddress resources that will be created. The generated name label is the concatenation of the domain name label and vm network profile unique ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainNameLabel"/> is null. </exception>
        public VirtualMachinePublicIPAddressDnsSettingsConfiguration(string domainNameLabel)
        {
            Argument.AssertNotNull(domainNameLabel, nameof(domainNameLabel));

            DomainNameLabel = domainNameLabel;
        }

        /// <summary> Initializes a new instance of VirtualMachinePublicIPAddressDnsSettingsConfiguration. </summary>
        /// <param name="domainNameLabel"> The Domain name label prefix of the PublicIPAddress resources that will be created. The generated name label is the concatenation of the domain name label and vm network profile unique ID. </param>
        /// <param name="domainNameLabelScope"> The Domain name label scope of the PublicIPAddress resources that will be created. The generated name label is the concatenation of the hashed domain name label with policy according to the domain name label scope and vm network profile unique ID. </param>
        internal VirtualMachinePublicIPAddressDnsSettingsConfiguration(string domainNameLabel, DomainNameLabelScopeType? domainNameLabelScope)
        {
            DomainNameLabel = domainNameLabel;
            DomainNameLabelScope = domainNameLabelScope;
        }

        /// <summary> The Domain name label prefix of the PublicIPAddress resources that will be created. The generated name label is the concatenation of the domain name label and vm network profile unique ID. </summary>
        public string DomainNameLabel { get; set; }
        /// <summary> The Domain name label scope of the PublicIPAddress resources that will be created. The generated name label is the concatenation of the hashed domain name label with policy according to the domain name label scope and vm network profile unique ID. </summary>
        public DomainNameLabelScopeType? DomainNameLabelScope { get; set; }
    }
}
