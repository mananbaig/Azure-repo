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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationSourceControlResource" /> and their operations.
    /// Each <see cref="AutomationSourceControlResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get an <see cref="AutomationSourceControlCollection" /> instance call the GetAutomationSourceControls method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class AutomationSourceControlCollection : ArmCollection, IEnumerable<AutomationSourceControlResource>, IAsyncEnumerable<AutomationSourceControlResource>
    {
        private readonly ClientDiagnostics _automationSourceControlSourceControlClientDiagnostics;
        private readonly SourceControlRestOperations _automationSourceControlSourceControlRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationSourceControlCollection"/> class for mocking. </summary>
        protected AutomationSourceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationSourceControlCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationSourceControlCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationSourceControlSourceControlClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationSourceControlResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationSourceControlResource.ResourceType, out string automationSourceControlSourceControlApiVersion);
            _automationSourceControlSourceControlRestClient = new SourceControlRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationSourceControlSourceControlApiVersion);
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
        /// Create a source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="content"> The parameters supplied to the create or update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationSourceControlResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sourceControlName, AutomationSourceControlCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationSourceControlSourceControlRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationSourceControlResource>(Response.FromValue(new AutomationSourceControlResource(Client, response), response.GetRawResponse()));
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
        /// Create a source control.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceControlName"> The source control name. </param>
        /// <param name="content"> The parameters supplied to the create or update source control operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<AutomationSourceControlResource> CreateOrUpdate(WaitUntil waitUntil, string sourceControlName, AutomationSourceControlCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationSourceControlSourceControlRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, content, cancellationToken);
                var operation = new AutomationArmOperation<AutomationSourceControlResource>(Response.FromValue(new AutomationSourceControlResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the source control identified by source control name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual async Task<Response<AutomationSourceControlResource>> GetAsync(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationSourceControlSourceControlRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the source control identified by source control name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual Response<AutomationSourceControlResource> Get(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _automationSourceControlSourceControlRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of source controls.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationSourceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationSourceControlResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationSourceControlSourceControlRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationSourceControlSourceControlRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationSourceControlResource(Client, AutomationSourceControlData.DeserializeAutomationSourceControlData(e)), _automationSourceControlSourceControlClientDiagnostics, Pipeline, "AutomationSourceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of source controls.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationSourceControlResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationSourceControlResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationSourceControlSourceControlRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationSourceControlSourceControlRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new AutomationSourceControlResource(Client, AutomationSourceControlData.DeserializeAutomationSourceControlData(e)), _automationSourceControlSourceControlClientDiagnostics, Pipeline, "AutomationSourceControlCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationSourceControlSourceControlRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/sourceControls/{sourceControlName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControl_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceControlName"> The name of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceControlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlName"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceControlName, nameof(sourceControlName));

            using var scope = _automationSourceControlSourceControlClientDiagnostics.CreateScope("AutomationSourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationSourceControlSourceControlRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceControlName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationSourceControlResource> IEnumerable<AutomationSourceControlResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationSourceControlResource> IAsyncEnumerable<AutomationSourceControlResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
