// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The base child entity type.
    /// </summary>
    public partial class ChildEntity
    {
        /// <summary>
        /// Initializes a new instance of the ChildEntity class.
        /// </summary>
        public ChildEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChildEntity class.
        /// </summary>
        /// <param name="id">The ID (GUID) belonging to a child entity.</param>
        /// <param name="name">The name of a child entity.</param>
        /// <param name="instanceOf">Instance of Model.</param>
        /// <param name="typeId">The type ID of the Entity Model.</param>
        /// <param name="readableType">Possible values include: 'Entity
        /// Extractor', 'Child Entity Extractor', 'Hierarchical Entity
        /// Extractor', 'Hierarchical Child Entity Extractor', 'Composite
        /// Entity Extractor', 'List Entity Extractor', 'Prebuilt Entity
        /// Extractor', 'Intent Classifier', 'Pattern.Any Entity Extractor',
        /// 'Closed List Entity Extractor', 'Regex Entity Extractor'</param>
        /// <param name="children">List of children</param>
        public ChildEntity(System.Guid id, string name = default(string), string instanceOf = default(string), int? typeId = default(int?), string readableType = default(string), IList<ChildEntity> children = default(IList<ChildEntity>))
        {
            Id = id;
            Name = name;
            InstanceOf = instanceOf;
            TypeId = typeId;
            ReadableType = readableType;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID (GUID) belonging to a child entity.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of a child entity.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets instance of Model.
        /// </summary>
        [JsonProperty(PropertyName = "instanceOf")]
        public string InstanceOf { get; set; }

        /// <summary>
        /// Gets or sets the type ID of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "typeId")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Entity Extractor', 'Child
        /// Entity Extractor', 'Hierarchical Entity Extractor', 'Hierarchical
        /// Child Entity Extractor', 'Composite Entity Extractor', 'List Entity
        /// Extractor', 'Prebuilt Entity Extractor', 'Intent Classifier',
        /// 'Pattern.Any Entity Extractor', 'Closed List Entity Extractor',
        /// 'Regex Entity Extractor'
        /// </summary>
        [JsonProperty(PropertyName = "readableType")]
        public string ReadableType { get; set; }

        /// <summary>
        /// Gets or sets list of children
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<ChildEntity> Children { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Children != null)
            {
                foreach (var element in Children)
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
