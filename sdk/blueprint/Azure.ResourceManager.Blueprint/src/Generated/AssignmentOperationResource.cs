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

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A Class representing an AssignmentOperation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AssignmentOperationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAssignmentOperationResource method.
    /// Otherwise you can get one from its parent resource <see cref="AssignmentResource" /> using the GetAssignmentOperation method.
    /// </summary>
    public partial class AssignmentOperationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AssignmentOperationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceScope, string assignmentName, string assignmentOperationName)
        {
            var resourceId = $"{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _assignmentOperationClientDiagnostics;
        private readonly AssignmentRestOperations _assignmentOperationRestClient;
        private readonly AssignmentOperationData _data;

        /// <summary> Initializes a new instance of the <see cref="AssignmentOperationResource"/> class for mocking. </summary>
        protected AssignmentOperationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AssignmentOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AssignmentOperationResource(ArmClient client, AssignmentOperationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AssignmentOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AssignmentOperationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _assignmentOperationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string assignmentOperationApiVersion);
            _assignmentOperationRestClient = new AssignmentRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, assignmentOperationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Blueprint/blueprintAssignments/assignmentOperations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AssignmentOperationData Data
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
        /// Get a blueprint assignment operation.
        /// Request Path: /{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}
        /// Operation Id: AssignmentOperations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AssignmentOperationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentOperationClientDiagnostics.CreateScope("AssignmentOperationResource.Get");
            scope.Start();
            try
            {
                var response = await _assignmentOperationRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssignmentOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint assignment operation.
        /// Request Path: /{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}/assignmentOperations/{assignmentOperationName}
        /// Operation Id: AssignmentOperations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AssignmentOperationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _assignmentOperationClientDiagnostics.CreateScope("AssignmentOperationResource.Get");
            scope.Start();
            try
            {
                var response = _assignmentOperationRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AssignmentOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
