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
using Azure.ResourceManager.Blueprint.Models;

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A Class representing an Assignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AssignmentResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetAssignment method.
    /// </summary>
    public partial class AssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AssignmentResource"/> instance. </summary>
        /// <param name="resourceScope"> The resourceScope. </param>
        /// <param name="assignmentName"> The assignmentName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceScope, string assignmentName)
        {
            var resourceId = $"{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _assignmentClientDiagnostics;
        private readonly AssignmentsRestOperations _assignmentRestClient;
        private readonly AssignmentData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Blueprint/blueprintAssignments";

        /// <summary> Initializes a new instance of the <see cref="AssignmentResource"/> class for mocking. </summary>
        protected AssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AssignmentResource(ArmClient client, AssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _assignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string assignmentApiVersion);
            _assignmentRestClient = new AssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, assignmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AssignmentData Data
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

        /// <summary> Gets a collection of AssignmentOperationResources in the Assignment. </summary>
        /// <returns> An object representing collection of AssignmentOperationResources and their operations over a AssignmentOperationResource. </returns>
        public virtual AssignmentOperationCollection GetAssignmentOperations()
        {
            return GetCachedClient(client => new AssignmentOperationCollection(client, Id));
        }

        /// <summary>
        /// Get a blueprint assignment operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentOperationName"> Name of the blueprint assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentOperationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentOperationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AssignmentOperationResource>> GetAssignmentOperationAsync(string assignmentOperationName, CancellationToken cancellationToken = default)
        {
            return await GetAssignmentOperations().GetAsync(assignmentOperationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a blueprint assignment operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssignmentOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="assignmentOperationName"> Name of the blueprint assignment operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentOperationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="assignmentOperationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AssignmentOperationResource> GetAssignmentOperation(string assignmentOperationName, CancellationToken cancellationToken = default)
        {
            return GetAssignmentOperations().Get(assignmentOperationName, cancellationToken);
        }

        /// <summary>
        /// Get a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _assignmentRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _assignmentRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deleteBehavior"> When deleteBehavior=all, the resources that were created by the blueprint assignment will be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<AssignmentResource>> DeleteAsync(WaitUntil waitUntil, AssignmentDeleteBehavior? deleteBehavior = null, CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _assignmentRestClient.DeleteAsync(Id.Parent, Id.Name, deleteBehavior, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<AssignmentResource>(Response.FromValue(new AssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Delete a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deleteBehavior"> When deleteBehavior=all, the resources that were created by the blueprint assignment will be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<AssignmentResource> Delete(WaitUntil waitUntil, AssignmentDeleteBehavior? deleteBehavior = null, CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _assignmentRestClient.Delete(Id.Parent, Id.Name, deleteBehavior, cancellationToken);
                var operation = new BlueprintArmOperation<AssignmentResource>(Response.FromValue(new AssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint assignment object to save. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AssignmentResource>> UpdateAsync(WaitUntil waitUntil, AssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _assignmentRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<AssignmentResource>(Response.FromValue(new AssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a blueprint assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint assignment object to save. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AssignmentResource> Update(WaitUntil waitUntil, AssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _assignmentRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new BlueprintArmOperation<AssignmentResource>(Response.FromValue(new AssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Get Blueprints service SPN objectId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/whoIsBlueprint</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_WhoIsBlueprint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WhoIsBlueprintContract>> WhoIsBlueprintAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.WhoIsBlueprint");
            scope.Start();
            try
            {
                var response = await _assignmentRestClient.WhoIsBlueprintAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Blueprints service SPN objectId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/whoIsBlueprint</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assignments_WhoIsBlueprint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WhoIsBlueprintContract> WhoIsBlueprint(CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentClientDiagnostics.CreateScope("AssignmentResource.WhoIsBlueprint");
            scope.Start();
            try
            {
                var response = _assignmentRestClient.WhoIsBlueprint(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
