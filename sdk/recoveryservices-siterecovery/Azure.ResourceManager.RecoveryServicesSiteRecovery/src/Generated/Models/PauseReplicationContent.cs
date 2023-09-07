// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Pause replication input. </summary>
    public partial class PauseReplicationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PauseReplicationContent"/>. </summary>
        /// <param name="properties"> Pause replication input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public PauseReplicationContent(PauseReplicationProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="PauseReplicationContent"/>. </summary>
        /// <param name="properties"> Pause replication input properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PauseReplicationContent(PauseReplicationProperties properties, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PauseReplicationContent"/> for deserialization. </summary>
        internal PauseReplicationContent()
        {
        }

        /// <summary> Pause replication input properties. </summary>
        internal PauseReplicationProperties Properties { get; }
        /// <summary> The class type. </summary>
        public string PauseReplicationInstanceType
        {
            get => Properties?.InstanceType;
        }
    }
}
