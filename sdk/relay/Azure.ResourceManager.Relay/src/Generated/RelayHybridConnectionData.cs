// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary>
    /// A class representing the RelayHybridConnection data model.
    /// Description of hybrid connection resource.
    /// </summary>
    public partial class RelayHybridConnectionData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RelayHybridConnectionData"/>. </summary>
        public RelayHybridConnectionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RelayHybridConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> The time the hybrid connection was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="listenerCount"> The number of listeners for this hybrid connection. Note that min : 1 and max:25 are supported. </param>
        /// <param name="isClientAuthorizationRequired"> Returns true if client authorization is needed for this hybrid connection; otherwise, false. </param>
        /// <param name="userMetadata"> The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelayHybridConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, int? listenerCount, bool? isClientAuthorizationRequired, string userMetadata, AzureLocation? location, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ListenerCount = listenerCount;
            IsClientAuthorizationRequired = isClientAuthorizationRequired;
            UserMetadata = userMetadata;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time the hybrid connection was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The number of listeners for this hybrid connection. Note that min : 1 and max:25 are supported. </summary>
        public int? ListenerCount { get; }
        /// <summary> Returns true if client authorization is needed for this hybrid connection; otherwise, false. </summary>
        public bool? IsClientAuthorizationRequired { get; set; }
        /// <summary> The usermetadata is a placeholder to store user-defined string data for the hybrid connection endpoint. For example, it can be used to store descriptive data, such as a list of teams and their contact information. Also, user-defined configuration settings can be stored. </summary>
        public string UserMetadata { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
