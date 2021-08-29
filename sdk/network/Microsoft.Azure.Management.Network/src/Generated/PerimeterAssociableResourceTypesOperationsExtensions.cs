// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PerimeterAssociableResourceTypesOperations.
    /// </summary>
    public static partial class PerimeterAssociableResourceTypesOperationsExtensions
    {
            /// <summary>
            /// Gets the list of resources that are onboarded with NSP. These resources can
            /// be associated with a network security perimeter
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the where the association is present.
            /// </param>
            public static PerimeterAssociableResourcesListResult Get(this IPerimeterAssociableResourceTypesOperations operations, string location)
            {
                return operations.GetAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of resources that are onboarded with NSP. These resources can
            /// be associated with a network security perimeter
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location of the where the association is present.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PerimeterAssociableResourcesListResult> GetAsync(this IPerimeterAssociableResourceTypesOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
