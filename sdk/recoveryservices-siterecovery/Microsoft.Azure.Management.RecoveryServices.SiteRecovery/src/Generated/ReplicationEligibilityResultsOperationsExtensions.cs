// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationEligibilityResultsOperations.
    /// </summary>
    public static partial class ReplicationEligibilityResultsOperationsExtensions
    {
            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            public static ReplicationEligibilityResultsCollection List(this IReplicationEligibilityResultsOperations operations, string virtualMachineName)
            {
                return operations.ListAsync(virtualMachineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationEligibilityResultsCollection> ListAsync(this IReplicationEligibilityResultsOperations operations, string virtualMachineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(virtualMachineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            public static ReplicationEligibilityResults Get(this IReplicationEligibilityResultsOperations operations, string virtualMachineName)
            {
                return operations.GetAsync(virtualMachineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationEligibilityResults> GetAsync(this IReplicationEligibilityResultsOperations operations, string virtualMachineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(virtualMachineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            public static ReplicationEligibilityResultsCollection BeginList(this IReplicationEligibilityResultsOperations operations, string virtualMachineName)
            {
                return operations.BeginListAsync(virtualMachineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationEligibilityResultsCollection> BeginListAsync(this IReplicationEligibilityResultsOperations operations, string virtualMachineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListWithHttpMessagesAsync(virtualMachineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            public static ReplicationEligibilityResults BeginGet(this IReplicationEligibilityResultsOperations operations, string virtualMachineName)
            {
                return operations.BeginGetAsync(virtualMachineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the validation errors in case the VM is unsuitable for protection.
            /// </summary>
            /// <remarks>
            /// Validates whether a given VM can be protected or not in which case returns
            /// list of errors.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='virtualMachineName'>
            /// Virtual Machine name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationEligibilityResults> BeginGetAsync(this IReplicationEligibilityResultsOperations operations, string virtualMachineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginGetWithHttpMessagesAsync(virtualMachineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
