// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> A phone number. </summary>
    internal partial class PhoneNumberIdentifierModel
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberIdentifierModel"/>. </summary>
        /// <param name="value"> The phone number in E.164 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PhoneNumberIdentifierModel(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberIdentifierModel"/>. </summary>
        /// <param name="value"> The phone number in E.164 format. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhoneNumberIdentifierModel(string value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PhoneNumberIdentifierModel"/> for deserialization. </summary>
        internal PhoneNumberIdentifierModel()
        {
        }

        /// <summary> The phone number in E.164 format. </summary>
        public string Value { get; }
    }
}
