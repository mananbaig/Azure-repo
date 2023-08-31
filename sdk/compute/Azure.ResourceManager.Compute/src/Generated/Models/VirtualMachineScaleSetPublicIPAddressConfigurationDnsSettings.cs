// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machines scale sets network configuration's DNS settings. </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings"/>. </summary>
        /// <param name="domainNameLabel"> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainNameLabel"/> is null. </exception>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(string domainNameLabel)
        {
            Argument.AssertNotNull(domainNameLabel, nameof(domainNameLabel));

            DomainNameLabel = domainNameLabel;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings"/>. </summary>
        /// <param name="domainNameLabel"> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </param>
        /// <param name="domainNameLabelScope"> The Domain name label scope.The concatenation of the hashed domain name label that generated according to the policy from domain name label scope and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(string domainNameLabel, DomainNameLabelScopeType? domainNameLabelScope, Dictionary<string, BinaryData> rawData)
        {
            DomainNameLabel = domainNameLabel;
            DomainNameLabelScope = domainNameLabelScope;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings"/> for deserialization. </summary>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings()
        {
        }

        /// <summary> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public string DomainNameLabel { get; set; }
        /// <summary> The Domain name label scope.The concatenation of the hashed domain name label that generated according to the policy from domain name label scope and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public DomainNameLabelScopeType? DomainNameLabelScope { get; set; }
    }
}
