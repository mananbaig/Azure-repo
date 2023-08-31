// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Big data pool reference type. </summary>
    public partial class BigDataPoolParametrizationReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BigDataPoolParametrizationReference"/>. </summary>
        /// <param name="referenceType"> Big data pool reference type. </param>
        /// <param name="referenceName"> Reference big data pool name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public BigDataPoolParametrizationReference(BigDataPoolReferenceType referenceType, DataFactoryElement<string> referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            ReferenceType = referenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="BigDataPoolParametrizationReference"/>. </summary>
        /// <param name="referenceType"> Big data pool reference type. </param>
        /// <param name="referenceName"> Reference big data pool name. Type: string (or Expression with resultType string). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BigDataPoolParametrizationReference(BigDataPoolReferenceType referenceType, DataFactoryElement<string> referenceName, Dictionary<string, BinaryData> rawData)
        {
            ReferenceType = referenceType;
            ReferenceName = referenceName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BigDataPoolParametrizationReference"/> for deserialization. </summary>
        internal BigDataPoolParametrizationReference()
        {
        }

        /// <summary> Big data pool reference type. </summary>
        public BigDataPoolReferenceType ReferenceType { get; set; }
        /// <summary> Reference big data pool name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ReferenceName { get; set; }
    }
}
