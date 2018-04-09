// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies characteristics for a temporary 'auto pool'. The Batch
    /// service will create this auto pool when the job is submitted.
    /// </summary>
    public partial class AutoPoolSpecification
    {
        /// <summary>
        /// Initializes a new instance of the AutoPoolSpecification class.
        /// </summary>
        public AutoPoolSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoPoolSpecification class.
        /// </summary>
        /// <param name="poolLifetimeOption">The minimum lifetime of created
        /// auto pools, and how multiple jobs on a schedule are assigned to
        /// pools.</param>
        /// <param name="autoPoolIdPrefix">A prefix to be added to the unique
        /// identifier when a pool is automatically created.</param>
        /// <param name="keepAlive">Whether to keep an auto pool alive after
        /// its lifetime expires.</param>
        /// <param name="pool">The pool specification for the auto
        /// pool.</param>
        public AutoPoolSpecification(PoolLifetimeOption poolLifetimeOption, string autoPoolIdPrefix = default(string), bool? keepAlive = default(bool?), PoolSpecification pool = default(PoolSpecification))
        {
            AutoPoolIdPrefix = autoPoolIdPrefix;
            PoolLifetimeOption = poolLifetimeOption;
            KeepAlive = keepAlive;
            Pool = pool;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a prefix to be added to the unique identifier when a
        /// pool is automatically created.
        /// </summary>
        /// <remarks>
        /// The Batch service assigns each auto pool a unique identifier on
        /// creation. To distinguish between pools created for different
        /// purposes, you can specify this element to add a prefix to the ID
        /// that is assigned. The prefix can be up to 20 characters long.
        /// </remarks>
        [JsonProperty(PropertyName = "autoPoolIdPrefix")]
        public string AutoPoolIdPrefix { get; set; }

        /// <summary>
        /// Gets or sets the minimum lifetime of created auto pools, and how
        /// multiple jobs on a schedule are assigned to pools.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'jobSchedule', 'job'
        /// </remarks>
        [JsonProperty(PropertyName = "poolLifetimeOption")]
        public PoolLifetimeOption PoolLifetimeOption { get; set; }

        /// <summary>
        /// Gets or sets whether to keep an auto pool alive after its lifetime
        /// expires.
        /// </summary>
        /// <remarks>
        /// If false, the Batch service deletes the pool once its lifetime (as
        /// determined by the poolLifetimeOption setting) expires; that is,
        /// when the job or job schedule completes. If true, the Batch service
        /// does not delete the pool automatically. It is up to the user to
        /// delete auto pools created with this option.
        /// </remarks>
        [JsonProperty(PropertyName = "keepAlive")]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// Gets or sets the pool specification for the auto pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public PoolSpecification Pool { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Pool != null)
            {
                Pool.Validate();
            }
        }
    }
}
