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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A query response.
    /// </summary>
    /// <remarks>
    /// Contains the tables, columns &amp; rows resulting from a query.
    /// </remarks>
    public partial class QueryResults
    {
        /// <summary>
        /// Initializes a new instance of the QueryResults class.
        /// </summary>
        public QueryResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryResults class.
        /// </summary>
        /// <param name="tables">The list of tables, columns and rows.</param>
        public QueryResults(IList<Table> tables)
        {
            Tables = tables;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of tables, columns and rows.
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<Table> Tables { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tables == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tables");
            }
            if (Tables != null)
            {
                foreach (var element in Tables)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
