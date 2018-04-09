// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation info for an event result
    /// </summary>
    public partial class EventsOperationInfo
    {
        /// <summary>
        /// Initializes a new instance of the EventsOperationInfo class.
        /// </summary>
        public EventsOperationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventsOperationInfo class.
        /// </summary>
        /// <param name="name">Name of the operation</param>
        /// <param name="id">ID of the operation</param>
        /// <param name="parentId">Parent ID of the operation</param>
        /// <param name="syntheticSource">Synthetic source of the
        /// operation</param>
        public EventsOperationInfo(string name = default(string), string id = default(string), string parentId = default(string), string syntheticSource = default(string))
        {
            Name = name;
            Id = id;
            ParentId = parentId;
            SyntheticSource = syntheticSource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the operation
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets ID of the operation
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets parent ID of the operation
        /// </summary>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets synthetic source of the operation
        /// </summary>
        [JsonProperty(PropertyName = "syntheticSource")]
        public string SyntheticSource { get; set; }

    }
}
