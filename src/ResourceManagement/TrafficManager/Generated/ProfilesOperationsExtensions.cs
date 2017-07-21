// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProfilesOperations.
    /// </summary>
    public static partial class ProfilesOperationsExtensions
    {
            
            /// <summary>
            /// Checks the availability of a Traffic Manager Relative DNS name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Gets or sets the name of the resource.
            /// </param>
            /// <param name='type'>
            /// Gets or sets the type of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrafficManagerNameAvailabilityInner> CheckTrafficManagerRelativeDnsNameAvailabilityAsync(this IProfilesOperations operations, string name = default(string), string type = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckTrafficManagerRelativeDnsNameAvailabilityWithHttpMessagesAsync(name, type, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Lists all Traffic Manager profiles within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profiles to
            /// be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ProfileInner>> ListAllInResourceGroupAsync(this IProfilesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllInResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Lists all Traffic Manager profiles within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ProfileInner>> ListAllAsync(this IProfilesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Gets a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileInner> GetAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Create or update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileInner> CreateOrUpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// Deletes a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile to be
            /// deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            
            /// <summary>
            /// Update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the Update operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileInner> UpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
