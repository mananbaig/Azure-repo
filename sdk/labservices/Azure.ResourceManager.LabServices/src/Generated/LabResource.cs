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
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A Class representing a Lab along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LabResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLabResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetLab method.
    /// </summary>
    public partial class LabResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LabResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string labName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _labClientDiagnostics;
        private readonly LabsRestOperations _labRestClient;
        private readonly LabData _data;

        /// <summary> Initializes a new instance of the <see cref="LabResource"/> class for mocking. </summary>
        protected LabResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LabResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LabResource(ArmClient client, LabData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LabResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LabResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LabServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string labApiVersion);
            _labRestClient = new LabsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.LabServices/labs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LabData Data
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

        /// <summary> Gets a collection of LabServicesScheduleResources in the Lab. </summary>
        /// <returns> An object representing collection of LabServicesScheduleResources and their operations over a LabServicesScheduleResource. </returns>
        public virtual LabServicesScheduleCollection GetLabServicesSchedules()
        {
            return GetCachedClient(Client => new LabServicesScheduleCollection(Client, Id));
        }

        /// <summary>
        /// Returns the properties of a lab Schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_Get
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LabServicesScheduleResource>> GetLabServicesScheduleAsync(string scheduleName, CancellationToken cancellationToken = default)
        {
            return await GetLabServicesSchedules().GetAsync(scheduleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties of a lab Schedule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}
        /// Operation Id: Schedules_Get
        /// </summary>
        /// <param name="scheduleName"> The name of the schedule that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scheduleName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<LabServicesScheduleResource> GetLabServicesSchedule(string scheduleName, CancellationToken cancellationToken = default)
        {
            return GetLabServicesSchedules().Get(scheduleName, cancellationToken);
        }

        /// <summary> Gets a collection of LabUserResources in the Lab. </summary>
        /// <returns> An object representing collection of LabUserResources and their operations over a LabUserResource. </returns>
        public virtual LabUserCollection GetLabUsers()
        {
            return GetCachedClient(Client => new LabUserCollection(Client, Id));
        }

        /// <summary>
        /// Returns the properties of a lab user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}
        /// Operation Id: Users_Get
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LabUserResource>> GetLabUserAsync(string userName, CancellationToken cancellationToken = default)
        {
            return await GetLabUsers().GetAsync(userName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties of a lab user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/users/{userName}
        /// Operation Id: Users_Get
        /// </summary>
        /// <param name="userName"> The name of the user that uniquely identifies it within containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<LabUserResource> GetLabUser(string userName, CancellationToken cancellationToken = default)
        {
            return GetLabUsers().Get(userName, cancellationToken);
        }

        /// <summary> Gets a collection of LabVirtualMachineResources in the Lab. </summary>
        /// <returns> An object representing collection of LabVirtualMachineResources and their operations over a LabVirtualMachineResource. </returns>
        public virtual LabVirtualMachineCollection GetLabVirtualMachines()
        {
            return GetCachedClient(Client => new LabVirtualMachineCollection(Client, Id));
        }

        /// <summary>
        /// Returns the properties for a lab virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> The ID of the virtual machine that uniquely identifies it within the containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LabVirtualMachineResource>> GetLabVirtualMachineAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return await GetLabVirtualMachines().GetAsync(virtualMachineName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties for a lab virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/virtualMachines/{virtualMachineName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="virtualMachineName"> The ID of the virtual machine that uniquely identifies it within the containing lab. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<LabVirtualMachineResource> GetLabVirtualMachine(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return GetLabVirtualMachines().Get(virtualMachineName, cancellationToken);
        }

        /// <summary>
        /// Returns the properties of a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LabResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.Get");
            scope.Start();
            try
            {
                var response = await _labRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the properties of a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LabResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.Get");
            scope.Start();
            try
            {
                var response = _labRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to delete a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.Delete");
            scope.Start();
            try
            {
                var response = await _labRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation(_labClientDiagnostics, Pipeline, _labRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to delete a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.Delete");
            scope.Start();
            try
            {
                var response = _labRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new LabServicesArmOperation(_labClientDiagnostics, Pipeline, _labRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to update a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<LabResource>> UpdateAsync(WaitUntil waitUntil, LabPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _labClientDiagnostics.CreateScope("LabResource.Update");
            scope.Start();
            try
            {
                var response = await _labRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation<LabResource>(new LabOperationSource(Client), _labClientDiagnostics, Pipeline, _labRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Operation to update a lab resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}
        /// Operation Id: Labs_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<LabResource> Update(WaitUntil waitUntil, LabPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _labClientDiagnostics.CreateScope("LabResource.Update");
            scope.Start();
            try
            {
                var response = _labRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                var operation = new LabServicesArmOperation<LabResource>(new LabOperationSource(Client), _labClientDiagnostics, Pipeline, _labRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Publish or re-publish a lab. This will create or update all lab resources, such as virtual machines.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/publish
        /// Operation Id: Labs_Publish
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> PublishAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.Publish");
            scope.Start();
            try
            {
                var response = await _labRestClient.PublishAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation(_labClientDiagnostics, Pipeline, _labRestClient.CreatePublishRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Publish or re-publish a lab. This will create or update all lab resources, such as virtual machines.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/publish
        /// Operation Id: Labs_Publish
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Publish(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.Publish");
            scope.Start();
            try
            {
                var response = _labRestClient.Publish(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new LabServicesArmOperation(_labClientDiagnostics, Pipeline, _labRestClient.CreatePublishRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Action used to manually kick off an AAD group sync job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/syncGroup
        /// Operation Id: Labs_SyncGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> SyncGroupAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.SyncGroup");
            scope.Start();
            try
            {
                var response = await _labRestClient.SyncGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation(_labClientDiagnostics, Pipeline, _labRestClient.CreateSyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Action used to manually kick off an AAD group sync job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/syncGroup
        /// Operation Id: Labs_SyncGroup
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation SyncGroup(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labClientDiagnostics.CreateScope("LabResource.SyncGroup");
            scope.Start();
            try
            {
                var response = _labRestClient.SyncGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new LabServicesArmOperation(_labClientDiagnostics, Pipeline, _labRestClient.CreateSyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
