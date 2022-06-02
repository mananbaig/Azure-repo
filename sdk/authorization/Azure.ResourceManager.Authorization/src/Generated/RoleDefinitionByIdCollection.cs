// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleDefinitionByIdResource" /> and their operations.
    /// Each <see cref="RoleDefinitionByIdResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="RoleDefinitionByIdCollection" /> instance call the GetRoleDefinitionByIds method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class RoleDefinitionByIdCollection : ArmCollection
    {
        private readonly ClientDiagnostics _roleDefinitionByIdRoleDefinitionsClientDiagnostics;
        private readonly RoleDefinitionsRestOperations _roleDefinitionByIdRoleDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleDefinitionByIdCollection"/> class for mocking. </summary>
        protected RoleDefinitionByIdCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleDefinitionByIdCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleDefinitionByIdCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleDefinitionByIdRoleDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleDefinitionByIdResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleDefinitionByIdResource.ResourceType, out string roleDefinitionByIdRoleDefinitionsApiVersion);
            _roleDefinitionByIdRoleDefinitionsRestClient = new RoleDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleDefinitionByIdRoleDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a role definition by ID.
        /// Request Path: /{roleDefinitionId}
        /// Operation Id: RoleDefinitions_GetById
        /// </summary>
        /// <param name="roleDefinitionId"> The fully qualified role definition ID. Use the format, /subscriptions/{guid}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for subscription level role definitions, or /providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for tenant level role definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<RoleDefinitionByIdResource>> GetAsync(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _roleDefinitionByIdRoleDefinitionsClientDiagnostics.CreateScope("RoleDefinitionByIdCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleDefinitionByIdRoleDefinitionsRestClient.GetByIdAsync(roleDefinitionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleDefinitionByIdResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a role definition by ID.
        /// Request Path: /{roleDefinitionId}
        /// Operation Id: RoleDefinitions_GetById
        /// </summary>
        /// <param name="roleDefinitionId"> The fully qualified role definition ID. Use the format, /subscriptions/{guid}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for subscription level role definitions, or /providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for tenant level role definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual Response<RoleDefinitionByIdResource> Get(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _roleDefinitionByIdRoleDefinitionsClientDiagnostics.CreateScope("RoleDefinitionByIdCollection.Get");
            scope.Start();
            try
            {
                var response = _roleDefinitionByIdRoleDefinitionsRestClient.GetById(roleDefinitionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleDefinitionByIdResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{roleDefinitionId}
        /// Operation Id: RoleDefinitions_GetById
        /// </summary>
        /// <param name="roleDefinitionId"> The fully qualified role definition ID. Use the format, /subscriptions/{guid}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for subscription level role definitions, or /providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for tenant level role definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _roleDefinitionByIdRoleDefinitionsClientDiagnostics.CreateScope("RoleDefinitionByIdCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleDefinitionByIdRoleDefinitionsRestClient.GetByIdAsync(roleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /{roleDefinitionId}
        /// Operation Id: RoleDefinitions_GetById
        /// </summary>
        /// <param name="roleDefinitionId"> The fully qualified role definition ID. Use the format, /subscriptions/{guid}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for subscription level role definitions, or /providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for tenant level role definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual Response<bool> Exists(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            using var scope = _roleDefinitionByIdRoleDefinitionsClientDiagnostics.CreateScope("RoleDefinitionByIdCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleDefinitionByIdRoleDefinitionsRestClient.GetById(roleDefinitionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
