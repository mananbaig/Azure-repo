// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DnsResolver
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// OutboundEndpointsOperations operations.
    /// </summary>
    public partial interface IOutboundEndpointsOperations
    {
        /// <summary>
        /// Creates or updates an outbound endpoint for a DNS resolver.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='outboundEndpointName'>
        /// The name of the outbound endpoint for the DNS resolver.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the resource. Omit this value to always overwrite the
        /// current resource. Specify the last-seen ETag value to prevent
        /// accidentally overwriting any concurrent changes.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Set to '*' to allow a new resource to be created, but to prevent
        /// updating an existing resource. Other values will be ignored.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OutboundEndpoint>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, string outboundEndpointName, OutboundEndpoint parameters, string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an outbound endpoint for a DNS resolver.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='outboundEndpointName'>
        /// The name of the outbound endpoint for the DNS resolver.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the resource. Omit this value to always overwrite the
        /// current resource. Specify the last-seen ETag value to prevent
        /// accidentally overwriting any concurrent changes.
        /// </param>
        /// <param name='tags'>
        /// Tags for outbound endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OutboundEndpoint>> UpdateWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, string outboundEndpointName, string ifMatch = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an outbound endpoint for a DNS resolver. WARNING: This
        /// operation cannot be undone.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='outboundEndpointName'>
        /// The name of the outbound endpoint for the DNS resolver.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the resource. Omit this value to always overwrite the
        /// current resource. Specify the last-seen ETag value to prevent
        /// accidentally overwriting any concurrent changes.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, string outboundEndpointName, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets properties of an outbound endpoint for a DNS resolver.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='outboundEndpointName'>
        /// The name of the outbound endpoint for the DNS resolver.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OutboundEndpoint>> GetWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, string outboundEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists outbound endpoints for a DNS resolver.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='top'>
        /// The maximum number of results to return. If not specified, returns
        /// up to 100 results.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OutboundEndpoint>>> ListWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an outbound endpoint for a DNS resolver.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='outboundEndpointName'>
        /// The name of the outbound endpoint for the DNS resolver.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the CreateOrUpdate operation.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the resource. Omit this value to always overwrite the
        /// current resource. Specify the last-seen ETag value to prevent
        /// accidentally overwriting any concurrent changes.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Set to '*' to allow a new resource to be created, but to prevent
        /// updating an existing resource. Other values will be ignored.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OutboundEndpoint>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, string outboundEndpointName, OutboundEndpoint parameters, string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an outbound endpoint for a DNS resolver.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='outboundEndpointName'>
        /// The name of the outbound endpoint for the DNS resolver.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the resource. Omit this value to always overwrite the
        /// current resource. Specify the last-seen ETag value to prevent
        /// accidentally overwriting any concurrent changes.
        /// </param>
        /// <param name='tags'>
        /// Tags for outbound endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OutboundEndpoint>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, string outboundEndpointName, string ifMatch = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an outbound endpoint for a DNS resolver. WARNING: This
        /// operation cannot be undone.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='dnsResolverName'>
        /// The name of the DNS resolver.
        /// </param>
        /// <param name='outboundEndpointName'>
        /// The name of the outbound endpoint for the DNS resolver.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the resource. Omit this value to always overwrite the
        /// current resource. Specify the last-seen ETag value to prevent
        /// accidentally overwriting any concurrent changes.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string dnsResolverName, string outboundEndpointName, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists outbound endpoints for a DNS resolver.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<OutboundEndpoint>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
