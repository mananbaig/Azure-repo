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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    /// <summary>
    /// A Class representing a MarketplaceAgreement along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MarketplaceAgreementResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMarketplaceAgreementResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetMarketplaceAgreement method.
    /// </summary>
    public partial class MarketplaceAgreementResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MarketplaceAgreementResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="publisherId"> The publisherId. </param>
        /// <param name="offerId"> The offerId. </param>
        /// <param name="planId"> The planId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string publisherId, string offerId, string planId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _marketplaceAgreementClientDiagnostics;
        private readonly MarketplaceAgreementsRestOperations _marketplaceAgreementRestClient;
        private readonly MarketplaceAgreementTermData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MarketplaceOrdering/agreements/offers/plans";

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementResource"/> class for mocking. </summary>
        protected MarketplaceAgreementResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MarketplaceAgreementResource(ArmClient client, MarketplaceAgreementTermData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MarketplaceAgreementResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MarketplaceAgreementResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _marketplaceAgreementClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MarketplaceOrdering", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string marketplaceAgreementApiVersion);
            _marketplaceAgreementRestClient = new MarketplaceAgreementsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, marketplaceAgreementApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MarketplaceAgreementTermData Data
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
        /// Get marketplace agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_GetAgreement</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MarketplaceAgreementResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementClientDiagnostics.CreateScope("MarketplaceAgreementResource.Get");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementRestClient.GetAgreementAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get marketplace agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_GetAgreement</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MarketplaceAgreementResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementClientDiagnostics.CreateScope("MarketplaceAgreementResource.Get");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementRestClient.GetAgreement(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MarketplaceAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sign marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}/sign</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Sign</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MarketplaceAgreementResource>> SignAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementClientDiagnostics.CreateScope("MarketplaceAgreementResource.Sign");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementRestClient.SignAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MarketplaceAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sign marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}/sign</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Sign</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MarketplaceAgreementResource> Sign(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementClientDiagnostics.CreateScope("MarketplaceAgreementResource.Sign");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementRestClient.Sign(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MarketplaceAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancel marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MarketplaceAgreementResource>> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementClientDiagnostics.CreateScope("MarketplaceAgreementResource.Cancel");
            scope.Start();
            try
            {
                var response = await _marketplaceAgreementRestClient.CancelAsync(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MarketplaceAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancel marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Cancel</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MarketplaceAgreementResource> Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _marketplaceAgreementClientDiagnostics.CreateScope("MarketplaceAgreementResource.Cancel");
            scope.Start();
            try
            {
                var response = _marketplaceAgreementRestClient.Cancel(Id.SubscriptionId, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MarketplaceAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
