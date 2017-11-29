// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SoftwareUpdateConfigurationsOperations.
    /// </summary>
    public static partial class SoftwareUpdateConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Create a new software update configuration with the name given in the URI.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='parameters'>
            /// Request body.
            /// </param>
            public static SoftwareUpdateConfiguration Create(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, SoftwareUpdateConfiguration parameters)
            {
                return operations.CreateAsync(resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new software update configuration with the name given in the URI.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='parameters'>
            /// Request body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfiguration> CreateAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, SoftwareUpdateConfiguration parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a single software update configuration by name.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            public static SoftwareUpdateConfiguration GetByName(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName)
            {
                return operations.GetByNameAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a single software update configuration by name.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfiguration> GetByNameAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByNameWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// delete a specific software update configuration.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            public static void Delete(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName)
            {
                operations.DeleteAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// delete a specific software update configuration.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get all software update configurations for the account.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static SoftwareUpdateConfigurationListResult List(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string filter = default(string))
            {
                return operations.ListAsync(resourceGroupName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all software update configurations for the account.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within user's subscription.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfigurationListResult> ListAsync(this ISoftwareUpdateConfigurationsOperations operations, string resourceGroupName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
