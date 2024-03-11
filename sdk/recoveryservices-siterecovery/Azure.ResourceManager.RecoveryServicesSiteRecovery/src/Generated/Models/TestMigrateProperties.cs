// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Test migrate input properties. </summary>
    public partial class TestMigrateProperties
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

        /// <summary> Initializes a new instance of <see cref="TestMigrateProperties"/>. </summary>
        /// <param name="providerSpecificDetails">
        /// The provider specific details.
        /// Please note <see cref="TestMigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtTestMigrateContent"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerSpecificDetails"/> is null. </exception>
        public TestMigrateProperties(TestMigrateProviderSpecificContent providerSpecificDetails)
        {
            Argument.AssertNotNull(providerSpecificDetails, nameof(providerSpecificDetails));

            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary> Initializes a new instance of <see cref="TestMigrateProperties"/>. </summary>
        /// <param name="providerSpecificDetails">
        /// The provider specific details.
        /// Please note <see cref="TestMigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtTestMigrateContent"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TestMigrateProperties(TestMigrateProviderSpecificContent providerSpecificDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProviderSpecificDetails = providerSpecificDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TestMigrateProperties"/> for deserialization. </summary>
        internal TestMigrateProperties()
        {
        }

        /// <summary>
        /// The provider specific details.
        /// Please note <see cref="TestMigrateProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VMwareCbtTestMigrateContent"/>.
        /// </summary>
        public TestMigrateProviderSpecificContent ProviderSpecificDetails { get; }
    }
}
