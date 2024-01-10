// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecureScore along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecureScoreResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecureScoreResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSecureScore method.
    /// </summary>
    public partial class SecureScoreResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecureScoreResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="secureScoreName"> The secureScoreName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string secureScoreName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _secureScoreClientDiagnostics;
        private readonly SecureScoresRestOperations _secureScoreRestClient;
        private readonly ClientDiagnostics _secureScoreControlsClientDiagnostics;
        private readonly SecureScoreControlsRestOperations _secureScoreControlsRestClient;
        private readonly SecureScoreData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/secureScores";

        /// <summary> Initializes a new instance of the <see cref="SecureScoreResource"/> class for mocking. </summary>
        protected SecureScoreResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecureScoreResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecureScoreResource(ArmClient client, SecureScoreData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecureScoreResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecureScoreResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _secureScoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string secureScoreApiVersion);
            _secureScoreRestClient = new SecureScoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, secureScoreApiVersion);
            _secureScoreControlsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _secureScoreControlsRestClient = new SecureScoreControlsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecureScoreData Data
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
        /// Get secure score for a specific Microsoft Defender for Cloud initiative within your current scope. For the ASC Default initiative, use 'ascScore'.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecureScoreResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreResource.Get");
            scope.Start();
            try
            {
                var response = await _secureScoreRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecureScoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get secure score for a specific Microsoft Defender for Cloud initiative within your current scope. For the ASC Default initiative, use 'ascScore'.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecureScoreResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreResource.Get");
            scope.Start();
            try
            {
                var response = _secureScoreRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecureScoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all security controls for a specific initiative within a scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}/secureScoreControls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScoreControls_ListBySecureScore</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecureScoreControlDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecureScoreControlDetails> GetSecureScoreControlsAsync(SecurityScoreODataExpand? expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _secureScoreControlsRestClient.CreateListBySecureScoreRequest(Id.SubscriptionId, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _secureScoreControlsRestClient.CreateListBySecureScoreNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SecureScoreControlDetails.DeserializeSecureScoreControlDetails, _secureScoreControlsClientDiagnostics, Pipeline, "SecureScoreResource.GetSecureScoreControls", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all security controls for a specific initiative within a scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}/secureScoreControls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScoreControls_ListBySecureScore</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> OData expand. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecureScoreControlDetails"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecureScoreControlDetails> GetSecureScoreControls(SecurityScoreODataExpand? expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _secureScoreControlsRestClient.CreateListBySecureScoreRequest(Id.SubscriptionId, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _secureScoreControlsRestClient.CreateListBySecureScoreNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SecureScoreControlDetails.DeserializeSecureScoreControlDetails, _secureScoreControlsClientDiagnostics, Pipeline, "SecureScoreResource.GetSecureScoreControls", "value", "nextLink", cancellationToken);
        }
    }
}
