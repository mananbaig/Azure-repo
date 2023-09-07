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

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A class representing a collection of <see cref="CurrentQuotaLimitBaseResource" /> and their operations.
    /// Each <see cref="CurrentQuotaLimitBaseResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="CurrentQuotaLimitBaseCollection" /> instance call the GetCurrentQuotaLimitBases method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class CurrentQuotaLimitBaseCollection : ArmCollection, IEnumerable<CurrentQuotaLimitBaseResource>, IAsyncEnumerable<CurrentQuotaLimitBaseResource>
    {
        private readonly ClientDiagnostics _currentQuotaLimitBaseQuotaClientDiagnostics;
        private readonly QuotaRestOperations _currentQuotaLimitBaseQuotaRestClient;

        /// <summary> Initializes a new instance of the <see cref="CurrentQuotaLimitBaseCollection"/> class for mocking. </summary>
        protected CurrentQuotaLimitBaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CurrentQuotaLimitBaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CurrentQuotaLimitBaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _currentQuotaLimitBaseQuotaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", CurrentQuotaLimitBaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CurrentQuotaLimitBaseResource.ResourceType, out string currentQuotaLimitBaseQuotaApiVersion);
            _currentQuotaLimitBaseQuotaRestClient = new QuotaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, currentQuotaLimitBaseQuotaApiVersion);
        }

        /// <summary>
        /// Create or update the quota limit for the specified resource with the requested value. To update the quota, follow these steps:
        /// 1. Use the GET operation for quotas and usages to determine how much quota remains for the specific resource and to calculate the new quota limit. These steps are detailed in [this example](https://techcommunity.microsoft.com/t5/azure-governance-and-management/using-the-new-quota-rest-api/ba-p/2183670).
        /// 2. Use this PUT operation to update the quota limit. Please check the URI in location header for the detailed status of the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="data"> Quota request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CurrentQuotaLimitBaseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, CurrentQuotaLimitBaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _currentQuotaLimitBaseQuotaRestClient.CreateOrUpdateAsync(Id, resourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new QuotaArmOperation<CurrentQuotaLimitBaseResource>(new CurrentQuotaLimitBaseOperationSource(Client), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, _currentQuotaLimitBaseQuotaRestClient.CreateCreateOrUpdateRequest(Id, resourceName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Create or update the quota limit for the specified resource with the requested value. To update the quota, follow these steps:
        /// 1. Use the GET operation for quotas and usages to determine how much quota remains for the specific resource and to calculate the new quota limit. These steps are detailed in [this example](https://techcommunity.microsoft.com/t5/azure-governance-and-management/using-the-new-quota-rest-api/ba-p/2183670).
        /// 2. Use this PUT operation to update the quota limit. Please check the URI in location header for the detailed status of the request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="data"> Quota request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CurrentQuotaLimitBaseResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, CurrentQuotaLimitBaseData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _currentQuotaLimitBaseQuotaRestClient.CreateOrUpdate(Id, resourceName, data, cancellationToken);
                var operation = new QuotaArmOperation<CurrentQuotaLimitBaseResource>(new CurrentQuotaLimitBaseOperationSource(Client), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, _currentQuotaLimitBaseQuotaRestClient.CreateCreateOrUpdateRequest(Id, resourceName, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Get the quota limit of a resource. The response can be used to determine the remaining quota to calculate a new quota limit that can be submitted with a PUT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<CurrentQuotaLimitBaseResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _currentQuotaLimitBaseQuotaRestClient.GetAsync(Id, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentQuotaLimitBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the quota limit of a resource. The response can be used to determine the remaining quota to calculate a new quota limit that can be submitted with a PUT request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<CurrentQuotaLimitBaseResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseCollection.Get");
            scope.Start();
            try
            {
                var response = _currentQuotaLimitBaseQuotaRestClient.Get(Id, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CurrentQuotaLimitBaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of current quota limits of all resources for the specified scope. The response from this GET operation can be leveraged to submit requests to update a quota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CurrentQuotaLimitBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CurrentQuotaLimitBaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _currentQuotaLimitBaseQuotaRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _currentQuotaLimitBaseQuotaRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new CurrentQuotaLimitBaseResource(Client, CurrentQuotaLimitBaseData.DeserializeCurrentQuotaLimitBaseData(e)), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, "CurrentQuotaLimitBaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of current quota limits of all resources for the specified scope. The response from this GET operation can be leveraged to submit requests to update a quota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CurrentQuotaLimitBaseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CurrentQuotaLimitBaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _currentQuotaLimitBaseQuotaRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _currentQuotaLimitBaseQuotaRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new CurrentQuotaLimitBaseResource(Client, CurrentQuotaLimitBaseData.DeserializeCurrentQuotaLimitBaseData(e)), _currentQuotaLimitBaseQuotaClientDiagnostics, Pipeline, "CurrentQuotaLimitBaseCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _currentQuotaLimitBaseQuotaRestClient.GetAsync(Id, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Quota/quotas/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName">
        /// Resource name for a given resource provider. For example:
        /// - SKU name for Microsoft.Compute
        /// - SKU or TotalLowPriorityCores for Microsoft.MachineLearningServices
        ///  For Microsoft.Network PublicIPAddresses.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _currentQuotaLimitBaseQuotaClientDiagnostics.CreateScope("CurrentQuotaLimitBaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _currentQuotaLimitBaseQuotaRestClient.Get(Id, resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CurrentQuotaLimitBaseResource> IEnumerable<CurrentQuotaLimitBaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CurrentQuotaLimitBaseResource> IAsyncEnumerable<CurrentQuotaLimitBaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
