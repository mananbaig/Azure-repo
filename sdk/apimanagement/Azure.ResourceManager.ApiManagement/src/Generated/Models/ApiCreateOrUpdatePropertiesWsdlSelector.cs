// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Criteria to limit import of WSDL to a subset of the document. </summary>
    public partial class ApiCreateOrUpdatePropertiesWsdlSelector
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiCreateOrUpdatePropertiesWsdlSelector"/>. </summary>
        public ApiCreateOrUpdatePropertiesWsdlSelector()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiCreateOrUpdatePropertiesWsdlSelector"/>. </summary>
        /// <param name="wsdlServiceName"> Name of service to import from WSDL. </param>
        /// <param name="wsdlEndpointName"> Name of endpoint(port) to import from WSDL. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiCreateOrUpdatePropertiesWsdlSelector(string wsdlServiceName, string wsdlEndpointName, Dictionary<string, BinaryData> rawData)
        {
            WsdlServiceName = wsdlServiceName;
            WsdlEndpointName = wsdlEndpointName;
            _rawData = rawData;
        }

        /// <summary> Name of service to import from WSDL. </summary>
        public string WsdlServiceName { get; set; }
        /// <summary> Name of endpoint(port) to import from WSDL. </summary>
        public string WsdlEndpointName { get; set; }
    }
}
