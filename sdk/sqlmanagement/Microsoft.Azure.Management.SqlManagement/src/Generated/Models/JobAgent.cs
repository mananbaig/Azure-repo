// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure SQL job agent.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class JobAgent : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the JobAgent class.
        /// </summary>
        public JobAgent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobAgent class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="databaseId">Resource ID of the database to store job
        /// metadata in.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The name and tier of the SKU.</param>
        /// <param name="state">The state of the job agent. Possible values
        /// include: 'Creating', 'Ready', 'Updating', 'Deleting',
        /// 'Disabled'</param>
        public JobAgent(string location, string databaseId, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), JobAgentState? state = default(JobAgentState?))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            DatabaseId = databaseId;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name and tier of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets resource ID of the database to store job metadata in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseId")]
        public string DatabaseId { get; set; }

        /// <summary>
        /// Gets the state of the job agent. Possible values include:
        /// 'Creating', 'Ready', 'Updating', 'Deleting', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public JobAgentState? State { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DatabaseId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatabaseId");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
