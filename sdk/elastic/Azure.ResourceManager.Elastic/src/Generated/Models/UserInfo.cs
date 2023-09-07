// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> User Information to be passed to partners. </summary>
    public partial class UserInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UserInfo"/>. </summary>
        public UserInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UserInfo"/>. </summary>
        /// <param name="firstName"> First name of the user. </param>
        /// <param name="lastName"> Last name of the user. </param>
        /// <param name="companyName"> Company name of the user. </param>
        /// <param name="emailAddress"> Email of the user used by Elastic for contacting them if needed. </param>
        /// <param name="companyInfo"> Company information of the user to be passed to partners. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserInfo(string firstName, string lastName, string companyName, string emailAddress, CompanyInfo companyInfo, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            EmailAddress = emailAddress;
            CompanyInfo = companyInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> First name of the user. </summary>
        public string FirstName { get; set; }
        /// <summary> Last name of the user. </summary>
        public string LastName { get; set; }
        /// <summary> Company name of the user. </summary>
        public string CompanyName { get; set; }
        /// <summary> Email of the user used by Elastic for contacting them if needed. </summary>
        public string EmailAddress { get; set; }
        /// <summary> Company information of the user to be passed to partners. </summary>
        public CompanyInfo CompanyInfo { get; set; }
    }
}
