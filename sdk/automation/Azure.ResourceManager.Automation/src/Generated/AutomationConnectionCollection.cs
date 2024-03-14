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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationConnectionResource"/> and their operations.
    /// Each <see cref="AutomationConnectionResource"/> in the collection will belong to the same instance of <see cref="AutomationAccountResource"/>.
    /// To get an <see cref="AutomationConnectionCollection"/> instance call the GetAutomationConnections method from an instance of <see cref="AutomationAccountResource"/>.
    /// </summary>
    public partial class AutomationConnectionCollection : ArmCollection, IEnumerable<AutomationConnectionResource>, IAsyncEnumerable<AutomationConnectionResource>
    {
        private readonly ClientDiagnostics _automationConnectionConnectionClientDiagnostics;
        private readonly ConnectionRestOperations _automationConnectionConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationConnectionCollection"/> class for mocking. </summary>
        protected AutomationConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationConnectionConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationConnectionResource.ResourceType, out string automationConnectionConnectionApiVersion);
            _automationConnectionConnectionRestClient = new ConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationConnectionConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The parameters supplied to the create or update connection operation. </param>
        /// <param name="content"> The parameters supplied to the create or update connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, AutomationConnectionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationConnectionConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationConnectionResource>(Response.FromValue(new AutomationConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The parameters supplied to the create or update connection operation. </param>
        /// <param name="content"> The parameters supplied to the create or update connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, AutomationConnectionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationConnectionConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationConnectionResource>(Response.FromValue(new AutomationConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the connection identified by connection name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<AutomationConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationConnectionConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the connection identified by connection name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<AutomationConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _automationConnectionConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of connections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationConnectionConnectionRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationConnectionConnectionRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationConnectionResource(Client, AutomationConnectionData.DeserializeAutomationConnectionData(e)), _automationConnectionConnectionClientDiagnostics, Pipeline, "AutomationConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of connections.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_ListByAutomationAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationConnectionConnectionRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationConnectionConnectionRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationConnectionResource(Client, AutomationConnectionData.DeserializeAutomationConnectionData(e)), _automationConnectionConnectionClientDiagnostics, Pipeline, "AutomationConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationConnectionConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationConnectionConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationConnectionResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationConnectionConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Connection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutomationConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual NullableResponse<AutomationConnectionResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _automationConnectionConnectionClientDiagnostics.CreateScope("AutomationConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationConnectionConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationConnectionResource> IEnumerable<AutomationConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationConnectionResource> IAsyncEnumerable<AutomationConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
