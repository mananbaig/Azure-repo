// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SiteSourceControl data model. </summary>
    public partial class SiteSourceControlData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SiteSourceControlData. </summary>
        public SiteSourceControlData()
        {
        }

        /// <summary> Initializes a new instance of SiteSourceControlData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="repoUri"> Repository or source control URL. </param>
        /// <param name="branch"> Name of branch to use for deployment. </param>
        /// <param name="isManualIntegration"> &lt;code&gt;true&lt;/code&gt; to limit to manual integration; &lt;code&gt;false&lt;/code&gt; to enable continuous integration (which configures webhooks into online repos like GitHub). </param>
        /// <param name="isGitHubAction"> &lt;code&gt;true&lt;/code&gt; if this is deployed via GitHub action. </param>
        /// <param name="deploymentRollbackEnabled"> &lt;code&gt;true&lt;/code&gt; to enable deployment rollback; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isMercurial"> &lt;code&gt;true&lt;/code&gt; for a Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git repository. </param>
        /// <param name="gitHubActionConfiguration"> If GitHub Action is selected, than the associated configuration. </param>
        internal SiteSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string repoUri, string branch, bool? isManualIntegration, bool? isGitHubAction, bool? deploymentRollbackEnabled, bool? isMercurial, GitHubActionConfiguration gitHubActionConfiguration) : base(id, name, resourceType, systemData, kind)
        {
            RepoUri = repoUri;
            Branch = branch;
            IsManualIntegration = isManualIntegration;
            IsGitHubAction = isGitHubAction;
            DeploymentRollbackEnabled = deploymentRollbackEnabled;
            IsMercurial = isMercurial;
            GitHubActionConfiguration = gitHubActionConfiguration;
        }

        /// <summary> Repository or source control URL. </summary>
        public string RepoUri { get; set; }
        /// <summary> Name of branch to use for deployment. </summary>
        public string Branch { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to limit to manual integration; &lt;code&gt;false&lt;/code&gt; to enable continuous integration (which configures webhooks into online repos like GitHub). </summary>
        public bool? IsManualIntegration { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this is deployed via GitHub action. </summary>
        public bool? IsGitHubAction { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to enable deployment rollback; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? DeploymentRollbackEnabled { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; for a Mercurial repository; &lt;code&gt;false&lt;/code&gt; for a Git repository. </summary>
        public bool? IsMercurial { get; set; }
        /// <summary> If GitHub Action is selected, than the associated configuration. </summary>
        public GitHubActionConfiguration GitHubActionConfiguration { get; set; }
    }
}
