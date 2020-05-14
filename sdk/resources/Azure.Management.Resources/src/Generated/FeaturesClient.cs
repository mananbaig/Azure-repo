// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resources.Models;

namespace Azure.Management.Resources
{
    /// <summary> The Features service client. </summary>
    public partial class FeaturesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal FeaturesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of FeaturesClient for mocking. </summary>
        protected FeaturesClient()
        {
        }

        /// <summary> Initializes a new instance of FeaturesClient. </summary>
        public FeaturesClient(string subscriptionId, TokenCredential tokenCredential, ResourcesManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of FeaturesClient. </summary>
        public FeaturesClient(string subscriptionId, string host, TokenCredential tokenCredential, ResourcesManagementClientOptions options = null)
        {
            options ??= new ResourcesManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new FeaturesRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> Gets the preview feature with the specified name. </summary>
        /// <param name="resourceProviderNamespace"> The resource provider namespace for the feature. </param>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResult>> GetAsync(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FeaturesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceProviderNamespace, featureName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the preview feature with the specified name. </summary>
        /// <param name="resourceProviderNamespace"> The resource provider namespace for the feature. </param>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResult> Get(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FeaturesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceProviderNamespace, featureName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResult>> RegisterAsync(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FeaturesClient.Register");
            scope.Start();
            try
            {
                return await RestClient.RegisterAsync(resourceProviderNamespace, featureName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResult> Register(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FeaturesClient.Register");
            scope.Start();
            try
            {
                return RestClient.Register(resourceProviderNamespace, featureName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unregisters the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResult>> UnregisterAsync(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FeaturesClient.Unregister");
            scope.Start();
            try
            {
                return await RestClient.UnregisterAsync(resourceProviderNamespace, featureName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unregisters the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResult> Unregister(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FeaturesClient.Unregister");
            scope.Start();
            try
            {
                return RestClient.Unregister(resourceProviderNamespace, featureName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the preview features that are available through AFEC for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<FeatureResult> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FeatureResult>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FeatureResult>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the preview features that are available through AFEC for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<FeatureResult> ListAll(CancellationToken cancellationToken = default)
        {
            Page<FeatureResult> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAll(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FeatureResult> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the preview features in a provider namespace that are available through AFEC for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider for getting features. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<FeatureResult> ListAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }

            async Task<Page<FeatureResult>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FeatureResult>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the preview features in a provider namespace that are available through AFEC for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider for getting features. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<FeatureResult> List(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }

            Page<FeatureResult> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceProviderNamespace, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FeatureResult> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FeaturesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceProviderNamespace, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
