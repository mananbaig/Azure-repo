// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The details of the test notification results.
    /// </summary>
    public partial class TestNotificationDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the TestNotificationDetailsResponse
        /// class.
        /// </summary>
        public TestNotificationDetailsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestNotificationDetailsResponse
        /// class.
        /// </summary>
        /// <param name="state">The overall state</param>
        /// <param name="completedTime">The completed time</param>
        /// <param name="createdTime">The created time</param>
        /// <param name="actionDetails">The list of action detail</param>
        public TestNotificationDetailsResponse(string state, Context context = default(Context), string completedTime = default(string), string createdTime = default(string), IList<ActionDetail> actionDetails = default(IList<ActionDetail>))
        {
            Context = context;
            State = state;
            CompletedTime = completedTime;
            CreatedTime = createdTime;
            ActionDetails = actionDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public Context Context { get; set; }

        /// <summary>
        /// Gets or sets the overall state
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the completed time
        /// </summary>
        [JsonProperty(PropertyName = "completedTime")]
        public string CompletedTime { get; set; }

        /// <summary>
        /// Gets or sets the created time
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the list of action detail
        /// </summary>
        [JsonProperty(PropertyName = "actionDetails")]
        public IList<ActionDetail> ActionDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
        }
    }
}
