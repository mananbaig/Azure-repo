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

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary>
    /// A Class representing a DynatraceSingleSignOn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DynatraceSingleSignOnResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDynatraceSingleSignOnResource method.
    /// Otherwise you can get one from its parent resource <see cref="DynatraceMonitorResource" /> using the GetDynatraceSingleSignOn method.
    /// </summary>
    public partial class DynatraceSingleSignOnResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DynatraceSingleSignOnResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string monitorName, string configurationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dynatraceSingleSignOnSingleSignOnClientDiagnostics;
        private readonly SingleSignOnRestOperations _dynatraceSingleSignOnSingleSignOnRestClient;
        private readonly DynatraceSingleSignOnData _data;

        /// <summary> Initializes a new instance of the <see cref="DynatraceSingleSignOnResource"/> class for mocking. </summary>
        protected DynatraceSingleSignOnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DynatraceSingleSignOnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DynatraceSingleSignOnResource(ArmClient client, DynatraceSingleSignOnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DynatraceSingleSignOnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DynatraceSingleSignOnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dynatraceSingleSignOnSingleSignOnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Dynatrace", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dynatraceSingleSignOnSingleSignOnApiVersion);
            _dynatraceSingleSignOnSingleSignOnRestClient = new SingleSignOnRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dynatraceSingleSignOnSingleSignOnApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Dynatrace.Observability/monitors/singleSignOnConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DynatraceSingleSignOnData Data
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
        /// Get a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DynatraceSingleSignOnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Get");
            scope.Start();
            try
            {
                var response = await _dynatraceSingleSignOnSingleSignOnRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DynatraceSingleSignOnResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Get");
            scope.Start();
            try
            {
                var response = _dynatraceSingleSignOnSingleSignOnRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DynatraceSingleSignOnResource>> UpdateAsync(WaitUntil waitUntil, DynatraceSingleSignOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Update");
            scope.Start();
            try
            {
                var response = await _dynatraceSingleSignOnSingleSignOnRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DynatraceArmOperation<DynatraceSingleSignOnResource>(new DynatraceSingleSignOnOperationSource(Client), _dynatraceSingleSignOnSingleSignOnClientDiagnostics, Pipeline, _dynatraceSingleSignOnSingleSignOnRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a DynatraceSingleSignOnResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOn_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DynatraceSingleSignOnResource> Update(WaitUntil waitUntil, DynatraceSingleSignOnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceSingleSignOnSingleSignOnClientDiagnostics.CreateScope("DynatraceSingleSignOnResource.Update");
            scope.Start();
            try
            {
                var response = _dynatraceSingleSignOnSingleSignOnRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new DynatraceArmOperation<DynatraceSingleSignOnResource>(new DynatraceSingleSignOnOperationSource(Client), _dynatraceSingleSignOnSingleSignOnClientDiagnostics, Pipeline, _dynatraceSingleSignOnSingleSignOnRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
