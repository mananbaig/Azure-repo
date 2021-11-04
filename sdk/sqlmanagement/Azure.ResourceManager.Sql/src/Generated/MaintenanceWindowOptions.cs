// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace SqlManagementClient
{
    /// <summary> A Class representing a MaintenanceWindowOptions along with the instance operations that can be performed on it. </summary>
    public partial class MaintenanceWindowOptions : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly MaintenanceWindowOptionsRestOperations _maintenanceWindowOptionsRestClient;
        private readonly MaintenanceWindowOptionsData _data;

        /// <summary> Initializes a new instance of the <see cref="MaintenanceWindowOptions"/> class for mocking. </summary>
        protected MaintenanceWindowOptions()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MaintenanceWindowOptions"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal MaintenanceWindowOptions(ArmResource options, MaintenanceWindowOptionsData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _maintenanceWindowOptionsRestClient = new MaintenanceWindowOptionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="MaintenanceWindowOptions"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MaintenanceWindowOptions(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _maintenanceWindowOptionsRestClient = new MaintenanceWindowOptionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="MaintenanceWindowOptions"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MaintenanceWindowOptions(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _maintenanceWindowOptionsRestClient = new MaintenanceWindowOptionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/maintenanceWindowOptions";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MaintenanceWindowOptionsData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindowOptions/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindowOptions/current
        /// OperationId: MaintenanceWindowOptions_Get
        /// <summary> Gets a list of available maintenance windows. </summary>
        /// <param name="maintenanceWindowOptionsName"> Maintenance window options name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowOptionsName"/> is null. </exception>
        public async virtual Task<Response<MaintenanceWindowOptions>> GetAsync(string maintenanceWindowOptionsName, CancellationToken cancellationToken = default)
        {
            if (maintenanceWindowOptionsName == null)
            {
                throw new ArgumentNullException(nameof(maintenanceWindowOptionsName));
            }

            using var scope = _clientDiagnostics.CreateScope("MaintenanceWindowOptions.Get");
            scope.Start();
            try
            {
                var response = await _maintenanceWindowOptionsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowOptionsName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MaintenanceWindowOptions(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindowOptions/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/maintenanceWindowOptions/current
        /// OperationId: MaintenanceWindowOptions_Get
        /// <summary> Gets a list of available maintenance windows. </summary>
        /// <param name="maintenanceWindowOptionsName"> Maintenance window options name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowOptionsName"/> is null. </exception>
        public virtual Response<MaintenanceWindowOptions> Get(string maintenanceWindowOptionsName, CancellationToken cancellationToken = default)
        {
            if (maintenanceWindowOptionsName == null)
            {
                throw new ArgumentNullException(nameof(maintenanceWindowOptionsName));
            }

            using var scope = _clientDiagnostics.CreateScope("MaintenanceWindowOptions.Get");
            scope.Start();
            try
            {
                var response = _maintenanceWindowOptionsRestClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowOptionsName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MaintenanceWindowOptions(this, response.Value), response.GetRawResponse());
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
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }
    }
}
