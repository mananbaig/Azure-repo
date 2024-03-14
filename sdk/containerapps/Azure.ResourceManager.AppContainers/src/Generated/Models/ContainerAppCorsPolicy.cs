// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Cross-Origin-Resource-Sharing policy. </summary>
    public partial class ContainerAppCorsPolicy
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppCorsPolicy"/>. </summary>
        /// <param name="allowedOrigins"> Specifies the content for the access-control-allow-origins header. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowedOrigins"/> is null. </exception>
        public ContainerAppCorsPolicy(IEnumerable<string> allowedOrigins)
        {
            Argument.AssertNotNull(allowedOrigins, nameof(allowedOrigins));

            AllowedOrigins = allowedOrigins.ToList();
            AllowedMethods = new ChangeTrackingList<string>();
            AllowedHeaders = new ChangeTrackingList<string>();
            ExposeHeaders = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCorsPolicy"/>. </summary>
        /// <param name="allowedOrigins"> Specifies the content for the access-control-allow-origins header. </param>
        /// <param name="allowedMethods"> Specifies the content for the access-control-allow-methods header. </param>
        /// <param name="allowedHeaders"> Specifies the content for the access-control-allow-headers header. </param>
        /// <param name="exposeHeaders"> Specifies the content for the access-control-expose-headers header. </param>
        /// <param name="maxAge"> Specifies the content for the access-control-max-age header. </param>
        /// <param name="allowCredentials"> Specifies whether the resource allows credentials. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCorsPolicy(IList<string> allowedOrigins, IList<string> allowedMethods, IList<string> allowedHeaders, IList<string> exposeHeaders, int? maxAge, bool? allowCredentials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            AllowedHeaders = allowedHeaders;
            ExposeHeaders = exposeHeaders;
            MaxAge = maxAge;
            AllowCredentials = allowCredentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCorsPolicy"/> for deserialization. </summary>
        internal ContainerAppCorsPolicy()
        {
        }

        /// <summary> Specifies the content for the access-control-allow-origins header. </summary>
        public IList<string> AllowedOrigins { get; }
        /// <summary> Specifies the content for the access-control-allow-methods header. </summary>
        public IList<string> AllowedMethods { get; }
        /// <summary> Specifies the content for the access-control-allow-headers header. </summary>
        public IList<string> AllowedHeaders { get; }
        /// <summary> Specifies the content for the access-control-expose-headers header. </summary>
        public IList<string> ExposeHeaders { get; }
        /// <summary> Specifies the content for the access-control-max-age header. </summary>
        public int? MaxAge { get; set; }
        /// <summary> Specifies whether the resource allows credentials. </summary>
        public bool? AllowCredentials { get; set; }
    }
}
