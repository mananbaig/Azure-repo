// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PipelineTriggerProperties
    {
        /// <summary>
        /// Initializes a new instance of the PipelineTriggerProperties class.
        /// </summary>
        public PipelineTriggerProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PipelineTriggerProperties class.
        /// </summary>
        /// <param name="sourceTrigger">The source trigger properties of the
        /// pipeline.</param>
        public PipelineTriggerProperties(PipelineSourceTriggerProperties sourceTrigger = default(PipelineSourceTriggerProperties))
        {
            SourceTrigger = sourceTrigger;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source trigger properties of the pipeline.
        /// </summary>
        [JsonProperty(PropertyName = "sourceTrigger")]
        public PipelineSourceTriggerProperties SourceTrigger { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceTrigger != null)
            {
                SourceTrigger.Validate();
            }
        }
    }
}
