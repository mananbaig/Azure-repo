// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// FileSharesOperations operations.
    /// </summary>
    public partial interface IFileSharesOperations
    {
        /// <summary>
        /// Lists all shares.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='maxpagesize'>
        /// Optional. Specified maximum number of shares that can be included
        /// in the list.
        /// </param>
        /// <param name='filter'>
        /// Optional. When specified, only share names starting with the filter
        /// will be listed.
        /// </param>
        /// <param name='expand'>
        /// Optional, used to expand the properties within share's properties.
        /// Possible values include: 'deleted', 'snapshots'
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
        Task<AzureOperationResponse<IPage<FileShareItem>>> ListWithHttpMessagesAsync(string resourceGroupName, string accountName, string maxpagesize = default(string), string filter = default(string), ListSharesExpand? expand = default(ListSharesExpand?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new share under the specified account as described by
        /// request body. The share resource includes metadata and properties
        /// for that share. It does not include a list of the files contained
        /// by the share.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='fileShare'>
        /// Properties of the file share to create.
        /// </param>
        /// <param name='expand'>
        /// Optional, used to create a snapshot. Possible values include:
        /// 'snapshots'
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
        Task<AzureOperationResponse<FileShare>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, FileShare fileShare, PutSharesExpand? expand = default(PutSharesExpand?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates share properties as specified in request body. Properties
        /// not mentioned in the request will not be changed. Update fails if
        /// the specified share does not already exist.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='fileShare'>
        /// Properties to update for the file share.
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
        Task<AzureOperationResponse<FileShare>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, FileShare fileShare, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets properties of a specified share.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='expand'>
        /// Optional, used to expand the properties within share's properties.
        /// Possible values include: 'stats'
        /// </param>
        /// <param name='xMsSnapshot'>
        /// Optional, used to retrieve properties of a snapshot.
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
        Task<AzureOperationResponse<FileShare>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, GetShareExpand? expand = default(GetShareExpand?), string xMsSnapshot = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes specified share under its account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='xMsSnapshot'>
        /// Optional, used to delete a snapshot.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string xMsSnapshot = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restore a file share within a valid retention days if share soft
        /// delete is enabled
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription. The
        /// name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters in
        /// length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='shareName'>
        /// The name of the file share within the specified storage account.
        /// File share names must be between 3 and 63 characters in length and
        /// use numbers, lower-case letters and dash (-) only. Every dash (-)
        /// character must be immediately preceded and followed by a letter or
        /// number.
        /// </param>
        /// <param name='deletedShareName'>
        /// Required. Identify the name of the deleted share that will be
        /// restored.
        /// </param>
        /// <param name='deletedShareVersion'>
        /// Required. Identify the version of the deleted share that will be
        /// restored.
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
        Task<AzureOperationResponse> RestoreWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string deletedShareName, string deletedShareVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all shares.
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
        Task<AzureOperationResponse<IPage<FileShareItem>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
