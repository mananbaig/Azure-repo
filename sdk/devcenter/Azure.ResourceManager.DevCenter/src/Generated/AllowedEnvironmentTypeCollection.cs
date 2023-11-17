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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="AllowedEnvironmentTypeResource" /> and their operations.
    /// Each <see cref="AllowedEnvironmentTypeResource" /> in the collection will belong to the same instance of <see cref="DevCenterProjectResource" />.
    /// To get an <see cref="AllowedEnvironmentTypeCollection" /> instance call the GetAllowedEnvironmentTypes method from an instance of <see cref="DevCenterProjectResource" />.
    /// </summary>
    public partial class AllowedEnvironmentTypeCollection : ArmCollection, IEnumerable<AllowedEnvironmentTypeResource>, IAsyncEnumerable<AllowedEnvironmentTypeResource>
    {
        private readonly ClientDiagnostics _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics;
        private readonly ProjectAllowedEnvironmentTypesRestOperations _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AllowedEnvironmentTypeCollection"/> class for mocking. </summary>
        protected AllowedEnvironmentTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AllowedEnvironmentTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AllowedEnvironmentTypeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", AllowedEnvironmentTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AllowedEnvironmentTypeResource.ResourceType, out string allowedEnvironmentTypeProjectAllowedEnvironmentTypesApiVersion);
            _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient = new ProjectAllowedEnvironmentTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, allowedEnvironmentTypeProjectAllowedEnvironmentTypesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevCenterProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevCenterProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an allowed environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<Response<AllowedEnvironmentTypeResource>> GetAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics.CreateScope("AllowedEnvironmentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AllowedEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an allowed environment type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual Response<AllowedEnvironmentTypeResource> Get(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics.CreateScope("AllowedEnvironmentTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AllowedEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists allowed environment types for a project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AllowedEnvironmentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AllowedEnvironmentTypeResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AllowedEnvironmentTypeResource(Client, AllowedEnvironmentTypeData.DeserializeAllowedEnvironmentTypeData(e)), _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics, Pipeline, "AllowedEnvironmentTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists allowed environment types for a project.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AllowedEnvironmentTypeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AllowedEnvironmentTypeResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AllowedEnvironmentTypeResource(Client, AllowedEnvironmentTypeData.DeserializeAllowedEnvironmentTypeData(e)), _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics, Pipeline, "AllowedEnvironmentTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics.CreateScope("AllowedEnvironmentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics.CreateScope("AllowedEnvironmentTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual async Task<NullableResponse<AllowedEnvironmentTypeResource>> GetIfExistsAsync(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics.CreateScope("AllowedEnvironmentTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AllowedEnvironmentTypeResource>(response.GetRawResponse());
                return Response.FromValue(new AllowedEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/allowedEnvironmentTypes/{environmentTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectAllowedEnvironmentTypes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="environmentTypeName"> The name of the environment type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="environmentTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="environmentTypeName"/> is null. </exception>
        public virtual NullableResponse<AllowedEnvironmentTypeResource> GetIfExists(string environmentTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(environmentTypeName, nameof(environmentTypeName));

            using var scope = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesClientDiagnostics.CreateScope("AllowedEnvironmentTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _allowedEnvironmentTypeProjectAllowedEnvironmentTypesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, environmentTypeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AllowedEnvironmentTypeResource>(response.GetRawResponse());
                return Response.FromValue(new AllowedEnvironmentTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AllowedEnvironmentTypeResource> IEnumerable<AllowedEnvironmentTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AllowedEnvironmentTypeResource> IAsyncEnumerable<AllowedEnvironmentTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
