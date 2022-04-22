// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The update operation for a Video Analyzer account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VideoAnalyzerUpdate
    {
        /// <summary>
        /// Initializes a new instance of the VideoAnalyzerUpdate class.
        /// </summary>
        public VideoAnalyzerUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoAnalyzerUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        /// <param name="storageAccounts">The storage accounts for this
        /// resource.</param>
        /// <param name="endpoints">The endpoints associated with this
        /// resource.</param>
        /// <param name="encryption">The account encryption properties.</param>
        /// <param name="iotHubs">The IoT Hubs for this resource.</param>
        /// <param name="publicNetworkAccess">Whether or not public network
        /// access is allowed for resources under the Video Analyzer account.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="networkAccessControl">Network access control for Video
        /// Analyzer.</param>
        /// <param name="provisioningState">Provisioning state of the Video
        /// Analyzer account. Possible values include: 'Failed', 'InProgress',
        /// 'Succeeded'</param>
        /// <param name="privateEndpointConnections">Private Endpoint
        /// Connections created under Video Analyzer account.</param>
        /// <param name="identity">The identities associated to the Video
        /// Analyzer resource.</param>
        public VideoAnalyzerUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), IList<StorageAccount> storageAccounts = default(IList<StorageAccount>), IList<Endpoint> endpoints = default(IList<Endpoint>), AccountEncryption encryption = default(AccountEncryption), IList<IotHub> iotHubs = default(IList<IotHub>), PublicNetworkAccess? publicNetworkAccess = default(PublicNetworkAccess?), NetworkAccessControl networkAccessControl = default(NetworkAccessControl), ProvisioningState provisioningState = default(ProvisioningState), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), VideoAnalyzerIdentity identity = default(VideoAnalyzerIdentity))
        {
            Tags = tags;
            StorageAccounts = storageAccounts;
            Endpoints = endpoints;
            Encryption = encryption;
            IotHubs = iotHubs;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkAccessControl = networkAccessControl;
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the storage accounts for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<StorageAccount> StorageAccounts { get; set; }

        /// <summary>
        /// Gets the endpoints associated with this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoints")]
        public IList<Endpoint> Endpoints { get; private set; }

        /// <summary>
        /// Gets or sets the account encryption properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public AccountEncryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets the IoT Hubs for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.iotHubs")]
        public IList<IotHub> IotHubs { get; set; }

        /// <summary>
        /// Gets or sets whether or not public network access is allowed for
        /// resources under the Video Analyzer account. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets network access control for Video Analyzer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAccessControl")]
        public NetworkAccessControl NetworkAccessControl { get; set; }

        /// <summary>
        /// Gets provisioning state of the Video Analyzer account. Possible
        /// values include: 'Failed', 'InProgress', 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets private Endpoint Connections created under Video Analyzer
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets the identities associated to the Video Analyzer
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VideoAnalyzerIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccounts != null)
            {
                foreach (var element in StorageAccounts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (IotHubs != null)
            {
                foreach (var element1 in IotHubs)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (PrivateEndpointConnections != null)
            {
                foreach (var element2 in PrivateEndpointConnections)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
