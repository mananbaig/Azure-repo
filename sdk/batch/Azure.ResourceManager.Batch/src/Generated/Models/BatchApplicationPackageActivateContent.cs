// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Parameters for an activating an application package. </summary>
    public partial class BatchApplicationPackageActivateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageActivateContent"/>. </summary>
        /// <param name="format"> The format of the application package binary file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="format"/> is null. </exception>
        public BatchApplicationPackageActivateContent(string format)
        {
            Argument.AssertNotNull(format, nameof(format));

            Format = format;
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageActivateContent"/>. </summary>
        /// <param name="format"> The format of the application package binary file. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchApplicationPackageActivateContent(string format, Dictionary<string, BinaryData> rawData)
        {
            Format = format;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageActivateContent"/> for deserialization. </summary>
        internal BatchApplicationPackageActivateContent()
        {
        }

        /// <summary> The format of the application package binary file. </summary>
        public string Format { get; }
    }
}
