// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a CloudServiceRole along with the instance operations that can be performed on it. </summary>
    public partial class CloudServiceRole : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CloudServiceRole"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string cloudServiceName, string roleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roles/{roleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cloudServiceRoleClientDiagnostics;
        private readonly CloudServiceRolesRestOperations _cloudServiceRoleRestClient;
        private readonly CloudServiceRoleData _data;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRole"/> class for mocking. </summary>
        protected CloudServiceRole()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CloudServiceRole"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CloudServiceRole(ArmClient client, CloudServiceRoleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRole"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CloudServiceRole(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudServiceRoleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string cloudServiceRoleApiVersion);
            _cloudServiceRoleRestClient = new CloudServiceRolesRestOperations(_cloudServiceRoleClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, cloudServiceRoleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/cloudServices/roles";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CloudServiceRoleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a role from a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<CloudServiceRole>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceRoleClientDiagnostics.CreateScope("CloudServiceRole.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _cloudServiceRoleClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CloudServiceRole(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a role from a cloud service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CloudServiceRole> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceRoleClientDiagnostics.CreateScope("CloudServiceRole.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _cloudServiceRoleClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRole(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceRoleClientDiagnostics.CreateScope("CloudServiceRole.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceRoleClientDiagnostics.CreateScope("CloudServiceRole.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
