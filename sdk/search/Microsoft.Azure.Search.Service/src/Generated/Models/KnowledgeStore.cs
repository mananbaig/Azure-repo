// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///
    /// <see
    /// href="https://docs.microsoft.com/azure/search/knowledge-store-projection-overview"
    /// />
    /// </summary>
    public partial class KnowledgeStore
    {
        /// <summary>
        /// Initializes a new instance of the KnowledgeStore class.
        /// </summary>
        public KnowledgeStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KnowledgeStore class.
        /// </summary>
        /// <param name="storageConnectionString">The connection string to the
        /// storage account projections will be stored in.</param>
        /// <param name="projections">A list of additional projections to
        /// perform during indexing.</param>
        public KnowledgeStore(string storageConnectionString, IList<KnowledgeStoreProjection> projections)
        {
            StorageConnectionString = storageConnectionString;
            Projections = projections;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string to the storage account
        /// projections will be stored in.
        /// </summary>
        [JsonProperty(PropertyName = "storageConnectionString")]
        public string StorageConnectionString { get; set; }

        /// <summary>
        /// Gets or sets a list of additional projections to perform during
        /// indexing.
        /// </summary>
        [JsonProperty(PropertyName = "projections")]
        public IList<KnowledgeStoreProjection> Projections { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageConnectionString");
            }
            if (Projections == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Projections");
            }
        }
    }
}
