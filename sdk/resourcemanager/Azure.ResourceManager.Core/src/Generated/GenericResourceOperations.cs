﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.ResourceManager.Core
{
    /// <summary>
    /// A class representing the operations that can be performed over a specific ArmResource.
    /// </summary>
    public class GenericResourceOperations : ResourceOperationsBase<TenantResourceIdentifier, GenericResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResourceOperations"/> class.
        /// </summary>
        /// <param name="operations"> The resource operations to copy the options from. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GenericResourceOperations(ResourceOperationsBase operations, TenantResourceIdentifier id)
            : base(operations, id)
        {
        }

        /// <inheritdoc/>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        private ResourcesRestOperations RestClient
        {
            get
            {
                string subscription;
                if (!Id.TryGetSubscriptionId(out subscription))
                {
                    subscription = Guid.Empty.ToString();
                }

                return new ResourcesRestOperations(
                    Diagnostics,
                    Pipeline,
                    subscription,
                    BaseUri);
            }
        }

        /// <summary>
        /// Delete the resource.
        /// </summary>
        /// <param name="cancellationToken"> A token allowing immediate cancellation of any blocking call performed during the deletion. </param>
        /// <returns> The status of the delete operation. </returns>
        public ArmResponse Delete(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return ArmResponse.FromResponse(operation.WaitForCompletion(cancellationToken).GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the resource.
        /// </summary>
        /// <param name="cancellationToken"> A token allowing immediate cancellation of any blocking call performed during the deletion. </param>
        /// <returns> A <see cref="Task"/> that on completion returns the status of the delete operation. </returns>
        public async Task<ArmResponse> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return ArmResponse.FromResponse((await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false)).GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the resource.
        /// </summary>
        /// <param name="cancellationToken"> A token allowing immediate cancellation of any blocking call performed during the deletion. </param>
        /// <returns> A <see cref="ArmOperation{Response}"/> which allows the caller to control polling and waiting for resource deletion.
        /// The operation yields the final http response to the delete request when complete. </returns>
        /// <remarks>
        /// <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>
        /// </remarks>
        public ResourcesDeleteByIdOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var apiVersion = GetApiVersion(cancellationToken);
                var originalResponse = RestClient.DeleteById(Id, apiVersion, cancellationToken);
                return new ResourcesDeleteByIdOperation(Diagnostics, Pipeline, RestClient.CreateDeleteByIdRequest(Id, apiVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the resource.  This call returns a Task that blocks until the delete operation is accepted on the service.
        /// </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service.
        /// The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A <see cref="Task"/> that on completion returns a <see cref="ArmOperation{Response}"/> which
        /// allows the caller to control polling and waiting for resource deletion.
        /// The operation yields the final http response to the delete request when complete. </returns>
        /// <remarks>
        /// <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>
        /// </remarks>
        public async Task<ResourcesDeleteByIdOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var apiVersion = await GetApiVersionAsync(cancellationToken).ConfigureAwait(false);
                var originalResponse = await RestClient.DeleteByIdAsync(Id, apiVersion, cancellationToken).ConfigureAwait(false);
                return new ResourcesDeleteByIdOperation(Diagnostics, Pipeline, RestClient.CreateDeleteByIdRequest(Id, apiVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public ArmResponse<GenericResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.AddTag");
            scope.Start();
            try
            {
                var operation = StartAddTag(key, value, cancellationToken);
                return operation.WaitForCompletion(cancellationToken) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<ArmResponse<GenericResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.AddTag");
            scope.Start();
            try
            {
                var operation = await StartAddTagAsync(key, value, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public ResourcesUpdateByIdOperation StartAddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartAddTag");
            scope.Start();
            try
            {
                GenericResource resource = GetResource(cancellationToken);
                resource.Data.Tags[key] = value;
                var apiVersion = GetApiVersion(cancellationToken);
                var originalResponse = RestClient.UpdateById(Id, apiVersion, resource.Data, cancellationToken);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, resource.Data).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<ResourcesUpdateByIdOperation> StartAddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartAddTag");
            scope.Start();
            try
            {
                GenericResource resource = await GetResourceAsync(cancellationToken).ConfigureAwait(false);
                resource.Data.Tags[key] = value;
                var apiVersion = await GetApiVersionAsync(cancellationToken).ConfigureAwait(false);
                var originalResponse = await RestClient.UpdateByIdAsync(Id, apiVersion, resource.Data, cancellationToken).ConfigureAwait(false);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, resource.Data).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public override ArmResponse<GenericResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.Get");
            scope.Start();
            try
            {
                var apiVersion = GetApiVersion(cancellationToken);
                var result = RestClient.GetById(Id, apiVersion, cancellationToken);
                return ArmResponse.FromValue(new GenericResource(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public override async Task<ArmResponse<GenericResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.Get");
            scope.Start();
            try
            {
                var apiVersion = await GetApiVersionAsync(cancellationToken).ConfigureAwait(false);
                var result = await RestClient.GetByIdAsync(Id, apiVersion, cancellationToken).ConfigureAwait(false);
                return ArmResponse.FromValue(new GenericResource(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        protected override void Validate(ResourceIdentifier identifier)
        {
            if (identifier is null)
                throw new ArgumentNullException(nameof(identifier));
        }

        /// <inheritdoc/>
        public ArmResponse<GenericResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.SetTags");
            scope.Start();
            try
            {
                var operation = StartSetTags(tags, cancellationToken);
                return operation.WaitForCompletion(cancellationToken) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<ArmResponse<GenericResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.SetTags");
            scope.Start();
            try
            {
                var operation = await StartSetTagsAsync(tags, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public ResourcesUpdateByIdOperation StartSetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartSetTags");
            scope.Start();
            try
            {
                GenericResource resource = GetResource(cancellationToken);
                resource.Data.Tags.ReplaceWith(tags);
                var apiVersion = GetApiVersion(cancellationToken);
                var originalResponse = RestClient.UpdateById(Id, apiVersion, resource.Data, cancellationToken);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, resource.Data).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<ResourcesUpdateByIdOperation> StartSetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartSetTags");
            scope.Start();
            try
            {
                GenericResource resource = await GetResourceAsync(cancellationToken).ConfigureAwait(false);
                resource.Data.Tags.ReplaceWith(tags);
                var apiVersion = await GetApiVersionAsync(cancellationToken).ConfigureAwait(false);
                var originalResponse = await RestClient.UpdateByIdAsync(Id, apiVersion, resource.Data, cancellationToken).ConfigureAwait(false);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, resource.Data).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public ArmResponse<GenericResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.RemoveTag");
            scope.Start();
            try
            {
                var operation = StartRemoveTag(key, cancellationToken);
                return operation.WaitForCompletion(cancellationToken) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<ArmResponse<GenericResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.RemoveTag");
            scope.Start();
            try
            {
                var operation = await StartRemoveTagAsync(key, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public ResourcesUpdateByIdOperation StartRemoveTag(string key, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartRemoveTag");
            scope.Start();
            try
            {
                GenericResource resource = GetResource(cancellationToken);
                resource.Data.Tags.Remove(key);
                var apiVersion = GetApiVersion(cancellationToken);
                var originalResponse = RestClient.UpdateById(Id, apiVersion, resource.Data, cancellationToken);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, resource.Data).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<ArmOperation<GenericResource>> StartRemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartRemoveTag");
            scope.Start();
            try
            {
                GenericResource resource = await GetResourceAsync(cancellationToken).ConfigureAwait(false);
                resource.Data.Tags.Remove(key);
                var apiVersion = await GetApiVersionAsync(cancellationToken).ConfigureAwait(false);
                var originalResponse = await RestClient.UpdateByIdAsync(Id, apiVersion, resource.Data, cancellationToken).ConfigureAwait(false);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, resource.Data).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a resource by ID. </summary>
        /// <param name="parameters"> Update resource parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmResponse<GenericResource> Update(GenericResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = Diagnostics.CreateScope("GenericResourceOperations.Update");
            scope.Start();
            try
            {
                var operation = StartUpdate(parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a resource by ID. </summary>
        /// <param name="parameters"> Update resource parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmResponse<GenericResource>> UpdateAsync(GenericResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = Diagnostics.CreateScope("GenericResourceOperations.Update");
            scope.Start();
            try
            {
                var operation = await StartUpdateAsync(parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false) as ArmResponse<GenericResource>;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a resource by ID. </summary>
        /// <param name="parameters"> Update resource parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ResourcesUpdateByIdOperation StartUpdate(GenericResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartUpdate");
            scope.Start();
            try
            {
                var apiVersion = GetApiVersion(cancellationToken);
                var originalResponse = RestClient.UpdateById(Id, apiVersion, parameters, cancellationToken);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a resource by ID. </summary>
        /// <param name="parameters"> Update resource parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ResourcesUpdateByIdOperation> StartUpdateAsync(GenericResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = Diagnostics.CreateScope("GenericResourceOperations.StartUpdate");
            scope.Start();
            try
            {
                var apiVersion = await GetApiVersionAsync(cancellationToken).ConfigureAwait(false);
                var originalResponse = await RestClient.UpdateByIdAsync(Id, apiVersion, parameters, cancellationToken).ConfigureAwait(false);
                return new ResourcesUpdateByIdOperation(this, Diagnostics, Pipeline, RestClient.CreateUpdateByIdRequest(Id, apiVersion, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private string GetApiVersion(CancellationToken cancellationToken)
        {
            string version = ClientOptions.ApiVersions.TryGetApiVersion(Id.ResourceType, cancellationToken);
            if (version is null)
            {
                throw new InvalidOperationException($"An invalid resouce id was given {Id}");
            }
            return version;
        }

        private async Task<string> GetApiVersionAsync(CancellationToken cancellationToken)
        {
            string version = await ClientOptions.ApiVersions.TryGetApiVersionAsync(Id.ResourceType, cancellationToken).ConfigureAwait(false);
            if (version is null)
            {
                throw new InvalidOperationException($"An invalid resouce id was given {Id}");
            }
            return version;
        }
    }
}
