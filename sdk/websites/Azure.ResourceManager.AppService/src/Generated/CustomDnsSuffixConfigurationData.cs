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
    /// A class representing the CustomDnsSuffixConfiguration data model.
    /// Full view of the custom domain suffix configuration for ASEv3.
    /// </summary>
    public partial class CustomDnsSuffixConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="CustomDnsSuffixConfigurationData"/>. </summary>
        public CustomDnsSuffixConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomDnsSuffixConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"></param>
        /// <param name="provisioningDetails"></param>
        /// <param name="dnsSuffix"> The default custom domain suffix to use for all sites deployed on the ASE. </param>
        /// <param name="certificateUri"> The URL referencing the Azure Key Vault certificate secret that should be used as the default SSL/TLS certificate for sites with the custom domain suffix. </param>
        /// <param name="keyVaultReferenceIdentity"> The user-assigned identity to use for resolving the key vault certificate reference. If not specified, the system-assigned ASE identity will be used if available. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomDnsSuffixConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CustomDnsSuffixProvisioningState? provisioningState, string provisioningDetails, string dnsSuffix, Uri certificateUri, string keyVaultReferenceIdentity, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            ProvisioningDetails = provisioningDetails;
            DnsSuffix = dnsSuffix;
            CertificateUri = certificateUri;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the provisioning state. </summary>
        [WirePath("properties.provisioningState")]
        public CustomDnsSuffixProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the provisioning details. </summary>
        [WirePath("properties.provisioningDetails")]
        public string ProvisioningDetails { get; }
        /// <summary> The default custom domain suffix to use for all sites deployed on the ASE. </summary>
        [WirePath("properties.dnsSuffix")]
        public string DnsSuffix { get; set; }
        /// <summary> The URL referencing the Azure Key Vault certificate secret that should be used as the default SSL/TLS certificate for sites with the custom domain suffix. </summary>
        [WirePath("properties.certificateUrl")]
        public Uri CertificateUri { get; set; }
        /// <summary> The user-assigned identity to use for resolving the key vault certificate reference. If not specified, the system-assigned ASE identity will be used if available. </summary>
        [WirePath("properties.keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; set; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
