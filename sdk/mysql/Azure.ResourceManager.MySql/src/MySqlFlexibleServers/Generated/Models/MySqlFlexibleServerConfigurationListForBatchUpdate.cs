// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A list of server configurations to update. </summary>
    public partial class MySqlFlexibleServerConfigurationListForBatchUpdate
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurationListForBatchUpdate"/>. </summary>
        public MySqlFlexibleServerConfigurationListForBatchUpdate()
        {
            Values = new ChangeTrackingList<MySqlFlexibleServerConfigurationForBatchUpdate>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurationListForBatchUpdate"/>. </summary>
        /// <param name="values"> The list of server configurations. </param>
        /// <param name="resetAllToDefault"> Whether to reset all server parameters to default. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerConfigurationListForBatchUpdate(IList<MySqlFlexibleServerConfigurationForBatchUpdate> values, MySqlFlexibleServerConfigurationResetAllToDefault? resetAllToDefault, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Values = values;
            ResetAllToDefault = resetAllToDefault;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of server configurations. </summary>
        public IList<MySqlFlexibleServerConfigurationForBatchUpdate> Values { get; }
        /// <summary> Whether to reset all server parameters to default. </summary>
        public MySqlFlexibleServerConfigurationResetAllToDefault? ResetAllToDefault { get; set; }
    }
}
