// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Security assessment on a resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SecurityAssessment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SecurityAssessment class.
        /// </summary>
        public SecurityAssessment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityAssessment class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="displayName">User friendly display name of the
        /// assessment</param>
        /// <param name="status">Status of the. Possible values include:
        /// 'Passed', 'Failed', 'NotApplicable'</param>
        /// <param name="notApplicableReasonCode">Programmatic code for the
        /// reason the assessment result is NotApplicable</param>
        /// <param name="notApplicableReasonDescription">Human readable
        /// description for the reason the assessment result is
        /// NotApplicable</param>
        /// <param name="additionalData">Additional data regarding the
        /// assessment</param>
        public SecurityAssessment(string id = default(string), string name = default(string), string type = default(string), ResourceDetails resourceDetails = default(ResourceDetails), string displayName = default(string), string status = default(string), string notApplicableReasonCode = default(string), string notApplicableReasonDescription = default(string), IList<AssessmentAdditionalData> additionalData = default(IList<AssessmentAdditionalData>))
            : base(id, name, type)
        {
            ResourceDetails = resourceDetails;
            DisplayName = displayName;
            Status = status;
            NotApplicableReasonCode = notApplicableReasonCode;
            NotApplicableReasonDescription = notApplicableReasonDescription;
            AdditionalData = additionalData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceDetails")]
        public ResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Gets user friendly display name of the assessment
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets status of the. Possible values include: 'Passed', 'Failed',
        /// 'NotApplicable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets programmatic code for the reason the assessment result is
        /// NotApplicable
        /// </summary>
        [JsonProperty(PropertyName = "properties.notApplicableReasonCode")]
        public string NotApplicableReasonCode { get; private set; }

        /// <summary>
        /// Gets human readable description for the reason the assessment
        /// result is NotApplicable
        /// </summary>
        [JsonProperty(PropertyName = "properties.notApplicableReasonDescription")]
        public string NotApplicableReasonDescription { get; private set; }

        /// <summary>
        /// Gets additional data regarding the assessment
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalData")]
        public IList<AssessmentAdditionalData> AdditionalData { get; private set; }

    }
}
