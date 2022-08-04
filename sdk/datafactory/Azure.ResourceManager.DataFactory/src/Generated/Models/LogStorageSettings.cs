// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> (Deprecated. Please use LogSettings) Log storage settings. </summary>
    public partial class LogStorageSettings
    {
        /// <summary> Initializes a new instance of LogStorageSettings. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public LogStorageSettings(FactoryLinkedServiceReference linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            LinkedServiceName = linkedServiceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of LogStorageSettings. </summary>
        /// <param name="linkedServiceName"> Log storage linked service reference. </param>
        /// <param name="path"> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </param>
        /// <param name="logLevel"> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </param>
        /// <param name="enableReliableLogging"> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal LogStorageSettings(FactoryLinkedServiceReference linkedServiceName, BinaryData path, BinaryData logLevel, BinaryData enableReliableLogging, IDictionary<string, BinaryData> additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            LogLevel = logLevel;
            EnableReliableLogging = enableReliableLogging;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Log storage linked service reference. </summary>
        public FactoryLinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The path to storage for storing detailed logs of activity execution. Type: string (or Expression with resultType string). </summary>
        public BinaryData Path { get; set; }
        /// <summary> Gets or sets the log level, support: Info, Warning. Type: string (or Expression with resultType string). </summary>
        public BinaryData LogLevel { get; set; }
        /// <summary> Specifies whether to enable reliable logging. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData EnableReliableLogging { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
