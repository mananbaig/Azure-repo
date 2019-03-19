// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PeeringManagementClient.
    /// </summary>
    public static partial class PeeringManagementClientExtensions
    {
            /// <summary>
            /// Gets the peer info associated with the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<PeerInfo> GetPeerInfo(this IPeeringManagementClient operations)
            {
                return operations.GetPeerInfoAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the peer info associated with the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PeerInfo>> GetPeerInfoAsync(this IPeeringManagementClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPeerInfoWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the peer info associated with the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerInfo'>
            /// The peer info.
            /// </param>
            public static IList<PeerInfo> UpdatePeerInfo(this IPeeringManagementClient operations, IList<PeerInfo> peerInfo)
            {
                return operations.UpdatePeerInfoAsync(peerInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the peer info associated with the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peerInfo'>
            /// The peer info.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PeerInfo>> UpdatePeerInfoAsync(this IPeeringManagementClient operations, IList<PeerInfo> peerInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdatePeerInfoWithHttpMessagesAsync(peerInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
