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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A class representing a collection of <see cref="AutonomousDatabaseNationalCharacterSetResource"/> and their operations.
    /// Each <see cref="AutonomousDatabaseNationalCharacterSetResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get an <see cref="AutonomousDatabaseNationalCharacterSetCollection"/> instance call the GetAutonomousDatabaseNationalCharacterSets method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class AutonomousDatabaseNationalCharacterSetCollection : ArmCollection, IEnumerable<AutonomousDatabaseNationalCharacterSetResource>, IAsyncEnumerable<AutonomousDatabaseNationalCharacterSetResource>
    {
        private readonly ClientDiagnostics _autonomousDatabaseNationalCharacterSetClientDiagnostics;
        private readonly AutonomousDatabaseNationalCharacterSetsRestOperations _autonomousDatabaseNationalCharacterSetRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseNationalCharacterSetCollection"/> class for mocking. </summary>
        protected AutonomousDatabaseNationalCharacterSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutonomousDatabaseNationalCharacterSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The name of the Azure region. </param>
        internal AutonomousDatabaseNationalCharacterSetCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _autonomousDatabaseNationalCharacterSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", AutonomousDatabaseNationalCharacterSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutonomousDatabaseNationalCharacterSetResource.ResourceType, out string autonomousDatabaseNationalCharacterSetApiVersion);
            _autonomousDatabaseNationalCharacterSetRestClient = new AutonomousDatabaseNationalCharacterSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autonomousDatabaseNationalCharacterSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a AutonomousDatabaseNationalCharacterSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adbsncharsetname"> AutonomousDatabaseNationalCharacterSets name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adbsncharsetname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adbsncharsetname"/> is null. </exception>
        public virtual async Task<Response<AutonomousDatabaseNationalCharacterSetResource>> GetAsync(string adbsncharsetname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adbsncharsetname, nameof(adbsncharsetname));

            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _autonomousDatabaseNationalCharacterSetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), adbsncharsetname, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseNationalCharacterSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AutonomousDatabaseNationalCharacterSet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adbsncharsetname"> AutonomousDatabaseNationalCharacterSets name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adbsncharsetname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adbsncharsetname"/> is null. </exception>
        public virtual Response<AutonomousDatabaseNationalCharacterSetResource> Get(string adbsncharsetname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adbsncharsetname, nameof(adbsncharsetname));

            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetCollection.Get");
            scope.Start();
            try
            {
                var response = _autonomousDatabaseNationalCharacterSetRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), adbsncharsetname, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseNationalCharacterSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List AutonomousDatabaseNationalCharacterSet resources by Location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutonomousDatabaseNationalCharacterSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutonomousDatabaseNationalCharacterSetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autonomousDatabaseNationalCharacterSetRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _autonomousDatabaseNationalCharacterSetRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutonomousDatabaseNationalCharacterSetResource(Client, AutonomousDatabaseNationalCharacterSetData.DeserializeAutonomousDatabaseNationalCharacterSetData(e)), _autonomousDatabaseNationalCharacterSetClientDiagnostics, Pipeline, "AutonomousDatabaseNationalCharacterSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List AutonomousDatabaseNationalCharacterSet resources by Location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutonomousDatabaseNationalCharacterSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutonomousDatabaseNationalCharacterSetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _autonomousDatabaseNationalCharacterSetRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _autonomousDatabaseNationalCharacterSetRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutonomousDatabaseNationalCharacterSetResource(Client, AutonomousDatabaseNationalCharacterSetData.DeserializeAutonomousDatabaseNationalCharacterSetData(e)), _autonomousDatabaseNationalCharacterSetClientDiagnostics, Pipeline, "AutonomousDatabaseNationalCharacterSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adbsncharsetname"> AutonomousDatabaseNationalCharacterSets name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adbsncharsetname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adbsncharsetname"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string adbsncharsetname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adbsncharsetname, nameof(adbsncharsetname));

            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _autonomousDatabaseNationalCharacterSetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), adbsncharsetname, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adbsncharsetname"> AutonomousDatabaseNationalCharacterSets name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adbsncharsetname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adbsncharsetname"/> is null. </exception>
        public virtual Response<bool> Exists(string adbsncharsetname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adbsncharsetname, nameof(adbsncharsetname));

            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _autonomousDatabaseNationalCharacterSetRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), adbsncharsetname, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adbsncharsetname"> AutonomousDatabaseNationalCharacterSets name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adbsncharsetname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adbsncharsetname"/> is null. </exception>
        public virtual async Task<NullableResponse<AutonomousDatabaseNationalCharacterSetResource>> GetIfExistsAsync(string adbsncharsetname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adbsncharsetname, nameof(adbsncharsetname));

            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _autonomousDatabaseNationalCharacterSetRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(_location), adbsncharsetname, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutonomousDatabaseNationalCharacterSetResource>(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseNationalCharacterSetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/autonomousDatabaseNationalCharacterSets/{adbsncharsetname}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutonomousDatabaseNationalCharacterSets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutonomousDatabaseNationalCharacterSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="adbsncharsetname"> AutonomousDatabaseNationalCharacterSets name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="adbsncharsetname"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="adbsncharsetname"/> is null. </exception>
        public virtual NullableResponse<AutonomousDatabaseNationalCharacterSetResource> GetIfExists(string adbsncharsetname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(adbsncharsetname, nameof(adbsncharsetname));

            using var scope = _autonomousDatabaseNationalCharacterSetClientDiagnostics.CreateScope("AutonomousDatabaseNationalCharacterSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _autonomousDatabaseNationalCharacterSetRestClient.Get(Id.SubscriptionId, new AzureLocation(_location), adbsncharsetname, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutonomousDatabaseNationalCharacterSetResource>(response.GetRawResponse());
                return Response.FromValue(new AutonomousDatabaseNationalCharacterSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutonomousDatabaseNationalCharacterSetResource> IEnumerable<AutonomousDatabaseNationalCharacterSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutonomousDatabaseNationalCharacterSetResource> IAsyncEnumerable<AutonomousDatabaseNationalCharacterSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
