// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Configuration properties that define the mutable settings of a Container App SourceControl. </summary>
    public partial class ContainerAppGitHubActionConfiguration
    {
        /// <summary> Initializes a new instance of ContainerAppGitHubActionConfiguration. </summary>
        public ContainerAppGitHubActionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppGitHubActionConfiguration. </summary>
        /// <param name="registryInfo"> Registry configurations. </param>
        /// <param name="azureCredentials"> AzureCredentials configurations. </param>
        /// <param name="contextPath"> Context path. </param>
        /// <param name="gitHubPersonalAccessToken"> One time Github PAT to configure github environment. </param>
        /// <param name="image"> Image name. </param>
        /// <param name="publishType"> Code or Image. </param>
        /// <param name="os"> Operation system. </param>
        /// <param name="runtimeStack"> Runtime stack. </param>
        /// <param name="runtimeVersion"> Runtime version. </param>
        internal ContainerAppGitHubActionConfiguration(ContainerAppRegistryInfo registryInfo, ContainerAppCredentials azureCredentials, string contextPath, string gitHubPersonalAccessToken, string image, string publishType, string os, string runtimeStack, string runtimeVersion)
        {
            RegistryInfo = registryInfo;
            AzureCredentials = azureCredentials;
            ContextPath = contextPath;
            GitHubPersonalAccessToken = gitHubPersonalAccessToken;
            Image = image;
            PublishType = publishType;
            OS = os;
            RuntimeStack = runtimeStack;
            RuntimeVersion = runtimeVersion;
        }

        /// <summary> Registry configurations. </summary>
        public ContainerAppRegistryInfo RegistryInfo { get; set; }
        /// <summary> AzureCredentials configurations. </summary>
        public ContainerAppCredentials AzureCredentials { get; set; }
        /// <summary> Context path. </summary>
        public string ContextPath { get; set; }
        /// <summary> One time Github PAT to configure github environment. </summary>
        public string GitHubPersonalAccessToken { get; set; }
        /// <summary> Image name. </summary>
        public string Image { get; set; }
        /// <summary> Code or Image. </summary>
        public string PublishType { get; set; }
        /// <summary> Operation system. </summary>
        public string OS { get; set; }
        /// <summary> Runtime stack. </summary>
        public string RuntimeStack { get; set; }
        /// <summary> Runtime version. </summary>
        public string RuntimeVersion { get; set; }
    }
}
