// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A Class representing a RedisCacheAccessPolicyAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RedisCacheAccessPolicyAssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRedisCacheAccessPolicyAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="RedisResource"/> using the GetRedisCacheAccessPolicyAssignment method.
    /// </summary>
    public partial class RedisCacheAccessPolicyAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RedisCacheAccessPolicyAssignmentResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="cacheName"> The cacheName. </param>
        /// <param name="accessPolicyAssignmentName"> The accessPolicyAssignmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string cacheName, string accessPolicyAssignmentName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicyAssignments/{accessPolicyAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics;
        private readonly AccessPolicyAssignmentRestOperations _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient;
        private readonly RedisCacheAccessPolicyAssignmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cache/redis/accessPolicyAssignments";

        /// <summary> Initializes a new instance of the <see cref="RedisCacheAccessPolicyAssignmentResource"/> class for mocking. </summary>
        protected RedisCacheAccessPolicyAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RedisCacheAccessPolicyAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RedisCacheAccessPolicyAssignmentResource(ArmClient client, RedisCacheAccessPolicyAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RedisCacheAccessPolicyAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RedisCacheAccessPolicyAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Redis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string redisCacheAccessPolicyAssignmentAccessPolicyAssignmentApiVersion);
            _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient = new AccessPolicyAssignmentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, redisCacheAccessPolicyAssignmentAccessPolicyAssignmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RedisCacheAccessPolicyAssignmentData Data
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
        /// Gets the list of assignments for an access policy of a redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicyAssignments/{accessPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicyAssignment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RedisCacheAccessPolicyAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics.CreateScope("RedisCacheAccessPolicyAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisCacheAccessPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of assignments for an access policy of a redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicyAssignments/{accessPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicyAssignment_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RedisCacheAccessPolicyAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics.CreateScope("RedisCacheAccessPolicyAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisCacheAccessPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the access policy assignment from a redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicyAssignments/{accessPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicyAssignment_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics.CreateScope("RedisCacheAccessPolicyAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new RedisArmOperation(_redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics, Pipeline, _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the access policy assignment from a redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicyAssignments/{accessPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicyAssignment_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics.CreateScope("RedisCacheAccessPolicyAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new RedisArmOperation(_redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics, Pipeline, _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Adds the access policy assignment to the specified users
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicyAssignments/{accessPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicyAssignment_CreateUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Update Access Policy Assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RedisCacheAccessPolicyAssignmentResource>> UpdateAsync(WaitUntil waitUntil, RedisCacheAccessPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics.CreateScope("RedisCacheAccessPolicyAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.CreateUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new RedisArmOperation<RedisCacheAccessPolicyAssignmentResource>(new RedisCacheAccessPolicyAssignmentOperationSource(Client), _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics, Pipeline, _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Adds the access policy assignment to the specified users
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicyAssignments/{accessPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicyAssignment_CreateUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyAssignmentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the Create Update Access Policy Assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RedisCacheAccessPolicyAssignmentResource> Update(WaitUntil waitUntil, RedisCacheAccessPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics.CreateScope("RedisCacheAccessPolicyAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.CreateUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new RedisArmOperation<RedisCacheAccessPolicyAssignmentResource>(new RedisCacheAccessPolicyAssignmentOperationSource(Client), _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentClientDiagnostics, Pipeline, _redisCacheAccessPolicyAssignmentAccessPolicyAssignmentRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
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
