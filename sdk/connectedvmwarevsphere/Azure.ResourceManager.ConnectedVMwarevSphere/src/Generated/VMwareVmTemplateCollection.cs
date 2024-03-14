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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing a collection of <see cref="VMwareVmTemplateResource"/> and their operations.
    /// Each <see cref="VMwareVmTemplateResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VMwareVmTemplateCollection"/> instance call the GetVMwareVmTemplates method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VMwareVmTemplateCollection : ArmCollection, IEnumerable<VMwareVmTemplateResource>, IAsyncEnumerable<VMwareVmTemplateResource>
    {
        private readonly ClientDiagnostics _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics;
        private readonly VirtualMachineTemplatesRestOperations _vMwareVmTemplateVirtualMachineTemplatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VMwareVmTemplateCollection"/> class for mocking. </summary>
        protected VMwareVmTemplateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VMwareVmTemplateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VMwareVmTemplateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareVmTemplateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VMwareVmTemplateResource.ResourceType, out string vMwareVmTemplateVirtualMachineTemplatesApiVersion);
            _vMwareVmTemplateVirtualMachineTemplatesRestClient = new VirtualMachineTemplatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vMwareVmTemplateVirtualMachineTemplatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update virtual machine template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VMwareVmTemplateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualMachineTemplateName, VMwareVmTemplateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vMwareVmTemplateVirtualMachineTemplatesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareVmTemplateResource>(new VMwareVmTemplateOperationSource(Client), _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, _vMwareVmTemplateVirtualMachineTemplatesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update virtual machine template.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VMwareVmTemplateResource> CreateOrUpdate(WaitUntil waitUntil, string virtualMachineTemplateName, VMwareVmTemplateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vMwareVmTemplateVirtualMachineTemplatesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<VMwareVmTemplateResource>(new VMwareVmTemplateOperationSource(Client), _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, _vMwareVmTemplateVirtualMachineTemplatesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements virtual machine template GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual async Task<Response<VMwareVmTemplateResource>> GetAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = await _vMwareVmTemplateVirtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareVmTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements virtual machine template GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual Response<VMwareVmTemplateResource> Get(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.Get");
            scope.Start();
            try
            {
                var response = _vMwareVmTemplateVirtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VMwareVmTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of virtualMachineTemplates in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareVmTemplateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareVmTemplateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareVmTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareVmTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VMwareVmTemplateResource(Client, VMwareVmTemplateData.DeserializeVMwareVmTemplateData(e)), _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, "VMwareVmTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualMachineTemplates in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareVmTemplateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareVmTemplateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _vMwareVmTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _vMwareVmTemplateVirtualMachineTemplatesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VMwareVmTemplateResource(Client, VMwareVmTemplateData.DeserializeVMwareVmTemplateData(e)), _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics, Pipeline, "VMwareVmTemplateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vMwareVmTemplateVirtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.Exists");
            scope.Start();
            try
            {
                var response = _vMwareVmTemplateVirtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual async Task<NullableResponse<VMwareVmTemplateResource>> GetIfExistsAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _vMwareVmTemplateVirtualMachineTemplatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VMwareVmTemplateResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareVmTemplateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VMwareVmTemplateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        public virtual NullableResponse<VMwareVmTemplateResource> GetIfExists(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineTemplateName, nameof(virtualMachineTemplateName));

            using var scope = _vMwareVmTemplateVirtualMachineTemplatesClientDiagnostics.CreateScope("VMwareVmTemplateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _vMwareVmTemplateVirtualMachineTemplatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineTemplateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VMwareVmTemplateResource>(response.GetRawResponse());
                return Response.FromValue(new VMwareVmTemplateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VMwareVmTemplateResource> IEnumerable<VMwareVmTemplateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VMwareVmTemplateResource> IAsyncEnumerable<VMwareVmTemplateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
