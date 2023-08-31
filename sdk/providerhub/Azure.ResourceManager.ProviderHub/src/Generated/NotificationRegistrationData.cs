// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A class representing the NotificationRegistration data model.
    /// The notification registration definition.
    /// </summary>
    public partial class NotificationRegistrationData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationRegistrationData"/>. </summary>
        public NotificationRegistrationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationRegistrationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationRegistrationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NotificationRegistrationProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the properties. </summary>
        public NotificationRegistrationProperties Properties { get; set; }
    }
}
