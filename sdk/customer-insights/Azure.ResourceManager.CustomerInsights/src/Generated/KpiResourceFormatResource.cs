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

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A Class representing a KpiResourceFormat along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="KpiResourceFormatResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetKpiResourceFormatResource method.
    /// Otherwise you can get one from its parent resource <see cref="HubResource"/> using the GetKpiResourceFormat method.
    /// </summary>
    public partial class KpiResourceFormatResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="KpiResourceFormatResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="hubName"> The hubName. </param>
        /// <param name="kpiName"> The kpiName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hubName, string kpiName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _kpiResourceFormatKpiClientDiagnostics;
        private readonly KpiRestOperations _kpiResourceFormatKpiRestClient;
        private readonly KpiResourceFormatData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CustomerInsights/hubs/kpi";

        /// <summary> Initializes a new instance of the <see cref="KpiResourceFormatResource"/> class for mocking. </summary>
        protected KpiResourceFormatResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KpiResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal KpiResourceFormatResource(ArmClient client, KpiResourceFormatData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="KpiResourceFormatResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal KpiResourceFormatResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kpiResourceFormatKpiClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CustomerInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string kpiResourceFormatKpiApiVersion);
            _kpiResourceFormatKpiRestClient = new KpiRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kpiResourceFormatKpiApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual KpiResourceFormatData Data
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
        /// Gets a KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KpiResourceFormatResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KpiResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KpiResourceFormatResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Get");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KpiResourceFormatResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation(_kpiResourceFormatKpiClientDiagnostics, Pipeline, _kpiResourceFormatKpiRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Delete");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CustomerInsightsArmOperation(_kpiResourceFormatKpiClientDiagnostics, Pipeline, _kpiResourceFormatKpiRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a KPI or updates an existing KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create/update KPI operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KpiResourceFormatResource>> UpdateAsync(WaitUntil waitUntil, KpiResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CustomerInsightsArmOperation<KpiResourceFormatResource>(new KpiResourceFormatOperationSource(Client), _kpiResourceFormatKpiClientDiagnostics, Pipeline, _kpiResourceFormatKpiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a KPI or updates an existing KPI in the hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the create/update KPI operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KpiResourceFormatResource> Update(WaitUntil waitUntil, KpiResourceFormatData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Update");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CustomerInsightsArmOperation<KpiResourceFormatResource>(new KpiResourceFormatOperationSource(Client), _kpiResourceFormatKpiClientDiagnostics, Pipeline, _kpiResourceFormatKpiRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Reprocesses the Kpi values of the specified KPI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}/reprocess</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Reprocess</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ReprocessAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Reprocess");
            scope.Start();
            try
            {
                var response = await _kpiResourceFormatKpiRestClient.ReprocessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reprocesses the Kpi values of the specified KPI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CustomerInsights/hubs/{hubName}/kpi/{kpiName}/reprocess</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Kpi_Reprocess</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Reprocess(CancellationToken cancellationToken = default)
        {
            using var scope = _kpiResourceFormatKpiClientDiagnostics.CreateScope("KpiResourceFormatResource.Reprocess");
            scope.Start();
            try
            {
                var response = _kpiResourceFormatKpiRestClient.Reprocess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
