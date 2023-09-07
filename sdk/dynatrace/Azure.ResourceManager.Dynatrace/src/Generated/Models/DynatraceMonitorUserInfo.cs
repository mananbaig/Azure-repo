// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> User info. </summary>
    public partial class DynatraceMonitorUserInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorUserInfo"/>. </summary>
        public DynatraceMonitorUserInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitorUserInfo"/>. </summary>
        /// <param name="firstName"> First Name of the user. </param>
        /// <param name="lastName"> Last Name of the user. </param>
        /// <param name="emailAddress"> Email of the user used by Dynatrace for contacting them if needed. </param>
        /// <param name="phoneNumber"> Phone number of the user used by Dynatrace for contacting them if needed. </param>
        /// <param name="country"> Country of the user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceMonitorUserInfo(string firstName, string lastName, string emailAddress, string phoneNumber, string country, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Country = country;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> First Name of the user. </summary>
        public string FirstName { get; set; }
        /// <summary> Last Name of the user. </summary>
        public string LastName { get; set; }
        /// <summary> Email of the user used by Dynatrace for contacting them if needed. </summary>
        public string EmailAddress { get; set; }
        /// <summary> Phone number of the user used by Dynatrace for contacting them if needed. </summary>
        public string PhoneNumber { get; set; }
        /// <summary> Country of the user. </summary>
        public string Country { get; set; }
    }
}
