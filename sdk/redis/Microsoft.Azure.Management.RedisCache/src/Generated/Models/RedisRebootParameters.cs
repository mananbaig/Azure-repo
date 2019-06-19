// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies which Redis node(s) to reboot.
    /// </summary>
    public partial class RedisRebootParameters
    {
        /// <summary>
        /// Initializes a new instance of the RedisRebootParameters class.
        /// </summary>
        public RedisRebootParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedisRebootParameters class.
        /// </summary>
        /// <param name="rebootType">Which Redis node(s) to reboot. Depending
        /// on this value data loss is possible. Possible values include:
        /// 'PrimaryNode', 'SecondaryNode', 'AllNodes'</param>
        /// <param name="shardId">If clustering is enabled, the ID of the shard
        /// to be rebooted.</param>
        public RedisRebootParameters(string rebootType, int? shardId = default(int?))
        {
            RebootType = rebootType;
            ShardId = shardId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets which Redis node(s) to reboot. Depending on this value
        /// data loss is possible. Possible values include: 'PrimaryNode',
        /// 'SecondaryNode', 'AllNodes'
        /// </summary>
        [JsonProperty(PropertyName = "rebootType")]
        public string RebootType { get; set; }

        /// <summary>
        /// Gets or sets if clustering is enabled, the ID of the shard to be
        /// rebooted.
        /// </summary>
        [JsonProperty(PropertyName = "shardId")]
        public int? ShardId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RebootType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RebootType");
            }
        }
    }
}
