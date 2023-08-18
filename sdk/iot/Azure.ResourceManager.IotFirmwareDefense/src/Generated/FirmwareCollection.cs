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

namespace Azure.ResourceManager.IotFirmwareDefense
{
    /// <summary>
    /// A class representing a collection of <see cref="FirmwareResource" /> and their operations.
    /// Each <see cref="FirmwareResource" /> in the collection will belong to the same instance of <see cref="FirmwareWorkspaceResource" />.
    /// To get a <see cref="FirmwareCollection" /> instance call the GetFirmwares method from an instance of <see cref="FirmwareWorkspaceResource" />.
    /// </summary>
    public partial class FirmwareCollection : ArmCollection, IEnumerable<FirmwareResource>, IAsyncEnumerable<FirmwareResource>
    {
        private readonly ClientDiagnostics _firmwareClientDiagnostics;
        private readonly FirmwareRestOperations _firmwareRestClient;

        /// <summary> Initializes a new instance of the <see cref="FirmwareCollection"/> class for mocking. </summary>
        protected FirmwareCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FirmwareCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FirmwareCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _firmwareClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotFirmwareDefense", FirmwareResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FirmwareResource.ResourceType, out string firmwareApiVersion);
            _firmwareRestClient = new FirmwareRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, firmwareApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != FirmwareWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, FirmwareWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create a firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firmwareName"> The id of the firmware. </param>
        /// <param name="data"> Details of the firmware being created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FirmwareResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string firmwareName, FirmwareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareName, nameof(firmwareName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _firmwareClientDiagnostics.CreateScope("FirmwareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _firmwareRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IotFirmwareDefenseArmOperation<FirmwareResource>(Response.FromValue(new FirmwareResource(Client, response), response.GetRawResponse()));
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
        /// The operation to create a firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="firmwareName"> The id of the firmware. </param>
        /// <param name="data"> Details of the firmware being created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FirmwareResource> CreateOrUpdate(WaitUntil waitUntil, string firmwareName, FirmwareData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareName, nameof(firmwareName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _firmwareClientDiagnostics.CreateScope("FirmwareCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _firmwareRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareName, data, cancellationToken);
                var operation = new IotFirmwareDefenseArmOperation<FirmwareResource>(Response.FromValue(new FirmwareResource(Client, response), response.GetRawResponse()));
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
        /// Get firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareName"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareName"/> is null. </exception>
        public virtual async Task<Response<FirmwareResource>> GetAsync(string firmwareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareName, nameof(firmwareName));

            using var scope = _firmwareClientDiagnostics.CreateScope("FirmwareCollection.Get");
            scope.Start();
            try
            {
                var response = await _firmwareRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirmwareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get firmware.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareName"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareName"/> is null. </exception>
        public virtual Response<FirmwareResource> Get(string firmwareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareName, nameof(firmwareName));

            using var scope = _firmwareClientDiagnostics.CreateScope("FirmwareCollection.Get");
            scope.Start();
            try
            {
                var response = _firmwareRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirmwareResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of firmwares inside a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirmwareResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirmwareResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _firmwareRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _firmwareRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FirmwareResource(Client, FirmwareData.DeserializeFirmwareData(e)), _firmwareClientDiagnostics, Pipeline, "FirmwareCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of firmwares inside a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirmwareResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirmwareResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _firmwareRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _firmwareRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FirmwareResource(Client, FirmwareData.DeserializeFirmwareData(e)), _firmwareClientDiagnostics, Pipeline, "FirmwareCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareName"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string firmwareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareName, nameof(firmwareName));

            using var scope = _firmwareClientDiagnostics.CreateScope("FirmwareCollection.Exists");
            scope.Start();
            try
            {
                var response = await _firmwareRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}/firmwares/{firmwareId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Firmware_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firmwareName"> The id of the firmware. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="firmwareName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="firmwareName"/> is null. </exception>
        public virtual Response<bool> Exists(string firmwareName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(firmwareName, nameof(firmwareName));

            using var scope = _firmwareClientDiagnostics.CreateScope("FirmwareCollection.Exists");
            scope.Start();
            try
            {
                var response = _firmwareRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firmwareName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FirmwareResource> IEnumerable<FirmwareResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FirmwareResource> IAsyncEnumerable<FirmwareResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
