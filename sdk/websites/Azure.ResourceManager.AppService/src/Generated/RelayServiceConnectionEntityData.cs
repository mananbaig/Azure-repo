// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the RelayServiceConnectionEntity data model. </summary>
    public partial class RelayServiceConnectionEntityData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of RelayServiceConnectionEntityData. </summary>
        public RelayServiceConnectionEntityData()
        {
        }

        /// <summary> Initializes a new instance of RelayServiceConnectionEntityData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="entityName"></param>
        /// <param name="entityConnectionString"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourceConnectionString"></param>
        /// <param name="hostname"></param>
        /// <param name="port"></param>
        /// <param name="biztalkUri"></param>
        internal RelayServiceConnectionEntityData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, string entityName, string entityConnectionString, string resourceType, string resourceConnectionString, string hostname, int? port, string biztalkUri) : base(id, name, type, systemData, kind)
        {
            EntityName = entityName;
            EntityConnectionString = entityConnectionString;
            ResourceType = resourceType;
            ResourceConnectionString = resourceConnectionString;
            Hostname = hostname;
            Port = port;
            BiztalkUri = biztalkUri;
        }

        /// <summary> Gets or sets the entity name. </summary>
        public string EntityName { get; set; }
        /// <summary> Gets or sets the entity connection string. </summary>
        public string EntityConnectionString { get; set; }
        /// <summary> Gets or sets the resource type. </summary>
        public string ResourceType { get; set; }
        /// <summary> Gets or sets the resource connection string. </summary>
        public string ResourceConnectionString { get; set; }
        /// <summary> Gets or sets the hostname. </summary>
        public string Hostname { get; set; }
        /// <summary> Gets or sets the port. </summary>
        public int? Port { get; set; }
        /// <summary> Gets or sets the biztalk uri. </summary>
        public string BiztalkUri { get; set; }
    }
}
