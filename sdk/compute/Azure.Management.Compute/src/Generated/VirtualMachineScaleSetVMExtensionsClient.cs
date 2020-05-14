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
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The VirtualMachineScaleSetVMExtensions service client. </summary>
    public partial class VirtualMachineScaleSetVMExtensionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VirtualMachineScaleSetVMExtensionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsClient for mocking. </summary>
        protected VirtualMachineScaleSetVMExtensionsClient()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsClient. </summary>
        public VirtualMachineScaleSetVMExtensionsClient(string subscriptionId, TokenCredential tokenCredential, ComputeManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsClient. </summary>
        public VirtualMachineScaleSetVMExtensionsClient(string subscriptionId, string host, TokenCredential tokenCredential, ComputeManagementClientOptions options = null)
        {
            options ??= new ComputeManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new VirtualMachineScaleSetVMExtensionsRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> The operation to get the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualMachineExtension>> GetAsync(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualMachineExtension> Get(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all extensions of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualMachineExtensionsListResult>> ListAsync(string resourceGroupName, string vmScaleSetName, string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(resourceGroupName, vmScaleSetName, instanceId, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all extensions of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualMachineExtensionsListResult> List(string resourceGroupName, string vmScaleSetName, string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.List");
            scope.Start();
            try
            {
                return RestClient.List(resourceGroupName, vmScaleSetName, instanceId, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtension extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, cancellationToken);
                return new VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to update the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualMachineScaleSetVMExtensionsUpdateOperation> StartUpdateAsync(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetVMExtensionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to update the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="extensionParameters"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetVMExtensionsUpdateOperation StartUpdate(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, VirtualMachineExtensionUpdate extensionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }
            if (extensionParameters == null)
            {
                throw new ArgumentNullException(nameof(extensionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters, cancellationToken);
                return new VirtualMachineScaleSetVMExtensionsUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, extensionParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualMachineScaleSetVMExtensionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetVMExtensionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the VMSS VM extension. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualMachineScaleSetVMExtensionsDeleteOperation StartDelete(string resourceGroupName, string vmScaleSetName, string instanceId, string vmExtensionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vmScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(vmScaleSetName));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (vmExtensionName == null)
            {
                throw new ArgumentNullException(nameof(vmExtensionName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMExtensionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName, cancellationToken);
                return new VirtualMachineScaleSetVMExtensionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vmScaleSetName, instanceId, vmExtensionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
