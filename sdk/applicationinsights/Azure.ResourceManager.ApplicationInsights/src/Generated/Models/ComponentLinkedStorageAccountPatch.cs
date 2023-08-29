// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component linked storage accounts patch. </summary>
    public partial class ComponentLinkedStorageAccountPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ComponentLinkedStorageAccountPatch"/>. </summary>
        public ComponentLinkedStorageAccountPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComponentLinkedStorageAccountPatch"/>. </summary>
        /// <param name="linkedStorageAccount"> Linked storage account resource ID. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentLinkedStorageAccountPatch(string linkedStorageAccount, Dictionary<string, BinaryData> rawData)
        {
            LinkedStorageAccount = linkedStorageAccount;
            _rawData = rawData;
        }

        /// <summary> Linked storage account resource ID. </summary>
        public string LinkedStorageAccount { get; set; }
    }
}
