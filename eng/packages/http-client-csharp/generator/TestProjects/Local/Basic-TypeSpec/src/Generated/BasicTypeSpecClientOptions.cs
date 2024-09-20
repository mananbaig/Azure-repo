// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;

namespace BasicTypeSpec
{
    /// <summary> Client options for <see cref="BasicTypeSpecClient"/>. </summary>
    public partial class BasicTypeSpecClientOptions : ClientPipelineOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2024_08_16_Preview;

        /// <summary> Initializes a new instance of BasicTypeSpecClientOptions. </summary>
        /// <param name="version"> The service version. </param>
        public BasicTypeSpecClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2024_07_16_Preview => "2024-07-16-preview",
                ServiceVersion.V2024_08_16_Preview => "2024-08-16-preview",
                _ => throw new NotSupportedException()
            };
        }

        internal string Version { get; }

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> V2024_07_16_Preview. </summary>
            V2024_07_16_Preview = 1,
            /// <summary> V2024_08_16_Preview. </summary>
            V2024_08_16_Preview = 2
        }
    }
}
