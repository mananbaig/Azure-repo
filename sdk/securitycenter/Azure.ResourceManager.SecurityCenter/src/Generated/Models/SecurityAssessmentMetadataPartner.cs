// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describes the partner that created the assessment. </summary>
    public partial class SecurityAssessmentMetadataPartner
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentMetadataPartner"/>. </summary>
        /// <param name="partnerName"> Name of the company of the partner. </param>
        /// <param name="secret"> Secret to authenticate the partner and verify it created the assessment - write only. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> or <paramref name="secret"/> is null. </exception>
        public SecurityAssessmentMetadataPartner(string partnerName, string secret)
        {
            Argument.AssertNotNull(partnerName, nameof(partnerName));
            Argument.AssertNotNull(secret, nameof(secret));

            PartnerName = partnerName;
            Secret = secret;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentMetadataPartner"/>. </summary>
        /// <param name="partnerName"> Name of the company of the partner. </param>
        /// <param name="productName"> Name of the product of the partner that created the assessment. </param>
        /// <param name="secret"> Secret to authenticate the partner and verify it created the assessment - write only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAssessmentMetadataPartner(string partnerName, string productName, string secret, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PartnerName = partnerName;
            ProductName = productName;
            Secret = secret;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentMetadataPartner"/> for deserialization. </summary>
        internal SecurityAssessmentMetadataPartner()
        {
        }

        /// <summary> Name of the company of the partner. </summary>
        public string PartnerName { get; set; }
        /// <summary> Name of the product of the partner that created the assessment. </summary>
        public string ProductName { get; set; }
        /// <summary> Secret to authenticate the partner and verify it created the assessment - write only. </summary>
        public string Secret { get; set; }
    }
}
