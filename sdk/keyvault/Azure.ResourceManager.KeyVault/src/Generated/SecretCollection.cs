// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of Secret and their operations over its parent. </summary>
    public partial class SecretCollection : ArmCollection, IEnumerable<Secret>, IAsyncEnumerable<Secret>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SecretsRestOperations _secretsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecretCollection"/> class for mocking. </summary>
        protected SecretCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecretCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SecretCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Secret.ResourceType, out string apiVersion);
            _secretsRestClient = new SecretsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Vault.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Vault.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// OperationId: Secrets_CreateOrUpdate
        /// <summary> Create or update a secret in a key vault in the specified subscription.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="secretName"> Name of the secret. </param>
        /// <param name="parameters"> Parameters to create or update the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SecretCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string secretName, SecretCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _secretsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, parameters, cancellationToken);
                var operation = new SecretCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// OperationId: Secrets_CreateOrUpdate
        /// <summary> Create or update a secret in a key vault in the specified subscription.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="secretName"> Name of the secret. </param>
        /// <param name="parameters"> Parameters to create or update the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SecretCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string secretName, SecretCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _secretsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SecretCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// OperationId: Secrets_Get
        /// <summary> Gets the specified secret.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<Secret> Get(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.Get");
            scope.Start();
            try
            {
                var response = _secretsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Secret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// OperationId: Secrets_Get
        /// <summary> Gets the specified secret.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<Secret>> GetAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.Get");
            scope.Start();
            try
            {
                var response = await _secretsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Secret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<Secret> GetIfExists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _secretsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Secret>(null, response.GetRawResponse());
                return Response.FromValue(new Secret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<Secret>> GetIfExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _secretsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Secret>(null, response.GetRawResponse());
                return Response.FromValue(new Secret(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<bool> Exists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(secretName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _clientDiagnostics.CreateScope("SecretCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// OperationId: Secrets_List
        /// <summary> The List operation gets information about the secrets in a vault.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Secret" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Secret> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Secret> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _secretsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Secret> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _secretsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// OperationId: Secrets_List
        /// <summary> The List operation gets information about the secrets in a vault.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Secret" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Secret> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Secret>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _secretsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Secret>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SecretCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _secretsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Secret(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Secret> IEnumerable<Secret>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Secret> IAsyncEnumerable<Secret>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Secret, SecretData> Construct() { }
    }
}
