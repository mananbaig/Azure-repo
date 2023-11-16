// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The response to a list Active Directory Administrators request. </summary>
    internal partial class PostgreSqlServerAdministratorListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerAdministratorListResult"/>. </summary>
        internal PostgreSqlServerAdministratorListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlServerAdministratorData>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerAdministratorListResult"/>. </summary>
        /// <param name="value"> The list of server Active Directory Administrators for the server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlServerAdministratorListResult(IReadOnlyList<PostgreSqlServerAdministratorData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of server Active Directory Administrators for the server. </summary>
        public IReadOnlyList<PostgreSqlServerAdministratorData> Value { get; }
    }
}
