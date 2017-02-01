// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for RolesOperations.
    /// </summary>
    public static partial class RolesOperationsExtensions
    {
            /// <summary>
            /// Gets all the roles for the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<RoleResourceFormat> ListByHub(this IRolesOperations operations, string resourceGroupName, string hubName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRolesOperations)s).ListByHubAsync(resourceGroupName, hubName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the roles for the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<RoleResourceFormat>> ListByHubAsync(this IRolesOperations operations, string resourceGroupName, string hubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByHubWithHttpMessagesAsync(resourceGroupName, hubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the roles for the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<RoleResourceFormat> ListByHubNext(this IRolesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IRolesOperations)s).ListByHubNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the roles for the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<RoleResourceFormat>> ListByHubNextAsync(this IRolesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByHubNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
