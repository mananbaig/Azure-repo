// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Git integration settings. </summary>
    public partial class SynapseWorkspaceRepositoryConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceRepositoryConfiguration"/>. </summary>
        public SynapseWorkspaceRepositoryConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkspaceRepositoryConfiguration"/>. </summary>
        /// <param name="workspaceRepositoryConfigurationType"> Type of workspace repositoryID configuration. Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration. </param>
        /// <param name="hostName"> GitHub Enterprise host name. For example: https://github.mydomain.com. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="projectName"> VSTS project name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder to use in the repository. </param>
        /// <param name="lastCommitId"> The last commit ID. </param>
        /// <param name="tenantId"> The VSTS tenant ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseWorkspaceRepositoryConfiguration(string workspaceRepositoryConfigurationType, string hostName, string accountName, string projectName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId, Guid? tenantId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            WorkspaceRepositoryConfigurationType = workspaceRepositoryConfigurationType;
            HostName = hostName;
            AccountName = accountName;
            ProjectName = projectName;
            RepositoryName = repositoryName;
            CollaborationBranch = collaborationBranch;
            RootFolder = rootFolder;
            LastCommitId = lastCommitId;
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of workspace repositoryID configuration. Example WorkspaceVSTSConfiguration, WorkspaceGitHubConfiguration. </summary>
        public string WorkspaceRepositoryConfigurationType { get; set; }
        /// <summary> GitHub Enterprise host name. For example: https://github.mydomain.com. </summary>
        public string HostName { get; set; }
        /// <summary> Account name. </summary>
        public string AccountName { get; set; }
        /// <summary> VSTS project name. </summary>
        public string ProjectName { get; set; }
        /// <summary> Repository name. </summary>
        public string RepositoryName { get; set; }
        /// <summary> Collaboration branch. </summary>
        public string CollaborationBranch { get; set; }
        /// <summary> Root folder to use in the repository. </summary>
        public string RootFolder { get; set; }
        /// <summary> The last commit ID. </summary>
        public string LastCommitId { get; set; }
        /// <summary> The VSTS tenant ID. </summary>
        public Guid? TenantId { get; set; }
    }
}
