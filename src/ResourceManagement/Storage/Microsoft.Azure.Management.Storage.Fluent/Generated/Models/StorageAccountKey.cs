// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// An access key for the storage account.
    /// </summary>
    public partial class StorageAccountKey
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountKey class.
        /// </summary>
        public StorageAccountKey() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccountKey class.
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <param name="value">Base 64 encoded value of the key.</param>
        /// <param name="permissions">Permissions for the key. Possible values
        /// include: 'READ', 'FULL'</param>
        public StorageAccountKey(string keyName = default(string), string value = default(string), KeyPermission? permissions = default(KeyPermission?))
        {
            KeyName = keyName;
            Value = value;
            Permissions = permissions;
        }

        /// <summary>
        /// Gets name of the key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; private set; }

        /// <summary>
        /// Gets base 64 encoded value of the key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; private set; }

        /// <summary>
        /// Gets permissions for the key. Possible values include: 'READ',
        /// 'FULL'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "permissions")]
        public KeyPermission? Permissions { get; private set; }

    }
}
