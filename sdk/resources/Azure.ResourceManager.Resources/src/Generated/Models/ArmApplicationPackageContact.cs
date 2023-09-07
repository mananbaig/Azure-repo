// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The application package contact information. </summary>
    public partial class ArmApplicationPackageContact
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArmApplicationPackageContact"/>. </summary>
        /// <param name="email"> The contact email. </param>
        /// <param name="phone"> The contact phone number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="email"/> or <paramref name="phone"/> is null. </exception>
        internal ArmApplicationPackageContact(string email, string phone)
        {
            Argument.AssertNotNull(email, nameof(email));
            Argument.AssertNotNull(phone, nameof(phone));

            Email = email;
            Phone = phone;
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationPackageContact"/>. </summary>
        /// <param name="contactName"> The contact name. </param>
        /// <param name="email"> The contact email. </param>
        /// <param name="phone"> The contact phone number. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationPackageContact(string contactName, string email, string phone, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContactName = contactName;
            Email = email;
            Phone = phone;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationPackageContact"/> for deserialization. </summary>
        internal ArmApplicationPackageContact()
        {
        }

        /// <summary> The contact name. </summary>
        public string ContactName { get; }
        /// <summary> The contact email. </summary>
        public string Email { get; }
        /// <summary> The contact phone number. </summary>
        public string Phone { get; }
    }
}
