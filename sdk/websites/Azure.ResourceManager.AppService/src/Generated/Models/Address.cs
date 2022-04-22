// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Address information for domain registration. </summary>
    public partial class Address
    {
        /// <summary> Initializes a new instance of Address. </summary>
        /// <param name="address1"> First line of an Address. </param>
        /// <param name="city"> The city for the address. </param>
        /// <param name="country"> The country for the address. </param>
        /// <param name="postalCode"> The postal code for the address. </param>
        /// <param name="state"> The state or province for the address. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="address1"/>, <paramref name="city"/>, <paramref name="country"/>, <paramref name="postalCode"/>, or <paramref name="state"/> is null. </exception>
        public Address(string address1, string city, string country, string postalCode, string state)
        {
            if (address1 == null)
            {
                throw new ArgumentNullException(nameof(address1));
            }
            if (city == null)
            {
                throw new ArgumentNullException(nameof(city));
            }
            if (country == null)
            {
                throw new ArgumentNullException(nameof(country));
            }
            if (postalCode == null)
            {
                throw new ArgumentNullException(nameof(postalCode));
            }
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            Address1 = address1;
            City = city;
            Country = country;
            PostalCode = postalCode;
            State = state;
        }

        /// <summary> Initializes a new instance of Address. </summary>
        /// <param name="address1"> First line of an Address. </param>
        /// <param name="address2"> The second line of the Address. Optional. </param>
        /// <param name="city"> The city for the address. </param>
        /// <param name="country"> The country for the address. </param>
        /// <param name="postalCode"> The postal code for the address. </param>
        /// <param name="state"> The state or province for the address. </param>
        internal Address(string address1, string address2, string city, string country, string postalCode, string state)
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            Country = country;
            PostalCode = postalCode;
            State = state;
        }

        /// <summary> First line of an Address. </summary>
        public string Address1 { get; set; }
        /// <summary> The second line of the Address. Optional. </summary>
        public string Address2 { get; set; }
        /// <summary> The city for the address. </summary>
        public string City { get; set; }
        /// <summary> The country for the address. </summary>
        public string Country { get; set; }
        /// <summary> The postal code for the address. </summary>
        public string PostalCode { get; set; }
        /// <summary> The state or province for the address. </summary>
        public string State { get; set; }
    }
}
