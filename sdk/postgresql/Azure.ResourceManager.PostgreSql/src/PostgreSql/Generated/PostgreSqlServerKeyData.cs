// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing the PostgreSqlServerKey data model.
    /// A PostgreSQL Server key.
    /// </summary>
    public partial class PostgreSqlServerKeyData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerKeyData"/>. </summary>
        public PostgreSqlServerKeyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerKeyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of encryption protector used to protect the key. </param>
        /// <param name="serverKeyType"> The key type like 'AzureKeyVault'. </param>
        /// <param name="uri"> The URI of the key. </param>
        /// <param name="createdOn"> The key creation date. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlServerKeyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, PostgreSqlServerKeyType? serverKeyType, Uri uri, DateTimeOffset? createdOn, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ServerKeyType = serverKeyType;
            Uri = uri;
            CreatedOn = createdOn;
            _rawData = rawData;
        }

        /// <summary> Kind of encryption protector used to protect the key. </summary>
        public string Kind { get; }
        /// <summary> The key type like 'AzureKeyVault'. </summary>
        public PostgreSqlServerKeyType? ServerKeyType { get; set; }
        /// <summary> The URI of the key. </summary>
        public Uri Uri { get; set; }
        /// <summary> The key creation date. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
