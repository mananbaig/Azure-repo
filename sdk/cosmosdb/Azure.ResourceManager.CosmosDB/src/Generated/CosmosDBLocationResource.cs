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

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a CosmosDBLocation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CosmosDBLocationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCosmosDBLocationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetCosmosDBLocation method.
    /// </summary>
    public partial class CosmosDBLocationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBLocationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBLocationLocationsClientDiagnostics;
        private readonly LocationsRestOperations _cosmosDBLocationLocationsRestClient;
        private readonly CosmosDBLocationData _data;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocationResource"/> class for mocking. </summary>
        protected CosmosDBLocationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CosmosDBLocationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBLocationResource(ArmClient client, CosmosDBLocationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBLocationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBLocationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBLocationLocationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosDBLocationLocationsApiVersion);
            _cosmosDBLocationLocationsRestClient = new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBLocationLocationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/locations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBLocationData Data
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

        /// <summary> Gets a collection of RestorableCosmosDBAccountResources in the CosmosDBLocation. </summary>
        /// <returns> An object representing collection of RestorableCosmosDBAccountResources and their operations over a RestorableCosmosDBAccountResource. </returns>
        public virtual RestorableCosmosDBAccountCollection GetRestorableCosmosDBAccounts()
        {
            return GetCachedClient(Client => new RestorableCosmosDBAccountCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RestorableCosmosDBAccountResource>> GetRestorableCosmosDBAccountAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            return await GetRestorableCosmosDBAccounts().GetAsync(instanceId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<RestorableCosmosDBAccountResource> GetRestorableCosmosDBAccount(string instanceId, CancellationToken cancellationToken = default)
        {
            return GetRestorableCosmosDBAccounts().Get(instanceId, cancellationToken);
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBLocationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBLocationLocationsRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}
        /// Operation Id: Locations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBLocationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBLocationLocationsClientDiagnostics.CreateScope("CosmosDBLocationResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBLocationLocationsRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
