// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Options for app content migration. </summary>
    public partial class StorageMigrationContent : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageMigrationContent"/>. </summary>
        public StorageMigrationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageMigrationContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="azurefilesConnectionString"> AzureFiles connection string. </param>
        /// <param name="azurefilesShare"> AzureFiles share. </param>
        /// <param name="switchSiteAfterMigration"> &lt;code&gt;true&lt;/code&gt;if the app should be switched over; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="blockWriteAccessToSite"> &lt;code&gt;true&lt;/code&gt; if the app should be read only during copy operation; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageMigrationContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string azurefilesConnectionString, string azurefilesShare, bool? switchSiteAfterMigration, bool? blockWriteAccessToSite, string kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AzurefilesConnectionString = azurefilesConnectionString;
            AzurefilesShare = azurefilesShare;
            SwitchSiteAfterMigration = switchSiteAfterMigration;
            BlockWriteAccessToSite = blockWriteAccessToSite;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> AzureFiles connection string. </summary>
        public string AzurefilesConnectionString { get; set; }
        /// <summary> AzureFiles share. </summary>
        public string AzurefilesShare { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt;if the app should be switched over; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? SwitchSiteAfterMigration { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the app should be read only during copy operation; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? BlockWriteAccessToSite { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
