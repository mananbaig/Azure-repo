// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> AML file system HSM settings. </summary>
    public partial class AmlFileSystemHsmSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemHsmSettings"/>. </summary>
        /// <param name="container"> Resource ID of storage container used for hydrating the namespace and archiving from the namespace. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <param name="loggingContainer"> Resource ID of storage container used for logging events and errors.  Must be a separate container in the same storage account as the hydration and archive container. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="container"/> or <paramref name="loggingContainer"/> is null. </exception>
        public AmlFileSystemHsmSettings(string container, string loggingContainer)
        {
            Argument.AssertNotNull(container, nameof(container));
            Argument.AssertNotNull(loggingContainer, nameof(loggingContainer));

            Container = container;
            LoggingContainer = loggingContainer;
        }

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemHsmSettings"/>. </summary>
        /// <param name="container"> Resource ID of storage container used for hydrating the namespace and archiving from the namespace. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <param name="loggingContainer"> Resource ID of storage container used for logging events and errors.  Must be a separate container in the same storage account as the hydration and archive container. The resource provider must have permission to create SAS tokens on the storage account. </param>
        /// <param name="importPrefix"> Only blobs in the non-logging container that start with this path/prefix get hydrated into the cluster namespace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AmlFileSystemHsmSettings(string container, string loggingContainer, string importPrefix, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Container = container;
            LoggingContainer = loggingContainer;
            ImportPrefix = importPrefix;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemHsmSettings"/> for deserialization. </summary>
        internal AmlFileSystemHsmSettings()
        {
        }

        /// <summary> Resource ID of storage container used for hydrating the namespace and archiving from the namespace. The resource provider must have permission to create SAS tokens on the storage account. </summary>
        public string Container { get; set; }
        /// <summary> Resource ID of storage container used for logging events and errors.  Must be a separate container in the same storage account as the hydration and archive container. The resource provider must have permission to create SAS tokens on the storage account. </summary>
        public string LoggingContainer { get; set; }
        /// <summary> Only blobs in the non-logging container that start with this path/prefix get hydrated into the cluster namespace. </summary>
        public string ImportPrefix { get; set; }
    }
}
