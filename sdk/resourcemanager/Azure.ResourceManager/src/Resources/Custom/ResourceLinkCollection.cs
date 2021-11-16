// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Core;

[assembly:CodeGenSuppressType("Azure.ResourceManager.Resources.Models.CreatedByType")]

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of ResourceLink and their operations over a Tenant. </summary>
    [CodeGenType("ResourceLinkCollection")]
    [CodeGenSuppress("GetAll", new Type[] {typeof(CancellationToken)})]
    [CodeGenSuppress("GetAllAsync", new Type[] {typeof(CancellationToken)})]
    [CodeGenSuppress("ValidateResourceType", new Type[] {typeof(ResourceIdentifier)})]
    public partial class ResourceLinkCollection : ArmCollection
    {
        /// <summary> Gets a list of resource links at and below the specified source scope. </summary>
        /// <param name="linkScope"> The scope of the resource link.</param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceLink> GetAll(ResourceIdentifier linkScope = default, CancellationToken cancellationToken = default)
        {
            Page<ResourceLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAtSourceScope(linkScope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAtSourceScopeNextPage(nextLink, linkScope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of resource links at and below the specified source scope. </summary>
        /// <param name="linkScope"> The scope of the resource link.</param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceLink> GetAllAsync(ResourceIdentifier linkScope = default, CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAtSourceScopeAsync(linkScope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAtSourceScopeNextPageAsync(nextLink, linkScope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
