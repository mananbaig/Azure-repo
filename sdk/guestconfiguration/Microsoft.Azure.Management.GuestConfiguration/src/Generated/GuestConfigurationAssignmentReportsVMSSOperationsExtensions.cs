// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GuestConfigurationAssignmentReportsVMSSOperations.
    /// </summary>
    public static partial class GuestConfigurationAssignmentReportsVMSSOperationsExtensions
    {
            /// <summary>
            /// List all reports for the VMSS guest configuration assignment, latest report
            /// first.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            public static IEnumerable<GuestConfigurationAssignmentReport> List(this IGuestConfigurationAssignmentReportsVMSSOperations operations, string resourceGroupName, string vmssName, string name)
            {
                return operations.ListAsync(resourceGroupName, vmssName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all reports for the VMSS guest configuration assignment, latest report
            /// first.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<GuestConfigurationAssignmentReport>> ListAsync(this IGuestConfigurationAssignmentReportsVMSSOperations operations, string resourceGroupName, string vmssName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, vmssName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a report for the VMSS guest configuration assignment, by reportId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='id'>
            /// The GUID for the guest configuration assignment report.
            /// </param>
            public static GuestConfigurationAssignmentReport Get(this IGuestConfigurationAssignmentReportsVMSSOperations operations, string resourceGroupName, string vmssName, string name, string id)
            {
                return operations.GetAsync(resourceGroupName, vmssName, name, id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a report for the VMSS guest configuration assignment, by reportId.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='id'>
            /// The GUID for the guest configuration assignment report.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignmentReport> GetAsync(this IGuestConfigurationAssignmentReportsVMSSOperations operations, string resourceGroupName, string vmssName, string name, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmssName, name, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
