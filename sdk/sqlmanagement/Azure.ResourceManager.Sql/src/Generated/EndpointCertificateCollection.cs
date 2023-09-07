// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="EndpointCertificateResource" /> and their operations.
    /// Each <see cref="EndpointCertificateResource" /> in the collection will belong to the same instance of <see cref="ManagedInstanceResource" />.
    /// To get an <see cref="EndpointCertificateCollection" /> instance call the GetEndpointCertificates method from an instance of <see cref="ManagedInstanceResource" />.
    /// </summary>
    public partial class EndpointCertificateCollection : ArmCollection, IEnumerable<EndpointCertificateResource>, IAsyncEnumerable<EndpointCertificateResource>
    {
        private readonly ClientDiagnostics _endpointCertificateClientDiagnostics;
        private readonly EndpointCertificatesRestOperations _endpointCertificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="EndpointCertificateCollection"/> class for mocking. </summary>
        protected EndpointCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EndpointCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EndpointCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _endpointCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", EndpointCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EndpointCertificateResource.ResourceType, out string endpointCertificateApiVersion);
            _endpointCertificateRestClient = new EndpointCertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, endpointCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a certificate used on the endpoint with the given id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/endpointCertificates/{endpointType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointType"> Type of the endpoint whose certificate the customer is looking for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointType"/> is null. </exception>
        public virtual async Task<Response<EndpointCertificateResource>> GetAsync(string endpointType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointType, nameof(endpointType));

            using var scope = _endpointCertificateClientDiagnostics.CreateScope("EndpointCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _endpointCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointType, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a certificate used on the endpoint with the given id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/endpointCertificates/{endpointType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointType"> Type of the endpoint whose certificate the customer is looking for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointType"/> is null. </exception>
        public virtual Response<EndpointCertificateResource> Get(string endpointType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointType, nameof(endpointType));

            using var scope = _endpointCertificateClientDiagnostics.CreateScope("EndpointCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _endpointCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointType, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List certificates used on endpoints on the target instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/endpointCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointCertificates_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EndpointCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EndpointCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _endpointCertificateRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _endpointCertificateRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new EndpointCertificateResource(Client, EndpointCertificateData.DeserializeEndpointCertificateData(e)), _endpointCertificateClientDiagnostics, Pipeline, "EndpointCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List certificates used on endpoints on the target instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/endpointCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointCertificates_ListByInstance</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EndpointCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EndpointCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _endpointCertificateRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _endpointCertificateRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new EndpointCertificateResource(Client, EndpointCertificateData.DeserializeEndpointCertificateData(e)), _endpointCertificateClientDiagnostics, Pipeline, "EndpointCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/endpointCertificates/{endpointType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointType"> Type of the endpoint whose certificate the customer is looking for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointType"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointType, nameof(endpointType));

            using var scope = _endpointCertificateClientDiagnostics.CreateScope("EndpointCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _endpointCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointType, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/endpointCertificates/{endpointType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EndpointCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointType"> Type of the endpoint whose certificate the customer is looking for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointType"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointType"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointType, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointType, nameof(endpointType));

            using var scope = _endpointCertificateClientDiagnostics.CreateScope("EndpointCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _endpointCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointType, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EndpointCertificateResource> IEnumerable<EndpointCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EndpointCertificateResource> IAsyncEnumerable<EndpointCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
