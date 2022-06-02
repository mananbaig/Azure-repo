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

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _globalAdministratorClientDiagnostics;
        private GlobalAdministratorRestOperations _globalAdministratorRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics GlobalAdministratorClientDiagnostics => _globalAdministratorClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Authorization", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private GlobalAdministratorRestOperations GlobalAdministratorRestClient => _globalAdministratorRestClient ??= new GlobalAdministratorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of RoleDefinitionByIdResources in the TenantResource. </summary>
        /// <returns> An object representing collection of RoleDefinitionByIdResources and their operations over a RoleDefinitionByIdResource. </returns>
        public virtual RoleDefinitionByIdCollection GetRoleDefinitionByIds()
        {
            return GetCachedClient(Client => new RoleDefinitionByIdCollection(Client, Id));
        }

        /// <summary> Gets a collection of ProviderOperationsMetadataResources in the TenantResource. </summary>
        /// <returns> An object representing collection of ProviderOperationsMetadataResources and their operations over a ProviderOperationsMetadataResource. </returns>
        public virtual ProviderOperationsMetadataCollection GetAllProviderOperationsMetadata()
        {
            return GetCachedClient(Client => new ProviderOperationsMetadataCollection(Client, Id));
        }

        /// <summary> Gets a collection of RoleAssignmentByIdResources in the TenantResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentByIdResources and their operations over a RoleAssignmentByIdResource. </returns>
        public virtual RoleAssignmentByIdCollection GetRoleAssignmentByIds()
        {
            return GetCachedClient(Client => new RoleAssignmentByIdCollection(Client, Id));
        }

        /// <summary>
        /// Elevates access for a Global Administrator.
        /// Request Path: /providers/Microsoft.Authorization/elevateAccess
        /// Operation Id: GlobalAdministrator_ElevateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ElevateAccessGlobalAdministratorAsync(CancellationToken cancellationToken = default)
        {
            using var scope = GlobalAdministratorClientDiagnostics.CreateScope("TenantResourceExtensionClient.ElevateAccessGlobalAdministrator");
            scope.Start();
            try
            {
                var response = await GlobalAdministratorRestClient.ElevateAccessAsync(cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Elevates access for a Global Administrator.
        /// Request Path: /providers/Microsoft.Authorization/elevateAccess
        /// Operation Id: GlobalAdministrator_ElevateAccess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ElevateAccessGlobalAdministrator(CancellationToken cancellationToken = default)
        {
            using var scope = GlobalAdministratorClientDiagnostics.CreateScope("TenantResourceExtensionClient.ElevateAccessGlobalAdministrator");
            scope.Start();
            try
            {
                var response = GlobalAdministratorRestClient.ElevateAccess(cancellationToken);
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
