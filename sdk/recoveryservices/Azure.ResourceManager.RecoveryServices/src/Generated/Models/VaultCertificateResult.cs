// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Certificate corresponding to a vault that can be used by clients to register themselves with the vault. </summary>
    public partial class VaultCertificateResult : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VaultCertificateResult"/>. </summary>
        internal VaultCertificateResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VaultCertificateResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Certificate details representing the Vault credentials.
        /// Please note <see cref="ResourceCertificateDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ResourceCertificateAndAcsDetails"/> and <see cref="ResourceCertificateAndAadDetails"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VaultCertificateResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceCertificateDetails properties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Certificate details representing the Vault credentials.
        /// Please note <see cref="ResourceCertificateDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ResourceCertificateAndAcsDetails"/> and <see cref="ResourceCertificateAndAadDetails"/>.
        /// </summary>
        public ResourceCertificateDetails Properties { get; }
    }
}
