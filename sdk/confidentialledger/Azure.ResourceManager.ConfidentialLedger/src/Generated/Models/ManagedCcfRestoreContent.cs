// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Object representing Restore properties of Managed CCF Resource. </summary>
    public partial class ManagedCcfRestoreContent
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

        /// <summary> Initializes a new instance of <see cref="ManagedCcfRestoreContent"/>. </summary>
        /// <param name="fileShareName"> Fileshare where the managed CCF resource backup is stored. </param>
        /// <param name="restoreRegion"> The region the managed CCF resource is being restored to. </param>
        /// <param name="uri"> SAS URI used to access the backup Fileshare. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileShareName"/>, <paramref name="restoreRegion"/> or <paramref name="uri"/> is null. </exception>
        public ManagedCcfRestoreContent(string fileShareName, string restoreRegion, Uri uri)
        {
            Argument.AssertNotNull(fileShareName, nameof(fileShareName));
            Argument.AssertNotNull(restoreRegion, nameof(restoreRegion));
            Argument.AssertNotNull(uri, nameof(uri));

            FileShareName = fileShareName;
            RestoreRegion = restoreRegion;
            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedCcfRestoreContent"/>. </summary>
        /// <param name="fileShareName"> Fileshare where the managed CCF resource backup is stored. </param>
        /// <param name="restoreRegion"> The region the managed CCF resource is being restored to. </param>
        /// <param name="uri"> SAS URI used to access the backup Fileshare. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedCcfRestoreContent(string fileShareName, string restoreRegion, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileShareName = fileShareName;
            RestoreRegion = restoreRegion;
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedCcfRestoreContent"/> for deserialization. </summary>
        internal ManagedCcfRestoreContent()
        {
        }

        /// <summary> Fileshare where the managed CCF resource backup is stored. </summary>
        public string FileShareName { get; }
        /// <summary> The region the managed CCF resource is being restored to. </summary>
        public string RestoreRegion { get; }
        /// <summary> SAS URI used to access the backup Fileshare. </summary>
        public Uri Uri { get; }
    }
}
