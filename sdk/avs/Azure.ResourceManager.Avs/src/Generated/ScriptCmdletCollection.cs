// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="ScriptCmdletResource" /> and their operations.
    /// Each <see cref="ScriptCmdletResource" /> in the collection will belong to the same instance of <see cref="ScriptPackageResource" />.
    /// To get a <see cref="ScriptCmdletCollection" /> instance call the GetScriptCmdlets method from an instance of <see cref="ScriptPackageResource" />.
    /// </summary>
    public partial class ScriptCmdletCollection : ArmCollection, IEnumerable<ScriptCmdletResource>, IAsyncEnumerable<ScriptCmdletResource>
    {
        private readonly ClientDiagnostics _scriptCmdletClientDiagnostics;
        private readonly ScriptCmdletsRestOperations _scriptCmdletRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScriptCmdletCollection"/> class for mocking. </summary>
        protected ScriptCmdletCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptCmdletCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScriptCmdletCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scriptCmdletClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ScriptCmdletResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScriptCmdletResource.ResourceType, out string scriptCmdletApiVersion);
            _scriptCmdletRestClient = new ScriptCmdletsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scriptCmdletApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ScriptPackageResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ScriptPackageResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Return information about a script cmdlet resource in a specific package on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets/{scriptCmdletName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptCmdletName"/> is null. </exception>
        public virtual async Task<Response<ScriptCmdletResource>> GetAsync(string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptCmdletName, nameof(scriptCmdletName));

            using var scope = _scriptCmdletClientDiagnostics.CreateScope("ScriptCmdletCollection.Get");
            scope.Start();
            try
            {
                var response = await _scriptCmdletRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptCmdletName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptCmdletResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return information about a script cmdlet resource in a specific package on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets/{scriptCmdletName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptCmdletName"/> is null. </exception>
        public virtual Response<ScriptCmdletResource> Get(string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptCmdletName, nameof(scriptCmdletName));

            using var scope = _scriptCmdletClientDiagnostics.CreateScope("ScriptCmdletCollection.Get");
            scope.Start();
            try
            {
                var response = _scriptCmdletRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptCmdletName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptCmdletResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List script cmdlet resources available for a private cloud to create a script execution resource on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScriptCmdletResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScriptCmdletResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scriptCmdletRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scriptCmdletRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ScriptCmdletResource(Client, ScriptCmdletData.DeserializeScriptCmdletData(e)), _scriptCmdletClientDiagnostics, Pipeline, "ScriptCmdletCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List script cmdlet resources available for a private cloud to create a script execution resource on a private cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScriptCmdletResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScriptCmdletResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scriptCmdletRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scriptCmdletRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ScriptCmdletResource(Client, ScriptCmdletData.DeserializeScriptCmdletData(e)), _scriptCmdletClientDiagnostics, Pipeline, "ScriptCmdletCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets/{scriptCmdletName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptCmdletName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptCmdletName, nameof(scriptCmdletName));

            using var scope = _scriptCmdletClientDiagnostics.CreateScope("ScriptCmdletCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scriptCmdletRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptCmdletName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptPackages/{scriptPackageName}/scriptCmdlets/{scriptCmdletName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ScriptCmdlets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scriptCmdletName"/> is null. </exception>
        public virtual Response<bool> Exists(string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scriptCmdletName, nameof(scriptCmdletName));

            using var scope = _scriptCmdletClientDiagnostics.CreateScope("ScriptCmdletCollection.Exists");
            scope.Start();
            try
            {
                var response = _scriptCmdletRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptCmdletName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScriptCmdletResource> IEnumerable<ScriptCmdletResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScriptCmdletResource> IAsyncEnumerable<ScriptCmdletResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
