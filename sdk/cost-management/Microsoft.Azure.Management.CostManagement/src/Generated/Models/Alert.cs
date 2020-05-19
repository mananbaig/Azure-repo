// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An individual alert.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Alert : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        public Alert()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Alert class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="definition">defines the type of alert</param>
        /// <param name="description">Alert description</param>
        /// <param name="source">Source of alert</param>
        /// <param name="details">Alert details</param>
        /// <param name="costEntityId">related budget</param>
        /// <param name="status">alert status</param>
        /// <param name="creationTime">dateTime in which alert was
        /// created</param>
        /// <param name="closeTime">dateTime in which alert was closed</param>
        /// <param name="modificationTime">dateTime in which alert was last
        /// modified</param>
        /// <param name="statusModificationTime">dateTime in which the alert
        /// status was last modified</param>
        public Alert(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), AlertPropertiesDefinition definition = default(AlertPropertiesDefinition), string description = default(string), string source = default(string), AlertPropertiesDetails details = default(AlertPropertiesDetails), string costEntityId = default(string), string status = default(string), string creationTime = default(string), string closeTime = default(string), string modificationTime = default(string), string statusModificationUserName = default(string), string statusModificationTime = default(string))
            : base(id, name, type, tags)
        {
            Definition = definition;
            Description = description;
            Source = source;
            Details = details;
            CostEntityId = costEntityId;
            Status = status;
            CreationTime = creationTime;
            CloseTime = closeTime;
            ModificationTime = modificationTime;
            StatusModificationUserName = statusModificationUserName;
            StatusModificationTime = statusModificationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the type of alert
        /// </summary>
        [JsonProperty(PropertyName = "properties.definition")]
        public AlertPropertiesDefinition Definition { get; set; }

        /// <summary>
        /// Gets or sets alert description
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets source of alert
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets alert details
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public AlertPropertiesDetails Details { get; set; }

        /// <summary>
        /// Gets or sets related budget
        /// </summary>
        [JsonProperty(PropertyName = "properties.costEntityId")]
        public string CostEntityId { get; set; }

        /// <summary>
        /// Gets or sets alert status
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets dateTime in which alert was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// Gets or sets dateTime in which alert was closed
        /// </summary>
        [JsonProperty(PropertyName = "properties.closeTime")]
        public string CloseTime { get; set; }

        /// <summary>
        /// Gets or sets dateTime in which alert was last modified
        /// </summary>
        [JsonProperty(PropertyName = "properties.modificationTime")]
        public string ModificationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusModificationUserName")]
        public string StatusModificationUserName { get; set; }

        /// <summary>
        /// Gets or sets dateTime in which the alert status was last modified
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusModificationTime")]
        public string StatusModificationTime { get; set; }

    }
}
