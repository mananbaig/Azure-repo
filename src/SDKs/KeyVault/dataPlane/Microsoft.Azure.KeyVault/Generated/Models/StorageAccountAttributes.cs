// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The storage account management attributes.
    /// </summary>
    public partial class StorageAccountAttributes
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountAttributes class.
        /// </summary>
        public StorageAccountAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountAttributes class.
        /// </summary>
        /// <param name="enabled">the enabled state of the object.</param>
        /// <param name="created">Creation time in UTC.</param>
        /// <param name="updated">Last updated time in UTC.</param>
        /// <param name="recoveryLevel">Reflects the deletion recovery level
        /// currently in effect for storage accounts in the current vault. If
        /// it contains 'Purgeable' the storage account can be permanently
        /// deleted by a privileged user; otherwise, only the system can purge
        /// the storage account, at the end of the retention interval. Possible
        /// values include: 'Purgeable', 'Recoverable+Purgeable',
        /// 'Recoverable', 'Recoverable+ProtectedSubscription'</param>
        public StorageAccountAttributes(bool? enabled = default(bool?), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?), string recoveryLevel = default(string))
        {
            Enabled = enabled;
            Created = created;
            Updated = updated;
            RecoveryLevel = recoveryLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the enabled state of the object.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets creation time in UTC.
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// Gets last updated time in UTC.
        /// </summary>
        [JsonConverter(typeof(UnixTimeJsonConverter))]
        [JsonProperty(PropertyName = "updated")]
        public System.DateTime? Updated { get; private set; }

        /// <summary>
        /// Gets reflects the deletion recovery level currently in effect for
        /// storage accounts in the current vault. If it contains 'Purgeable'
        /// the storage account can be permanently deleted by a privileged
        /// user; otherwise, only the system can purge the storage account, at
        /// the end of the retention interval. Possible values include:
        /// 'Purgeable', 'Recoverable+Purgeable', 'Recoverable',
        /// 'Recoverable+ProtectedSubscription'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryLevel")]
        public string RecoveryLevel { get; private set; }

    }
}
