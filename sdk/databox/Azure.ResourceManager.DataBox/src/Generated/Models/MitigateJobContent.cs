// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Mitigate Job captured from request body for Mitigate API. </summary>
    public partial class MitigateJobContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MitigateJobContent"/>. </summary>
        /// <param name="customerResolutionCode"> Resolution code for the job. </param>
        /// <param name="serialNumberCustomerResolutionMap"> Serial number and the customer resolution code corresponding to each serial number. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MitigateJobContent(CustomerResolutionCode customerResolutionCode, IDictionary<string, CustomerResolutionCode> serialNumberCustomerResolutionMap, Dictionary<string, BinaryData> rawData)
        {
            CustomerResolutionCode = customerResolutionCode;
            SerialNumberCustomerResolutionMap = serialNumberCustomerResolutionMap;
            _rawData = rawData;
        }
        /// <summary> Serial number and the customer resolution code corresponding to each serial number. </summary>
        public IDictionary<string, CustomerResolutionCode> SerialNumberCustomerResolutionMap { get; }
    }
}
