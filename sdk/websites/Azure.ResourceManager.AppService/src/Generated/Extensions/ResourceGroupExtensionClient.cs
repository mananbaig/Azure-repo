// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> An internal class to add extension methods to. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        private ClientDiagnostics _resourceHealthMetadataClientDiagnostics;
        private ResourceHealthMetadataRestOperations _resourceHealthMetadataRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private WebSiteManagementRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
        }

        private ClientDiagnostics ResourceHealthMetadataClientDiagnostics => _resourceHealthMetadataClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private ResourceHealthMetadataRestOperations ResourceHealthMetadataRestClient => _resourceHealthMetadataRestClient ??= new ResourceHealthMetadataRestOperations(ResourceHealthMetadataClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.AppService", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private WebSiteManagementRestOperations DefaultRestClient => _defaultRestClient ??= new WebSiteManagementRestOperations(DefaultClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            ArmClient.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/resourceHealthMetadata
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourceHealthMetadata_ListByResourceGroup
        /// <summary> Description for List all ResourceHealthMetadata for all sites in the resource group in the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceHealthMetadataData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceHealthMetadataData> GetAllResourceHealthMetadataAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourceHealthMetadataData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = await ResourceHealthMetadataRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceHealthMetadataData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = await ResourceHealthMetadataRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/resourceHealthMetadata
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ResourceHealthMetadata_ListByResourceGroup
        /// <summary> Description for List all ResourceHealthMetadata for all sites in the resource group in the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceHealthMetadataData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceHealthMetadataData> GetAllResourceHealthMetadata(CancellationToken cancellationToken = default)
        {
            Page<ResourceHealthMetadataData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = ResourceHealthMetadataRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourceHealthMetadataData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ResourceHealthMetadataClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAllResourceHealthMetadata");
                scope.Start();
                try
                {
                    var response = ResourceHealthMetadataRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/moveResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Move
        /// <summary> Description for Move resources between resource groups. </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceEnvelope"/> is null. </exception>
        public async virtual Task<Response> MoveAsync(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            if (moveResourceEnvelope == null)
            {
                throw new ArgumentNullException(nameof(moveResourceEnvelope));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Move");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.MoveAsync(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/moveResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Move
        /// <summary> Description for Move resources between resource groups. </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceEnvelope"/> is null. </exception>
        public virtual Response Move(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            if (moveResourceEnvelope == null)
            {
                throw new ArgumentNullException(nameof(moveResourceEnvelope));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Move");
            scope.Start();
            try
            {
                var response = DefaultRestClient.Move(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/validate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Validate
        /// <summary> Description for Validate if a resource can be created. </summary>
        /// <param name="validateRequest"> Request with the resources to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateRequest"/> is null. </exception>
        public async virtual Task<Response<ValidateResponse>> ValidateAsync(ValidateRequest validateRequest, CancellationToken cancellationToken = default)
        {
            if (validateRequest == null)
            {
                throw new ArgumentNullException(nameof(validateRequest));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Validate");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.ValidateAsync(Id.SubscriptionId, Id.ResourceGroupName, validateRequest, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/validate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Validate
        /// <summary> Description for Validate if a resource can be created. </summary>
        /// <param name="validateRequest"> Request with the resources to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateRequest"/> is null. </exception>
        public virtual Response<ValidateResponse> Validate(ValidateRequest validateRequest, CancellationToken cancellationToken = default)
        {
            if (validateRequest == null)
            {
                throw new ArgumentNullException(nameof(validateRequest));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.Validate");
            scope.Start();
            try
            {
                var response = DefaultRestClient.Validate(Id.SubscriptionId, Id.ResourceGroupName, validateRequest, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/validateMoveResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ValidateMove
        /// <summary> Description for Validate whether a resource can be moved. </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceEnvelope"/> is null. </exception>
        public async virtual Task<Response> ValidateMoveAsync(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            if (moveResourceEnvelope == null)
            {
                throw new ArgumentNullException(nameof(moveResourceEnvelope));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.ValidateMove");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.ValidateMoveAsync(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/validateMoveResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ValidateMove
        /// <summary> Description for Validate whether a resource can be moved. </summary>
        /// <param name="moveResourceEnvelope"> Object that represents the resource to move. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="moveResourceEnvelope"/> is null. </exception>
        public virtual Response ValidateMove(CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default)
        {
            if (moveResourceEnvelope == null)
            {
                throw new ArgumentNullException(nameof(moveResourceEnvelope));
            }

            using var scope = DefaultClientDiagnostics.CreateScope("ResourceGroupExtensionClient.ValidateMove");
            scope.Start();
            try
            {
                var response = DefaultRestClient.ValidateMove(Id.SubscriptionId, Id.ResourceGroupName, moveResourceEnvelope, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
