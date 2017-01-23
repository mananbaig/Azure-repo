// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for VirtualMachineExtensionsOperations.
    /// </summary>
    public static partial class VirtualMachineExtensionsOperationsExtensions
    {
            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension CreateOrUpdate(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineExtensionsOperations)s).CreateOrUpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualMachineExtension> CreateOrUpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            public static VirtualMachineExtension BeginCreateOrUpdate(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineExtensionsOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualMachineExtension> BeginCreateOrUpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtension extensionParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            public static OperationStatusResponse Delete(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineExtensionsOperations)s).DeleteAsync(resourceGroupName, vmName, vmExtensionName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<OperationStatusResponse> DeleteAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            public static OperationStatusResponse BeginDelete(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineExtensionsOperations)s).BeginDeleteAsync(resourceGroupName, vmName, vmExtensionName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<OperationStatusResponse> BeginDeleteAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to get the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the extension.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            public static VirtualMachineExtension Get(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, string expand = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineExtensionsOperations)s).GetAsync(resourceGroupName, vmName, vmExtensionName, expand), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the extension.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualMachineExtension> GetAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
