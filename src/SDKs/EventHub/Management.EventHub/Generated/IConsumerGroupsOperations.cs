// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ConsumerGroupsOperations operations.
    /// </summary>
    public partial interface IConsumerGroupsOperations
    {
        /// <summary>
        /// Creates or updates an Event Hubs consumer group as a nested
        /// resource within a Namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create or update a consumer group resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConsumerGroup>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, ConsumerGroup parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a consumer group from the specified Event Hub and resource
        /// group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a description for the specified consumer group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConsumerGroup>> GetWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is
        /// returned if no consumer group exists in the Namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ConsumerGroup>>> ListByEventHubWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is
        /// returned if no consumer group exists in the Namespace.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ConsumerGroup>>> ListByEventHubNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
