// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Data used for requesting a SAS.
    /// </summary>
    public partial class GrantAccessData
    {
        /// <summary>
        /// Initializes a new instance of the GrantAccessData class.
        /// </summary>
        public GrantAccessData() { }

        /// <summary>
        /// Initializes a new instance of the GrantAccessData class.
        /// </summary>
        /// <param name="access">Possible values include: 'None',
        /// 'Read'</param>
        /// <param name="durationInSeconds">Time duration in seconds until the
        /// SAS access expires.</param>
        public GrantAccessData(AccessLevel access, int durationInSeconds)
        {
            Access = access;
            DurationInSeconds = durationInSeconds;
        }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Read'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "access")]
        public AccessLevel Access { get; set; }

        /// <summary>
        /// Gets or sets time duration in seconds until the SAS access expires.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "durationInSeconds")]
        public int DurationInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
