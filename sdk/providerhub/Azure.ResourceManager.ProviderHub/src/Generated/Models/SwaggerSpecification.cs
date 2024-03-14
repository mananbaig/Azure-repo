// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The SwaggerSpecification. </summary>
    public partial class SwaggerSpecification
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

        /// <summary> Initializes a new instance of <see cref="SwaggerSpecification"/>. </summary>
        public SwaggerSpecification()
        {
            ApiVersions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SwaggerSpecification"/>. </summary>
        /// <param name="apiVersions"></param>
        /// <param name="swaggerSpecFolderUri"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SwaggerSpecification(IList<string> apiVersions, Uri swaggerSpecFolderUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiVersions = apiVersions;
            SwaggerSpecFolderUri = swaggerSpecFolderUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the api versions. </summary>
        public IList<string> ApiVersions { get; }
        /// <summary> Gets or sets the swagger spec folder uri. </summary>
        public Uri SwaggerSpecFolderUri { get; set; }
    }
}
