// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Parameters for a Redis Enterprise export operation. </summary>
    public partial class ExportRedisEnterpriseDatabaseContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExportRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="sasUri"> SAS URI for the target directory to export to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUri"/> is null. </exception>
        public ExportRedisEnterpriseDatabaseContent(Uri sasUri)
        {
            Argument.AssertNotNull(sasUri, nameof(sasUri));

            SasUri = sasUri;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="sasUri"> SAS URI for the target directory to export to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportRedisEnterpriseDatabaseContent(Uri sasUri, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SasUri = sasUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRedisEnterpriseDatabaseContent"/> for deserialization. </summary>
        internal ExportRedisEnterpriseDatabaseContent()
        {
        }

        /// <summary> SAS URI for the target directory to export to. </summary>
        public Uri SasUri { get; }
    }
}
