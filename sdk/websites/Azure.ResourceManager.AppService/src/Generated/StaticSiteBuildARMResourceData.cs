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
    /// <summary> A class representing the StaticSiteBuildARMResource data model. </summary>
    public partial class StaticSiteBuildARMResourceData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="StaticSiteBuildARMResourceData"/>. </summary>
        public StaticSiteBuildARMResourceData()
        {
            UserProvidedFunctionApps = new ChangeTrackingList<StaticSiteUserProvidedFunctionApp>();
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteBuildARMResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="buildId"> An identifier for the static site build. </param>
        /// <param name="sourceBranch"> The source branch. </param>
        /// <param name="pullRequestTitle"> The title of a pull request that a static site build is related to. </param>
        /// <param name="hostname"> The hostname for a static site build. </param>
        /// <param name="createdTimeUtc"> When this build was created. </param>
        /// <param name="lastUpdatedOn"> When this build was updated. </param>
        /// <param name="status"> The status of the static site build. </param>
        /// <param name="userProvidedFunctionApps"> User provided function apps registered with the static site build. </param>
        internal StaticSiteBuildARMResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string buildId, string sourceBranch, string pullRequestTitle, string hostname, DateTimeOffset? createdTimeUtc, DateTimeOffset? lastUpdatedOn, BuildStatus? status, IReadOnlyList<StaticSiteUserProvidedFunctionApp> userProvidedFunctionApps) : base(id, name, resourceType, systemData, kind)
        {
            BuildId = buildId;
            SourceBranch = sourceBranch;
            PullRequestTitle = pullRequestTitle;
            Hostname = hostname;
            CreatedTimeUtc = createdTimeUtc;
            LastUpdatedOn = lastUpdatedOn;
            Status = status;
            UserProvidedFunctionApps = userProvidedFunctionApps;
        }

        /// <summary> An identifier for the static site build. </summary>
        public string BuildId { get; }
        /// <summary> The source branch. </summary>
        public string SourceBranch { get; }
        /// <summary> The title of a pull request that a static site build is related to. </summary>
        public string PullRequestTitle { get; }
        /// <summary> The hostname for a static site build. </summary>
        public string Hostname { get; }
        /// <summary> When this build was created. </summary>
        public DateTimeOffset? CreatedTimeUtc { get; }
        /// <summary> When this build was updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The status of the static site build. </summary>
        public BuildStatus? Status { get; }
        /// <summary> User provided function apps registered with the static site build. </summary>
        public IReadOnlyList<StaticSiteUserProvidedFunctionApp> UserProvidedFunctionApps { get; }
    }
}
