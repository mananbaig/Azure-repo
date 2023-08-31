// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Represents a wrapper around a list of cities or towns. </summary>
    internal partial class PhoneNumberLocalities
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PhoneNumberLocalities"/>. </summary>
        /// <param name="phoneNumberLocalitiesValue"> Represents the underlying list of localities, e.g. cities or town. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PhoneNumberLocalities(IReadOnlyList<PhoneNumberLocality> phoneNumberLocalitiesValue, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            PhoneNumberLocalitiesValue = phoneNumberLocalitiesValue;
            NextLink = nextLink;
            _rawData = rawData;
        }
    }
}
