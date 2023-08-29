// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="DataCollectionRuleAssociationResource" /> and their operations.
    /// Each <see cref="DataCollectionRuleAssociationResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="DataCollectionRuleAssociationCollection" /> instance call the GetDataCollectionRuleAssociations method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class DataCollectionRuleAssociationCollection : ArmCollection, IEnumerable<DataCollectionRuleAssociationResource>, IAsyncEnumerable<DataCollectionRuleAssociationResource>
    {
        private readonly ClientDiagnostics _dataCollectionRuleAssociationClientDiagnostics;
        private readonly DataCollectionRuleAssociationsRestOperations _dataCollectionRuleAssociationRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociationCollection"/> class for mocking. </summary>
        protected DataCollectionRuleAssociationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataCollectionRuleAssociationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCollectionRuleAssociationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DataCollectionRuleAssociationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataCollectionRuleAssociationResource.ResourceType, out string dataCollectionRuleAssociationApiVersion);
            _dataCollectionRuleAssociationRestClient = new DataCollectionRuleAssociationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataCollectionRuleAssociationApiVersion);
        }

        /// <summary>
        /// Creates or updates an association.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataCollectionRuleAssociationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string associationName, DataCollectionRuleAssociationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.CreateAsync(Id, associationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<DataCollectionRuleAssociationResource>(Response.FromValue(new DataCollectionRuleAssociationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an association.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataCollectionRuleAssociationResource> CreateOrUpdate(WaitUntil waitUntil, string associationName, DataCollectionRuleAssociationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Create(Id, associationName, data, cancellationToken);
                var operation = new MonitorArmOperation<DataCollectionRuleAssociationResource>(Response.FromValue(new DataCollectionRuleAssociationResource(Client, response), response.GetRawResponse()));
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
        /// Returns the specified association.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual async Task<Response<DataCollectionRuleAssociationResource>> GetAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.GetAsync(Id, associationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleAssociationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the specified association.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual Response<DataCollectionRuleAssociationResource> Get(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Get(Id, associationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleAssociationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists associations for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_ListByResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataCollectionRuleAssociationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataCollectionRuleAssociationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataCollectionRuleAssociationRestClient.CreateListByResourceRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataCollectionRuleAssociationRestClient.CreateListByResourceNextPageRequest(nextLink, Id);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DataCollectionRuleAssociationResource(Client, DataCollectionRuleAssociationData.DeserializeDataCollectionRuleAssociationData(e)), _dataCollectionRuleAssociationClientDiagnostics, Pipeline, "DataCollectionRuleAssociationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists associations for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_ListByResource</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataCollectionRuleAssociationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataCollectionRuleAssociationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataCollectionRuleAssociationRestClient.CreateListByResourceRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataCollectionRuleAssociationRestClient.CreateListByResourceNextPageRequest(nextLink, Id);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DataCollectionRuleAssociationResource(Client, DataCollectionRuleAssociationData.DeserializeDataCollectionRuleAssociationData(e)), _dataCollectionRuleAssociationClientDiagnostics, Pipeline, "DataCollectionRuleAssociationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.GetAsync(Id, associationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionRuleAssociations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="associationName"> The name of the association. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="associationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="associationName"/> is null. </exception>
        public virtual Response<bool> Exists(string associationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(associationName, nameof(associationName));

            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Get(Id, associationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataCollectionRuleAssociationResource> IEnumerable<DataCollectionRuleAssociationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataCollectionRuleAssociationResource> IAsyncEnumerable<DataCollectionRuleAssociationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
