// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The details of the quota Request.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class QuotaRequestDetails : IResource
    {
        /// <summary>
        /// Initializes a new instance of the QuotaRequestDetails class.
        /// </summary>
        public QuotaRequestDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaRequestDetails class.
        /// </summary>
        /// <param name="id">The quota request Id.</param>
        /// <param name="name">The name of the quota request.</param>
        /// <param name="provisioningState">The quota request status.</param>
        /// <param name="message">User friendly status message.</param>
        /// <param name="requestSubmitTime">The quota request submit time. The
        /// date conforms to the following format: yyyy-MM-ddTHH:mm:ssZ as
        /// specified by the ISO 8601 standard.</param>
        /// <param name="value">The quotaRequests.</param>
        /// <param name="type">Type of resource.
        /// "Microsoft.Capacity/ServiceLimits"</param>
        public QuotaRequestDetails(string id = default(string), string name = default(string), object provisioningState = default(object), string message = default(string), System.DateTime? requestSubmitTime = default(System.DateTime?), IList<SubRequest> value = default(IList<SubRequest>), string type = default(string))
        {
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            Message = message;
            RequestSubmitTime = requestSubmitTime;
            Value = value;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the quota request Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the quota request.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the quota request status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public object ProvisioningState { get; set; }

        /// <summary>
        /// Gets user friendly status message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the quota request submit time. The date conforms to the
        /// following format: yyyy-MM-ddTHH:mm:ssZ as specified by the ISO 8601
        /// standard.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestSubmitTime")]
        public System.DateTime? RequestSubmitTime { get; private set; }

        /// <summary>
        /// Gets or sets the quotaRequests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public IList<SubRequest> Value { get; set; }

        /// <summary>
        /// Gets type of resource. "Microsoft.Capacity/ServiceLimits"
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
