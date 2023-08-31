// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class representing a collection of <see cref="ConsumptionBudgetResource" /> and their operations.
    /// Each <see cref="ConsumptionBudgetResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="ConsumptionBudgetCollection" /> instance call the GetConsumptionBudgets method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class ConsumptionBudgetCollection : ArmCollection, IEnumerable<ConsumptionBudgetResource>, IAsyncEnumerable<ConsumptionBudgetResource>
    {
        private readonly ClientDiagnostics _consumptionBudgetBudgetsClientDiagnostics;
        private readonly BudgetsRestOperations _consumptionBudgetBudgetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConsumptionBudgetCollection"/> class for mocking. </summary>
        protected ConsumptionBudgetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConsumptionBudgetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConsumptionBudgetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _consumptionBudgetBudgetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ConsumptionBudgetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConsumptionBudgetResource.ResourceType, out string consumptionBudgetBudgetsApiVersion);
            _consumptionBudgetBudgetsRestClient = new BudgetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, consumptionBudgetBudgetsApiVersion);
        }

        /// <summary>
        /// The operation to create or update a budget. You can optionally provide an eTag if desired as a form of concurrency control. To obtain the latest eTag for a given budget, perform a get operation prior to your put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="budgetName"> Budget Name. </param>
        /// <param name="data"> Parameters supplied to the Create Budget operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="budgetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="budgetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConsumptionBudgetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string budgetName, ConsumptionBudgetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(budgetName, nameof(budgetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _consumptionBudgetBudgetsRestClient.CreateOrUpdateAsync(Id, budgetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConsumptionArmOperation<ConsumptionBudgetResource>(Response.FromValue(new ConsumptionBudgetResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create or update a budget. You can optionally provide an eTag if desired as a form of concurrency control. To obtain the latest eTag for a given budget, perform a get operation prior to your put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="budgetName"> Budget Name. </param>
        /// <param name="data"> Parameters supplied to the Create Budget operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="budgetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="budgetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConsumptionBudgetResource> CreateOrUpdate(WaitUntil waitUntil, string budgetName, ConsumptionBudgetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(budgetName, nameof(budgetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _consumptionBudgetBudgetsRestClient.CreateOrUpdate(Id, budgetName, data, cancellationToken);
                var operation = new ConsumptionArmOperation<ConsumptionBudgetResource>(Response.FromValue(new ConsumptionBudgetResource(Client, response), response.GetRawResponse()));
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
        /// Gets the budget for the scope by budget name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="budgetName"> Budget Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="budgetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="budgetName"/> is null. </exception>
        public virtual async Task<Response<ConsumptionBudgetResource>> GetAsync(string budgetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(budgetName, nameof(budgetName));

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetCollection.Get");
            scope.Start();
            try
            {
                var response = await _consumptionBudgetBudgetsRestClient.GetAsync(Id, budgetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConsumptionBudgetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the budget for the scope by budget name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="budgetName"> Budget Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="budgetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="budgetName"/> is null. </exception>
        public virtual Response<ConsumptionBudgetResource> Get(string budgetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(budgetName, nameof(budgetName));

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetCollection.Get");
            scope.Start();
            try
            {
                var response = _consumptionBudgetBudgetsRestClient.Get(Id, budgetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConsumptionBudgetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all budgets for the defined scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumptionBudgetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumptionBudgetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _consumptionBudgetBudgetsRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _consumptionBudgetBudgetsRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ConsumptionBudgetResource(Client, ConsumptionBudgetData.DeserializeConsumptionBudgetData(e)), _consumptionBudgetBudgetsClientDiagnostics, Pipeline, "ConsumptionBudgetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all budgets for the defined scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumptionBudgetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumptionBudgetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _consumptionBudgetBudgetsRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _consumptionBudgetBudgetsRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ConsumptionBudgetResource(Client, ConsumptionBudgetData.DeserializeConsumptionBudgetData(e)), _consumptionBudgetBudgetsClientDiagnostics, Pipeline, "ConsumptionBudgetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="budgetName"> Budget Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="budgetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="budgetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string budgetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(budgetName, nameof(budgetName));

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _consumptionBudgetBudgetsRestClient.GetAsync(Id, budgetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Consumption/budgets/{budgetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Budgets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="budgetName"> Budget Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="budgetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="budgetName"/> is null. </exception>
        public virtual Response<bool> Exists(string budgetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(budgetName, nameof(budgetName));

            using var scope = _consumptionBudgetBudgetsClientDiagnostics.CreateScope("ConsumptionBudgetCollection.Exists");
            scope.Start();
            try
            {
                var response = _consumptionBudgetBudgetsRestClient.Get(Id, budgetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConsumptionBudgetResource> IEnumerable<ConsumptionBudgetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConsumptionBudgetResource> IAsyncEnumerable<ConsumptionBudgetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
