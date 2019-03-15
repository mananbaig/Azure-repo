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
    /// Extension methods for LegacyPeeringsOperations.
    /// </summary>
    public static partial class LegacyPeeringsOperationsExtensions
    {
            /// <summary>
            /// Lists all of the legacy peerings under the given subscription matching the
            /// specified kind and location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringLocation'>
            /// The location of the peering.
            /// </param>
            /// <param name='kind'>
            /// The kind of the peering. Possible values include: 'Direct', 'Exchange'
            /// </param>
            public static IEnumerable<PeeringModel> List(this ILegacyPeeringsOperations operations, string peeringLocation, string kind)
            {
                return operations.ListAsync(peeringLocation, kind).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the legacy peerings under the given subscription matching the
            /// specified kind and location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringLocation'>
            /// The location of the peering.
            /// </param>
            /// <param name='kind'>
            /// The kind of the peering. Possible values include: 'Direct', 'Exchange'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PeeringModel>> ListAsync(this ILegacyPeeringsOperations operations, string peeringLocation, string kind, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(peeringLocation, kind, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
