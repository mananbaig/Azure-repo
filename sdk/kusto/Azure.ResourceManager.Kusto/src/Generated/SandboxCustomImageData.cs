// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto
{
    /// <summary>
    /// A class representing the SandboxCustomImage data model.
    /// Class representing a Kusto sandbox custom image.
    /// </summary>
    public partial class SandboxCustomImageData : ResourceData
    {
        /// <summary> Initializes a new instance of SandboxCustomImageData. </summary>
        public SandboxCustomImageData()
        {
        }

        /// <summary> Initializes a new instance of SandboxCustomImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="language"> The language name, for example Python. </param>
        /// <param name="languageVersion"> The version of the language. </param>
        /// <param name="requirementsFileContent"> The requirements file content. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        internal SandboxCustomImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SandboxCustomImageLanguage? language, string languageVersion, string requirementsFileContent, KustoProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Language = language;
            LanguageVersion = languageVersion;
            RequirementsFileContent = requirementsFileContent;
            ProvisioningState = provisioningState;
        }

        /// <summary> The language name, for example Python. </summary>
        public SandboxCustomImageLanguage? Language { get; set; }
        /// <summary> The version of the language. </summary>
        public string LanguageVersion { get; set; }
        /// <summary> The requirements file content. </summary>
        public string RequirementsFileContent { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public KustoProvisioningState? ProvisioningState { get; }
    }
}
