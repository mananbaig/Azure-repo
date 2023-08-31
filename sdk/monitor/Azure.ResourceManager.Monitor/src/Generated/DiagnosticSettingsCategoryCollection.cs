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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="DiagnosticSettingsCategoryResource" /> and their operations.
    /// Each <see cref="DiagnosticSettingsCategoryResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="DiagnosticSettingsCategoryCollection" /> instance call the GetDiagnosticSettingsCategories method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class DiagnosticSettingsCategoryCollection : ArmCollection, IEnumerable<DiagnosticSettingsCategoryResource>, IAsyncEnumerable<DiagnosticSettingsCategoryResource>
    {
        private readonly ClientDiagnostics _diagnosticSettingsCategoryClientDiagnostics;
        private readonly DiagnosticSettingsCategoryRestOperations _diagnosticSettingsCategoryRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCategoryCollection"/> class for mocking. </summary>
        protected DiagnosticSettingsCategoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCategoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiagnosticSettingsCategoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diagnosticSettingsCategoryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DiagnosticSettingsCategoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiagnosticSettingsCategoryResource.ResourceType, out string diagnosticSettingsCategoryApiVersion);
            _diagnosticSettingsCategoryRestClient = new DiagnosticSettingsCategoryRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diagnosticSettingsCategoryApiVersion);
        }

        /// <summary>
        /// Gets the diagnostic settings category for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettingsCategory_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DiagnosticSettingsCategoryResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsCategoryClientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsCategoryRestClient.GetAsync(Id, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the diagnostic settings category for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettingsCategory_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettingsCategoryResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsCategoryClientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsCategoryRestClient.Get(Id, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsCategoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the diagnostic settings categories for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettingsCategory_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiagnosticSettingsCategoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiagnosticSettingsCategoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diagnosticSettingsCategoryRestClient.CreateListRequest(Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new DiagnosticSettingsCategoryResource(Client, DiagnosticSettingsCategoryData.DeserializeDiagnosticSettingsCategoryData(e)), _diagnosticSettingsCategoryClientDiagnostics, Pipeline, "DiagnosticSettingsCategoryCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the diagnostic settings categories for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettingsCategory_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiagnosticSettingsCategoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiagnosticSettingsCategoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diagnosticSettingsCategoryRestClient.CreateListRequest(Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new DiagnosticSettingsCategoryResource(Client, DiagnosticSettingsCategoryData.DeserializeDiagnosticSettingsCategoryData(e)), _diagnosticSettingsCategoryClientDiagnostics, Pipeline, "DiagnosticSettingsCategoryCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettingsCategory_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsCategoryClientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsCategoryRestClient.GetAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettingsCategory_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsCategoryClientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsCategoryRestClient.Get(Id, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiagnosticSettingsCategoryResource> IEnumerable<DiagnosticSettingsCategoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiagnosticSettingsCategoryResource> IAsyncEnumerable<DiagnosticSettingsCategoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
