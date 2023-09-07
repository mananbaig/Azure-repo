// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Shipping address where customer wishes to receive the device. </summary>
    public partial class EdgeOrderShippingAddress
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderShippingAddress"/>. </summary>
        /// <param name="streetAddress1"> Street Address line 1. </param>
        /// <param name="country"> Name of the Country. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streetAddress1"/> or <paramref name="country"/> is null. </exception>
        public EdgeOrderShippingAddress(string streetAddress1, string country)
        {
            Argument.AssertNotNull(streetAddress1, nameof(streetAddress1));
            Argument.AssertNotNull(country, nameof(country));

            StreetAddress1 = streetAddress1;
            Country = country;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderShippingAddress"/>. </summary>
        /// <param name="streetAddress1"> Street Address line 1. </param>
        /// <param name="streetAddress2"> Street Address line 2. </param>
        /// <param name="streetAddress3"> Street Address line 3. </param>
        /// <param name="city"> Name of the City. </param>
        /// <param name="stateOrProvince"> Name of the State or Province. </param>
        /// <param name="country"> Name of the Country. </param>
        /// <param name="postalCode"> Postal code. </param>
        /// <param name="zipExtendedCode"> Extended Zip Code. </param>
        /// <param name="companyName"> Name of the company. </param>
        /// <param name="addressType"> Type of address. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderShippingAddress(string streetAddress1, string streetAddress2, string streetAddress3, string city, string stateOrProvince, string country, string postalCode, string zipExtendedCode, string companyName, EdgeOrderAddressType? addressType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StreetAddress1 = streetAddress1;
            StreetAddress2 = streetAddress2;
            StreetAddress3 = streetAddress3;
            City = city;
            StateOrProvince = stateOrProvince;
            Country = country;
            PostalCode = postalCode;
            ZipExtendedCode = zipExtendedCode;
            CompanyName = companyName;
            AddressType = addressType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderShippingAddress"/> for deserialization. </summary>
        internal EdgeOrderShippingAddress()
        {
        }

        /// <summary> Street Address line 1. </summary>
        public string StreetAddress1 { get; set; }
        /// <summary> Street Address line 2. </summary>
        public string StreetAddress2 { get; set; }
        /// <summary> Street Address line 3. </summary>
        public string StreetAddress3 { get; set; }
        /// <summary> Name of the City. </summary>
        public string City { get; set; }
        /// <summary> Name of the State or Province. </summary>
        public string StateOrProvince { get; set; }
        /// <summary> Name of the Country. </summary>
        public string Country { get; set; }
        /// <summary> Postal code. </summary>
        public string PostalCode { get; set; }
        /// <summary> Extended Zip Code. </summary>
        public string ZipExtendedCode { get; set; }
        /// <summary> Name of the company. </summary>
        public string CompanyName { get; set; }
        /// <summary> Type of address. </summary>
        public EdgeOrderAddressType? AddressType { get; set; }
    }
}
