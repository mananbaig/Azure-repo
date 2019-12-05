// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ContainersOperations operations.
    /// </summary>
    public partial interface IContainersOperations
    {
        /// <summary>
        /// Lists all the containers of a storage Account in a Data Box
        /// Edge/Data Box Gateway device.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The storage Account name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse<IPage<Container>>> ListByStorageAccountWithHttpMessagesAsync(string deviceName, string storageAccountName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a container by name.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The Storage Account Name
        /// </param>
        /// <param name='containerName'>
        /// The container Name
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse<Container>> GetWithHttpMessagesAsync(string deviceName, string storageAccountName, string containerName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new container or updates an existing container on the
        /// device.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The Storage Account Name
        /// </param>
        /// <param name='containerName'>
        /// The container name.
        /// </param>
        /// <param name='container'>
        /// The container properties.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse<Container>> CreateOrUpdateWithHttpMessagesAsync(string deviceName, string storageAccountName, string containerName, Container container, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the container on the Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The Storage Account Name
        /// </param>
        /// <param name='containerName'>
        /// The container name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string deviceName, string storageAccountName, string containerName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Refreshes the container metadata with the data from the cloud.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The Storage Account Name
        /// </param>
        /// <param name='containerName'>
        /// The container name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse> RefreshWithHttpMessagesAsync(string deviceName, string storageAccountName, string containerName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new container or updates an existing container on the
        /// device.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The Storage Account Name
        /// </param>
        /// <param name='containerName'>
        /// The container name.
        /// </param>
        /// <param name='container'>
        /// The container properties.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse<Container>> BeginCreateOrUpdateWithHttpMessagesAsync(string deviceName, string storageAccountName, string containerName, Container container, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the container on the Data Box Edge/Data Box Gateway device.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The Storage Account Name
        /// </param>
        /// <param name='containerName'>
        /// The container name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string deviceName, string storageAccountName, string containerName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Refreshes the container metadata with the data from the cloud.
        /// </summary>
        /// <param name='deviceName'>
        /// The device name.
        /// </param>
        /// <param name='storageAccountName'>
        /// The Storage Account Name
        /// </param>
        /// <param name='containerName'>
        /// The container name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
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
        Task<AzureOperationResponse> BeginRefreshWithHttpMessagesAsync(string deviceName, string storageAccountName, string containerName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the containers of a storage Account in a Data Box
        /// Edge/Data Box Gateway device.
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
        Task<AzureOperationResponse<IPage<Container>>> ListByStorageAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
