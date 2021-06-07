// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OperationalInsightsManagementClient.Models
{
    /// <summary> The top level Workspace resource container. </summary>
    public partial class Workspace : TrackedResource
    {
        /// <summary> Initializes a new instance of Workspace. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Workspace(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            PrivateLinkScopedResources = new ChangeTrackingList<PrivateLinkScopedResource>();
        }

        /// <summary> Initializes a new instance of Workspace. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="eTag"> The ETag of the workspace. </param>
        /// <param name="provisioningState"> The provisioning state of the workspace. </param>
        /// <param name="customerId"> This is a read-only property. Represents the ID associated with the workspace. </param>
        /// <param name="sku"> The SKU of the workspace. </param>
        /// <param name="retentionInDays"> The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details. </param>
        /// <param name="workspaceCapping"> The daily volume cap for ingestion. </param>
        /// <param name="createdDate"> Workspace creation date. </param>
        /// <param name="modifiedDate"> Workspace modification date. </param>
        /// <param name="publicNetworkAccessForIngestion"> The network access type for accessing Log Analytics ingestion. </param>
        /// <param name="publicNetworkAccessForQuery"> The network access type for accessing Log Analytics query. </param>
        /// <param name="forceCmkForQuery"> Indicates whether customer managed storage is mandatory for query management. </param>
        /// <param name="privateLinkScopedResources"> List of linked private link scope resources. </param>
        /// <param name="enableDataExport"> Flag that indicate if data should be exported. </param>
        /// <param name="immediatePurgeDataOn30Days"> Flag that describes if we want to remove the data after 30 days. </param>
        /// <param name="enableLogAccessUsingOnlyResourcePermissions"> Flag that indicate which permission to use - resource or workspace or both. </param>
        /// <param name="clusterResourceId"> Dedicated LA cluster resourceId that is linked to the workspaces. </param>
        internal Workspace(string id, string name, string type, IDictionary<string, string> tags, string location, string eTag, WorkspaceEntityStatus? provisioningState, string customerId, WorkspaceSku sku, int? retentionInDays, WorkspaceCapping workspaceCapping, string createdDate, string modifiedDate, PublicNetworkAccessType? publicNetworkAccessForIngestion, PublicNetworkAccessType? publicNetworkAccessForQuery, bool? forceCmkForQuery, IReadOnlyList<PrivateLinkScopedResource> privateLinkScopedResources, bool? enableDataExport, bool? immediatePurgeDataOn30Days, bool? enableLogAccessUsingOnlyResourcePermissions, string clusterResourceId) : base(id, name, type, tags, location)
        {
            ETag = eTag;
            ProvisioningState = provisioningState;
            CustomerId = customerId;
            Sku = sku;
            RetentionInDays = retentionInDays;
            WorkspaceCapping = workspaceCapping;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
            PublicNetworkAccessForIngestion = publicNetworkAccessForIngestion;
            PublicNetworkAccessForQuery = publicNetworkAccessForQuery;
            ForceCmkForQuery = forceCmkForQuery;
            PrivateLinkScopedResources = privateLinkScopedResources;
            EnableDataExport = enableDataExport;
            ImmediatePurgeDataOn30Days = immediatePurgeDataOn30Days;
            EnableLogAccessUsingOnlyResourcePermissions = enableLogAccessUsingOnlyResourcePermissions;
            ClusterResourceId = clusterResourceId;
        }

        /// <summary> The ETag of the workspace. </summary>
        public string ETag { get; set; }
        /// <summary> The provisioning state of the workspace. </summary>
        public WorkspaceEntityStatus? ProvisioningState { get; set; }
        /// <summary> This is a read-only property. Represents the ID associated with the workspace. </summary>
        public string CustomerId { get; }
        /// <summary> The SKU of the workspace. </summary>
        public WorkspaceSku Sku { get; set; }
        /// <summary> The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers documentation for details. </summary>
        public int? RetentionInDays { get; set; }
        /// <summary> The daily volume cap for ingestion. </summary>
        public WorkspaceCapping WorkspaceCapping { get; set; }
        /// <summary> Workspace creation date. </summary>
        public string CreatedDate { get; }
        /// <summary> Workspace modification date. </summary>
        public string ModifiedDate { get; }
        /// <summary> The network access type for accessing Log Analytics ingestion. </summary>
        public PublicNetworkAccessType? PublicNetworkAccessForIngestion { get; set; }
        /// <summary> The network access type for accessing Log Analytics query. </summary>
        public PublicNetworkAccessType? PublicNetworkAccessForQuery { get; set; }
        /// <summary> Indicates whether customer managed storage is mandatory for query management. </summary>
        public bool? ForceCmkForQuery { get; set; }
        /// <summary> List of linked private link scope resources. </summary>
        public IReadOnlyList<PrivateLinkScopedResource> PrivateLinkScopedResources { get; }
        /// <summary> Flag that indicate if data should be exported. </summary>
        public bool? EnableDataExport { get; set; }
        /// <summary> Flag that describes if we want to remove the data after 30 days. </summary>
        public bool? ImmediatePurgeDataOn30Days { get; set; }
        /// <summary> Flag that indicate which permission to use - resource or workspace or both. </summary>
        public bool? EnableLogAccessUsingOnlyResourcePermissions { get; set; }
        /// <summary> Dedicated LA cluster resourceId that is linked to the workspaces. </summary>
        public string ClusterResourceId { get; set; }
    }
}
