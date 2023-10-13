// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Qumulo;

namespace Azure.ResourceManager.Qumulo.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class QumuloResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="QumuloResourceGroupMockingExtension"/> class for mocking. </summary>
        protected QumuloResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="QumuloResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal QumuloResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of QumuloFileSystemResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of QumuloFileSystemResources and their operations over a QumuloFileSystemResource. </returns>
        public virtual QumuloFileSystemResourceCollection GetQumuloFileSystemResources()
        {
            return GetCachedClient(client => new QumuloFileSystemResourceCollection(client, Id));
        }

        /// <summary>
        /// Get a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<QumuloFileSystemResource>> GetQumuloFileSystemResourceAsync(string fileSystemName, CancellationToken cancellationToken = default)
        {
            return await GetQumuloFileSystemResources().GetAsync(fileSystemName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a FileSystemResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Qumulo.Storage/fileSystems/{fileSystemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileSystemName"> Name of the File System resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileSystemName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileSystemName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<QumuloFileSystemResource> GetQumuloFileSystemResource(string fileSystemName, CancellationToken cancellationToken = default)
        {
            return GetQumuloFileSystemResources().Get(fileSystemName, cancellationToken);
        }
    }
}
