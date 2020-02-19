// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The WSDL service.
    /// </summary>
    public partial class WsdlService
    {
        /// <summary>
        /// Initializes a new instance of the WsdlService class.
        /// </summary>
        public WsdlService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WsdlService class.
        /// </summary>
        /// <param name="qualifiedName">The qualified name.</param>
        /// <param name="endpointQualifiedNames">The list of endpoints'
        /// qualified names.</param>
        public WsdlService(string qualifiedName = default(string), IList<string> endpointQualifiedNames = default(IList<string>))
        {
            QualifiedName = qualifiedName;
            EndpointQualifiedNames = endpointQualifiedNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the qualified name.
        /// </summary>
        [JsonProperty(PropertyName = "qualifiedName")]
        public string QualifiedName { get; set; }

        /// <summary>
        /// Gets or sets the list of endpoints' qualified names.
        /// </summary>
        [JsonProperty(PropertyName = "EndpointQualifiedNames")]
        public IList<string> EndpointQualifiedNames { get; set; }

    }
}
