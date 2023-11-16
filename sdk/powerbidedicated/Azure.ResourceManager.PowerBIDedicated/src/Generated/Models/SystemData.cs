// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
    public partial class SystemData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SystemData"/>. </summary>
        public SystemData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SystemData"/>. </summary>
        /// <param name="createdBy"> An identifier for the identity that created the resource. </param>
        /// <param name="createdByType"> The type of identity that created the resource. </param>
        /// <param name="createdOn"> The timestamp of resource creation (UTC). </param>
        /// <param name="lastModifiedBy"> An identifier for the identity that last modified the resource. </param>
        /// <param name="lastModifiedByType"> The type of identity that last modified the resource. </param>
        /// <param name="lastModifiedOn"> The timestamp of resource last modification (UTC). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SystemData(string createdBy, IdentityType? createdByType, DateTimeOffset? createdOn, string lastModifiedBy, IdentityType? lastModifiedByType, DateTimeOffset? lastModifiedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            CreatedOn = createdOn;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            LastModifiedOn = lastModifiedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An identifier for the identity that created the resource. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The type of identity that created the resource. </summary>
        public IdentityType? CreatedByType { get; set; }
        /// <summary> The timestamp of resource creation (UTC). </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> An identifier for the identity that last modified the resource. </summary>
        public string LastModifiedBy { get; set; }
        /// <summary> The type of identity that last modified the resource. </summary>
        public IdentityType? LastModifiedByType { get; set; }
        /// <summary> The timestamp of resource last modification (UTC). </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
    }
}
