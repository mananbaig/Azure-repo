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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedServerDnsAlias along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagedServerDnsAliasResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagedServerDnsAliasResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedInstanceResource"/> using the GetManagedServerDnsAlias method.
    /// </summary>
    public partial class ManagedServerDnsAliasResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedServerDnsAliasResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="managedInstanceName"> The managedInstanceName. </param>
        /// <param name="dnsAliasName"> The dnsAliasName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string dnsAliasName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedServerDnsAliasClientDiagnostics;
        private readonly ManagedServerDnsAliasesRestOperations _managedServerDnsAliasRestClient;
        private readonly ManagedServerDnsAliasData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedServerDnsAliasResource"/> class for mocking. </summary>
        protected ManagedServerDnsAliasResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServerDnsAliasResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedServerDnsAliasResource(ArmClient client, ManagedServerDnsAliasData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServerDnsAliasResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedServerDnsAliasResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedServerDnsAliasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedServerDnsAliasApiVersion);
            _managedServerDnsAliasRestClient = new ManagedServerDnsAliasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedServerDnsAliasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/dnsAliases";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedServerDnsAliasData Data
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
        /// Gets a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedServerDnsAliasResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Get");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedServerDnsAliasResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Get");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServerDnsAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the managed server DNS alias with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Delete");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation(_managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes the managed server DNS alias with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Delete");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlArmOperation(_managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a managed server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The <see cref="ManagedServerDnsAliasCreateOrUpdateContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedServerDnsAliasResource>> UpdateAsync(WaitUntil waitUntil, ManagedServerDnsAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Update");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedServerDnsAliasResource>(new ManagedServerDnsAliasOperationSource(Client), _managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a managed server DNS alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The <see cref="ManagedServerDnsAliasCreateOrUpdateContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ManagedServerDnsAliasResource> Update(WaitUntil waitUntil, ManagedServerDnsAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Update");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new SqlArmOperation<ManagedServerDnsAliasResource>(new ManagedServerDnsAliasOperationSource(Client), _managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// Acquires managed server DNS alias from another managed server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}/acquire</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Acquire</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedServerDnsAliasAcquisition"> The <see cref="ManagedServerDnsAliasAcquisition"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedServerDnsAliasAcquisition"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedServerDnsAliasResource>> AcquireAsync(WaitUntil waitUntil, ManagedServerDnsAliasAcquisition managedServerDnsAliasAcquisition, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(managedServerDnsAliasAcquisition, nameof(managedServerDnsAliasAcquisition));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Acquire");
            scope.Start();
            try
            {
                var response = await _managedServerDnsAliasRestClient.AcquireAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedServerDnsAliasAcquisition, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedServerDnsAliasResource>(new ManagedServerDnsAliasOperationSource(Client), _managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateAcquireRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedServerDnsAliasAcquisition).Request, response, OperationFinalStateVia.Location);
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
        /// Acquires managed server DNS alias from another managed server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/dnsAliases/{dnsAliasName}/acquire</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedServerDnsAliases_Acquire</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedServerDnsAliasAcquisition"> The <see cref="ManagedServerDnsAliasAcquisition"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedServerDnsAliasAcquisition"/> is null. </exception>
        public virtual ArmOperation<ManagedServerDnsAliasResource> Acquire(WaitUntil waitUntil, ManagedServerDnsAliasAcquisition managedServerDnsAliasAcquisition, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(managedServerDnsAliasAcquisition, nameof(managedServerDnsAliasAcquisition));

            using var scope = _managedServerDnsAliasClientDiagnostics.CreateScope("ManagedServerDnsAliasResource.Acquire");
            scope.Start();
            try
            {
                var response = _managedServerDnsAliasRestClient.Acquire(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedServerDnsAliasAcquisition, cancellationToken);
                var operation = new SqlArmOperation<ManagedServerDnsAliasResource>(new ManagedServerDnsAliasOperationSource(Client), _managedServerDnsAliasClientDiagnostics, Pipeline, _managedServerDnsAliasRestClient.CreateAcquireRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, managedServerDnsAliasAcquisition).Request, response, OperationFinalStateVia.Location);
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
