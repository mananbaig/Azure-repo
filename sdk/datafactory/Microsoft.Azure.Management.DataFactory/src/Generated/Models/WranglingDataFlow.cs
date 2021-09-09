// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Power Query data flow.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WranglingDataFlow : DataFlow
    {
        /// <summary>
        /// Initializes a new instance of the WranglingDataFlow class.
        /// </summary>
        public WranglingDataFlow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WranglingDataFlow class.
        /// </summary>
        /// <param name="description">The description of the data flow.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the data flow.</param>
        /// <param name="folder">The folder that this data flow is in. If not
        /// specified, Data flow will appear at the root level.</param>
        /// <param name="sources">List of sources in Power Query.</param>
        /// <param name="script">Power query mashup script.</param>
        public WranglingDataFlow(string description = default(string), IList<object> annotations = default(IList<object>), DataFlowFolder folder = default(DataFlowFolder), IList<PowerQuerySource> sources = default(IList<PowerQuerySource>), string script = default(string))
            : base(description, annotations, folder)
        {
            Sources = sources;
            Script = script;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of sources in Power Query.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sources")]
        public IList<PowerQuerySource> Sources { get; set; }

        /// <summary>
        /// Gets or sets power query mashup script.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.script")]
        public string Script { get; set; }

    }
}
