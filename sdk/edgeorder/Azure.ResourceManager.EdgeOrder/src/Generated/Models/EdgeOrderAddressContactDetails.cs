// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Contact Details. </summary>
    public partial class EdgeOrderAddressContactDetails
    {
        /// <summary> Initializes a new instance of EdgeOrderAddressContactDetails. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <param name="emailList"> List of Email-ids to be notified about job progress. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contactName"/>, <paramref name="phone"/> or <paramref name="emailList"/> is null. </exception>
        public EdgeOrderAddressContactDetails(string contactName, string phone, IEnumerable<string> emailList)
        {
            if (contactName == null)
            {
                throw new ArgumentNullException(nameof(contactName));
            }
            if (phone == null)
            {
                throw new ArgumentNullException(nameof(phone));
            }
            if (emailList == null)
            {
                throw new ArgumentNullException(nameof(emailList));
            }

            ContactName = contactName;
            Phone = phone;
            EmailList = emailList.ToList();
        }

        /// <summary> Initializes a new instance of EdgeOrderAddressContactDetails. </summary>
        /// <param name="contactName"> Contact name of the person. </param>
        /// <param name="phone"> Phone number of the contact person. </param>
        /// <param name="phoneExtension"> Phone extension number of the contact person. </param>
        /// <param name="mobile"> Mobile number of the contact person. </param>
        /// <param name="emailList"> List of Email-ids to be notified about job progress. </param>
        internal EdgeOrderAddressContactDetails(string contactName, string phone, string phoneExtension, string mobile, IList<string> emailList)
        {
            ContactName = contactName;
            Phone = phone;
            PhoneExtension = phoneExtension;
            Mobile = mobile;
            EmailList = emailList;
        }

        /// <summary> Contact name of the person. </summary>
        public string ContactName { get; set; }
        /// <summary> Phone number of the contact person. </summary>
        public string Phone { get; set; }
        /// <summary> Phone extension number of the contact person. </summary>
        public string PhoneExtension { get; set; }
        /// <summary> Mobile number of the contact person. </summary>
        public string Mobile { get; set; }
        /// <summary> List of Email-ids to be notified about job progress. </summary>
        public IList<string> EmailList { get; }
    }
}
