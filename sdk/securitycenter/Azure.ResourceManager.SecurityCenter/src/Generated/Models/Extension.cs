// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> A plan's extension properties. </summary>
    public partial class Extension
    {
        /// <summary> Initializes a new instance of Extension. </summary>
        /// <param name="name">
        /// The extension name. Supported values are: &lt;br&gt;&lt;br&gt;**AgentlessDiscoveryForKubernetes** - API-based discovery of information about Kubernetes cluster architecture, workload objects, and setup. Required for Kubernetes inventory, identity and network exposure detection, attack path analysis and risk hunting as part of the cloud security explorer.
        /// Available for CloudPosture plan.&lt;br&gt;&lt;br&gt;**OnUploadMalwareScanning** - Limits the GB to be scanned per month for each storage account within the subscription. Once this limit reached on a given storage account, Blobs won't be scanned during current calendar month.
        /// Available for StorageAccounts plan.&lt;br&gt;&lt;br&gt;**SensitiveDataDiscovery** - Sensitive data discovery identifies Blob storage container with sensitive data such as credentials, credit cards, and more, to help prioritize and investigate security events.
        /// Available for StorageAccounts and CloudPosture plans.&lt;br&gt;&lt;br&gt;**ContainerRegistriesVulnerabilityAssessments** - Provides vulnerability management for images stored in your container registries.
        /// Available for CloudPosture and Containers plans.
        /// </param>
        /// <param name="isEnabled"> Indicates whether the extension is enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Extension(string name, IsEnabled isEnabled)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            IsEnabled = isEnabled;
            AdditionalExtensionProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of Extension. </summary>
        /// <param name="name">
        /// The extension name. Supported values are: &lt;br&gt;&lt;br&gt;**AgentlessDiscoveryForKubernetes** - API-based discovery of information about Kubernetes cluster architecture, workload objects, and setup. Required for Kubernetes inventory, identity and network exposure detection, attack path analysis and risk hunting as part of the cloud security explorer.
        /// Available for CloudPosture plan.&lt;br&gt;&lt;br&gt;**OnUploadMalwareScanning** - Limits the GB to be scanned per month for each storage account within the subscription. Once this limit reached on a given storage account, Blobs won't be scanned during current calendar month.
        /// Available for StorageAccounts plan.&lt;br&gt;&lt;br&gt;**SensitiveDataDiscovery** - Sensitive data discovery identifies Blob storage container with sensitive data such as credentials, credit cards, and more, to help prioritize and investigate security events.
        /// Available for StorageAccounts and CloudPosture plans.&lt;br&gt;&lt;br&gt;**ContainerRegistriesVulnerabilityAssessments** - Provides vulnerability management for images stored in your container registries.
        /// Available for CloudPosture and Containers plans.
        /// </param>
        /// <param name="isEnabled"> Indicates whether the extension is enabled. </param>
        /// <param name="additionalExtensionProperties"> Property values associated with the extension. </param>
        /// <param name="operationStatus"> Optional. A status describing the success/failure of the extension's enablement/disablement operation. </param>
        internal Extension(string name, IsEnabled isEnabled, IDictionary<string, BinaryData> additionalExtensionProperties, OperationStatus operationStatus)
        {
            Name = name;
            IsEnabled = isEnabled;
            AdditionalExtensionProperties = additionalExtensionProperties;
            OperationStatus = operationStatus;
        }

        /// <summary>
        /// The extension name. Supported values are: &lt;br&gt;&lt;br&gt;**AgentlessDiscoveryForKubernetes** - API-based discovery of information about Kubernetes cluster architecture, workload objects, and setup. Required for Kubernetes inventory, identity and network exposure detection, attack path analysis and risk hunting as part of the cloud security explorer.
        /// Available for CloudPosture plan.&lt;br&gt;&lt;br&gt;**OnUploadMalwareScanning** - Limits the GB to be scanned per month for each storage account within the subscription. Once this limit reached on a given storage account, Blobs won't be scanned during current calendar month.
        /// Available for StorageAccounts plan.&lt;br&gt;&lt;br&gt;**SensitiveDataDiscovery** - Sensitive data discovery identifies Blob storage container with sensitive data such as credentials, credit cards, and more, to help prioritize and investigate security events.
        /// Available for StorageAccounts and CloudPosture plans.&lt;br&gt;&lt;br&gt;**ContainerRegistriesVulnerabilityAssessments** - Provides vulnerability management for images stored in your container registries.
        /// Available for CloudPosture and Containers plans.
        /// </summary>
        public string Name { get; set; }
        /// <summary> Indicates whether the extension is enabled. </summary>
        public IsEnabled IsEnabled { get; set; }
        /// <summary>
        /// Property values associated with the extension.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IDictionary<string, BinaryData> AdditionalExtensionProperties { get; }
        /// <summary> Optional. A status describing the success/failure of the extension's enablement/disablement operation. </summary>
        public OperationStatus OperationStatus { get; }
    }
}
