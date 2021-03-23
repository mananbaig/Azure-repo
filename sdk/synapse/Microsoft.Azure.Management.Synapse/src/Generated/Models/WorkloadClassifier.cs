// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Workload classifier operations for a data warehouse
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WorkloadClassifier : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkloadClassifier class.
        /// </summary>
        public WorkloadClassifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkloadClassifier class.
        /// </summary>
        /// <param name="memberName">The workload classifier member
        /// name.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="label">The workload classifier label.</param>
        /// <param name="context">The workload classifier context.</param>
        /// <param name="startTime">The workload classifier start time for
        /// classification.</param>
        /// <param name="endTime">The workload classifier end time for
        /// classification.</param>
        /// <param name="importance">The workload classifier
        /// importance.</param>
        public WorkloadClassifier(string memberName, string id = default(string), string name = default(string), string type = default(string), string label = default(string), string context = default(string), string startTime = default(string), string endTime = default(string), string importance = default(string))
            : base(id, name, type)
        {
            MemberName = memberName;
            Label = label;
            Context = context;
            StartTime = startTime;
            EndTime = endTime;
            Importance = importance;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the workload classifier member name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.memberName")]
        public string MemberName { get; set; }

        /// <summary>
        /// Gets or sets the workload classifier label.
        /// </summary>
        [JsonProperty(PropertyName = "properties.label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the workload classifier context.
        /// </summary>
        [JsonProperty(PropertyName = "properties.context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the workload classifier start time for classification.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the workload classifier end time for classification.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the workload classifier importance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.importance")]
        public string Importance { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MemberName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MemberName");
            }
        }
    }
}
