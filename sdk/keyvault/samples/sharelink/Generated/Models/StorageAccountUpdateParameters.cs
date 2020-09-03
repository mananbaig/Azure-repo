// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The storage account update parameters. </summary>
    internal partial class StorageAccountUpdateParameters
    {
        /// <summary> Initializes a new instance of StorageAccountUpdateParameters. </summary>
        public StorageAccountUpdateParameters()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The current active storage account key name. </summary>
        public string ActiveKeyName { get; set; }
        /// <summary> whether keyvault should manage the storage account for the user. </summary>
        public bool? AutoRegenerateKey { get; set; }
        /// <summary> The key regeneration time duration specified in ISO-8601 format. </summary>
        public string RegenerationPeriod { get; set; }
        /// <summary> The attributes of the storage account. </summary>
        public StorageAccountAttributes StorageAccountAttributes { get; set; }
        /// <summary> Application specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
