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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A Class representing a LogicWorkflowRunActionScopeRepetition along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LogicWorkflowRunActionScopeRepetitionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLogicWorkflowRunActionScopeRepetitionResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogicWorkflowRunActionResource" /> using the GetLogicWorkflowRunActionScopeRepetition method.
    /// </summary>
    public partial class LogicWorkflowRunActionScopeRepetitionResource : LogicWorkflowRunActionRepetitionDefinitionResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicWorkflowRunActionScopeRepetitionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics;
        private readonly WorkflowRunActionScopeRepetitionsRestOperations _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionScopeRepetitionResource"/> class for mocking. </summary>
        protected LogicWorkflowRunActionScopeRepetitionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowRunActionScopeRepetitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowRunActionScopeRepetitionResource(ArmClient client, LogicWorkflowRunActionRepetitionDefinitionData data) : base(client, data)
        {
            _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsApiVersion);
            _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient = new WorkflowRunActionScopeRepetitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowRunActionScopeRepetitionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowRunActionScopeRepetitionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsApiVersion);
            _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient = new WorkflowRunActionScopeRepetitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Logic/workflows/runs/actions/scopeRepetitions";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Get a workflow run action scoped repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionScopeRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<LogicWorkflowRunActionRepetitionDefinitionResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionResource.GetCore");
            scope.Start();
            try
            {
                var response = await _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionScopeRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<LogicWorkflowRunActionScopeRepetitionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((LogicWorkflowRunActionScopeRepetitionResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Get a workflow run action scoped repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionScopeRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<LogicWorkflowRunActionRepetitionDefinitionResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsClientDiagnostics.CreateScope("LogicWorkflowRunActionScopeRepetitionResource.GetCore");
            scope.Start();
            try
            {
                var response = _logicWorkflowRunActionScopeRepetitionWorkflowRunActionScopeRepetitionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workflow run action scoped repetition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/runs/{runName}/actions/{actionName}/scopeRepetitions/{repetitionName}
        /// Operation Id: WorkflowRunActionScopeRepetitions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<LogicWorkflowRunActionScopeRepetitionResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((LogicWorkflowRunActionScopeRepetitionResource)value.Value, value.GetRawResponse());
        }
    }
}
