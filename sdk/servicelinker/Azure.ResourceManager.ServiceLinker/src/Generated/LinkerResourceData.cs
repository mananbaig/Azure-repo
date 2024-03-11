// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceLinker.Models;

namespace Azure.ResourceManager.ServiceLinker
{
    /// <summary>
    /// A class representing the LinkerResource data model.
    /// Linker of source and target resource
    /// </summary>
    public partial class LinkerResourceData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinkerResourceData"/>. </summary>
        public LinkerResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkerResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="targetService">
        /// The target service properties
        /// Please note <see cref="TargetServiceBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceInfo"/>, <see cref="ConfluentBootstrapServerInfo"/> and <see cref="ConfluentSchemaRegistryInfo"/>.
        /// </param>
        /// <param name="authInfo">
        /// The authentication type.
        /// Please note <see cref="AuthBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretAuthInfo"/>, <see cref="ServicePrincipalCertificateAuthInfo"/>, <see cref="ServicePrincipalSecretAuthInfo"/>, <see cref="SystemAssignedIdentityAuthInfo"/> and <see cref="UserAssignedIdentityAuthInfo"/>.
        /// </param>
        /// <param name="clientType"> The application client type. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="vnetSolution"> The VNet solution. </param>
        /// <param name="secretStore"> An option to store secret value in secure place. </param>
        /// <param name="scope"> connection scope in source service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkerResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TargetServiceBaseInfo targetService, AuthBaseInfo authInfo, LinkerClientType? clientType, string provisioningState, VnetSolution vnetSolution, LinkerSecretStore secretStore, string scope, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            TargetService = targetService;
            AuthInfo = authInfo;
            ClientType = clientType;
            ProvisioningState = provisioningState;
            VnetSolution = vnetSolution;
            SecretStore = secretStore;
            Scope = scope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The target service properties
        /// Please note <see cref="TargetServiceBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceInfo"/>, <see cref="ConfluentBootstrapServerInfo"/> and <see cref="ConfluentSchemaRegistryInfo"/>.
        /// </summary>
        public TargetServiceBaseInfo TargetService { get; set; }
        /// <summary>
        /// The authentication type.
        /// Please note <see cref="AuthBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretAuthInfo"/>, <see cref="ServicePrincipalCertificateAuthInfo"/>, <see cref="ServicePrincipalSecretAuthInfo"/>, <see cref="SystemAssignedIdentityAuthInfo"/> and <see cref="UserAssignedIdentityAuthInfo"/>.
        /// </summary>
        public AuthBaseInfo AuthInfo { get; set; }
        /// <summary> The application client type. </summary>
        public LinkerClientType? ClientType { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The VNet solution. </summary>
        internal VnetSolution VnetSolution { get; set; }
        /// <summary> Type of VNet solution. </summary>
        public VnetSolutionType? SolutionType
        {
            get => VnetSolution is null ? default : VnetSolution.SolutionType;
            set
            {
                if (VnetSolution is null)
                    VnetSolution = new VnetSolution();
                VnetSolution.SolutionType = value;
            }
        }

        /// <summary> An option to store secret value in secure place. </summary>
        internal LinkerSecretStore SecretStore { get; set; }
        /// <summary> The key vault id to store secret. </summary>
        public ResourceIdentifier SecretStoreKeyVaultId
        {
            get => SecretStore is null ? default : SecretStore.KeyVaultId;
            set
            {
                if (SecretStore is null)
                    SecretStore = new LinkerSecretStore();
                SecretStore.KeyVaultId = value;
            }
        }

        /// <summary> connection scope in source service. </summary>
        public string Scope { get; set; }
    }
}
