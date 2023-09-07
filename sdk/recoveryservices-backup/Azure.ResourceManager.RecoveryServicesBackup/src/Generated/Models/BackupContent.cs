// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for backup request. Workload-specific backup requests are derived from this class.
    /// Please note <see cref="BackupContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FileShareBackupContent"/>, <see cref="WorkloadBackupContent"/> and <see cref="IaasVmBackupContent"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownBackupRequest))]
    public abstract partial class BackupContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupContent"/>. </summary>
        protected BackupContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupContent(string objectType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ObjectType = objectType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </summary>
        internal string ObjectType { get; set; }
    }
}
