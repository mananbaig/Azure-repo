// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the ApiKeyVaultReference data model.
    /// Description of site key vault references.
    /// </summary>
    public partial class ApiKeyVaultReferenceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiKeyVaultReferenceData"/>. </summary>
        public ApiKeyVaultReferenceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiKeyVaultReferenceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="reference"></param>
        /// <param name="status"></param>
        /// <param name="vaultName"></param>
        /// <param name="secretName"></param>
        /// <param name="secretVersion"></param>
        /// <param name="identity"> Managed service identity. </param>
        /// <param name="details"></param>
        /// <param name="source"></param>
        /// <param name="activeVersion"></param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiKeyVaultReferenceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string reference, ResolveStatus? status, string vaultName, string secretName, string secretVersion, ManagedServiceIdentity identity, string details, ConfigReferenceSource? source, string activeVersion, string kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Reference = reference;
            Status = status;
            VaultName = vaultName;
            SecretName = secretName;
            SecretVersion = secretVersion;
            Identity = identity;
            Details = details;
            Source = source;
            ActiveVersion = activeVersion;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the reference. </summary>
        public string Reference { get; set; }
        /// <summary> Gets or sets the status. </summary>
        public ResolveStatus? Status { get; set; }
        /// <summary> Gets or sets the vault name. </summary>
        public string VaultName { get; set; }
        /// <summary> Gets or sets the secret name. </summary>
        public string SecretName { get; set; }
        /// <summary> Gets or sets the secret version. </summary>
        public string SecretVersion { get; set; }
        /// <summary> Managed service identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets or sets the details. </summary>
        public string Details { get; set; }
        /// <summary> Gets or sets the source. </summary>
        public ConfigReferenceSource? Source { get; set; }
        /// <summary> Gets or sets the active version. </summary>
        public string ActiveVersion { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
