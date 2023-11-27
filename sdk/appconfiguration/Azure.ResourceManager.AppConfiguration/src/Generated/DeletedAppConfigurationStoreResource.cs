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

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A Class representing a DeletedAppConfigurationStore along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DeletedAppConfigurationStoreResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDeletedAppConfigurationStoreResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetDeletedAppConfigurationStore method.
    /// </summary>
    public partial class DeletedAppConfigurationStoreResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeletedAppConfigurationStoreResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="configStoreName"> The configStoreName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string configStoreName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _deletedAppConfigurationStoreConfigurationStoresRestClient;
        private readonly DeletedAppConfigurationStoreData _data;

        /// <summary> Initializes a new instance of the <see cref="DeletedAppConfigurationStoreResource"/> class for mocking. </summary>
        protected DeletedAppConfigurationStoreResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedAppConfigurationStoreResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeletedAppConfigurationStoreResource(ArmClient client, DeletedAppConfigurationStoreData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedAppConfigurationStoreResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeletedAppConfigurationStoreResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deletedAppConfigurationStoreConfigurationStoresApiVersion);
            _deletedAppConfigurationStoreConfigurationStoresRestClient = new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedAppConfigurationStoreConfigurationStoresApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppConfiguration/locations/deletedConfigurationStores";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeletedAppConfigurationStoreData Data
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

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedAppConfigurationStoreResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreResource.Get");
            scope.Start();
            try
            {
                var response = await _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedAppConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_GetDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedAppConfigurationStoreResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreResource.Get");
            scope.Start();
            try
            {
                var response = _deletedAppConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedAppConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently deletes the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}/purge</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_PurgeDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> PurgeDeletedAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreResource.PurgeDeleted");
            scope.Start();
            try
            {
                var response = await _deletedAppConfigurationStoreConfigurationStoresRestClient.PurgeDeletedAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation(_deletedAppConfigurationStoreConfigurationStoresClientDiagnostics, Pipeline, _deletedAppConfigurationStoreConfigurationStoresRestClient.CreatePurgeDeletedRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Permanently deletes the specified configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}/purge</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationStores_PurgeDeleted</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation PurgeDeleted(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _deletedAppConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedAppConfigurationStoreResource.PurgeDeleted");
            scope.Start();
            try
            {
                var response = _deletedAppConfigurationStoreConfigurationStoresRestClient.PurgeDeleted(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                var operation = new AppConfigurationArmOperation(_deletedAppConfigurationStoreConfigurationStoresClientDiagnostics, Pipeline, _deletedAppConfigurationStoreConfigurationStoresRestClient.CreatePurgeDeletedRequest(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
