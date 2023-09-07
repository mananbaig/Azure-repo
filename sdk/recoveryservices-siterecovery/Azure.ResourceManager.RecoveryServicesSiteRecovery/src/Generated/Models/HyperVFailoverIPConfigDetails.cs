// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The HyperVFailoverIPConfigDetails. </summary>
    public partial class HyperVFailoverIPConfigDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HyperVFailoverIPConfigDetails"/>. </summary>
        public HyperVFailoverIPConfigDetails()
        {
            RecoveryLBBackendAddressPoolIds = new ChangeTrackingList<string>();
            TfoLBBackendAddressPoolIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="HyperVFailoverIPConfigDetails"/>. </summary>
        /// <param name="ipConfigName"></param>
        /// <param name="isPrimary"></param>
        /// <param name="isSeletedForFailover"></param>
        /// <param name="recoverySubnetName"></param>
        /// <param name="recoveryStaticIPAddress"></param>
        /// <param name="recoveryPublicIPAddressId"></param>
        /// <param name="recoveryLBBackendAddressPoolIds"></param>
        /// <param name="tfoSubnetName"></param>
        /// <param name="tfoStaticIPAddress"></param>
        /// <param name="tfoPublicIPAddressId"></param>
        /// <param name="tfoLBBackendAddressPoolIds"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVFailoverIPConfigDetails(string ipConfigName, bool? isPrimary, bool? isSeletedForFailover, string recoverySubnetName, IPAddress recoveryStaticIPAddress, ResourceIdentifier recoveryPublicIPAddressId, IList<string> recoveryLBBackendAddressPoolIds, string tfoSubnetName, IPAddress tfoStaticIPAddress, ResourceIdentifier tfoPublicIPAddressId, IList<string> tfoLBBackendAddressPoolIds, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPConfigName = ipConfigName;
            IsPrimary = isPrimary;
            IsSeletedForFailover = isSeletedForFailover;
            RecoverySubnetName = recoverySubnetName;
            RecoveryStaticIPAddress = recoveryStaticIPAddress;
            RecoveryPublicIPAddressId = recoveryPublicIPAddressId;
            RecoveryLBBackendAddressPoolIds = recoveryLBBackendAddressPoolIds;
            TfoSubnetName = tfoSubnetName;
            TfoStaticIPAddress = tfoStaticIPAddress;
            TfoPublicIPAddressId = tfoPublicIPAddressId;
            TfoLBBackendAddressPoolIds = tfoLBBackendAddressPoolIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the ip config name. </summary>
        public string IPConfigName { get; set; }
        /// <summary> Gets or sets the is primary. </summary>
        public bool? IsPrimary { get; set; }
        /// <summary> Gets or sets the is seleted for failover. </summary>
        public bool? IsSeletedForFailover { get; set; }
        /// <summary> Gets or sets the recovery subnet name. </summary>
        public string RecoverySubnetName { get; set; }
        /// <summary> Gets or sets the recovery static ip address. </summary>
        public IPAddress RecoveryStaticIPAddress { get; set; }
        /// <summary> Gets or sets the recovery public ip address id. </summary>
        public ResourceIdentifier RecoveryPublicIPAddressId { get; set; }
        /// <summary> Gets the recovery lb backend address pool ids. </summary>
        public IList<string> RecoveryLBBackendAddressPoolIds { get; }
        /// <summary> Gets or sets the tfo subnet name. </summary>
        public string TfoSubnetName { get; set; }
        /// <summary> Gets or sets the tfo static ip address. </summary>
        public IPAddress TfoStaticIPAddress { get; set; }
        /// <summary> Gets or sets the tfo public ip address id. </summary>
        public ResourceIdentifier TfoPublicIPAddressId { get; set; }
        /// <summary> Gets the tfo lb backend address pool ids. </summary>
        public IList<string> TfoLBBackendAddressPoolIds { get; }
    }
}
