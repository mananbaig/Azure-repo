// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Administration.Models
{
    /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
    public partial class SystemData
    {
        /// <summary> Initializes a new instance of SystemData. </summary>
        internal SystemData()
        {
        }

        /// <summary> Initializes a new instance of SystemData. </summary>
        /// <param name="createdAt"> The timestamp of resource creation (UTC). </param>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="createdByType"> The type of identity that created the resource. </param>
        /// <param name="lastModifiedAt"> The timestamp of the last modification the resource (UTC). </param>
        /// <param name="lastModifiedBy"> The identity that last modified the resource. </param>
        /// <param name="lastModifiedByType"> The type of identity that last modified the resource. </param>
        internal SystemData(DateTimeOffset? createdAt, string createdBy, CreatedByType? createdByType, DateTimeOffset? lastModifiedAt, string lastModifiedBy, LastModifiedByType? lastModifiedByType)
        {
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            LastModifiedAt = lastModifiedAt;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
        }

        /// <summary> The timestamp of resource creation (UTC). </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The identity that created the resource. </summary>
        public string CreatedBy { get; }
        /// <summary> The type of identity that created the resource. </summary>
        public CreatedByType? CreatedByType { get; }
        /// <summary> The timestamp of the last modification the resource (UTC). </summary>
        public DateTimeOffset? LastModifiedAt { get; }
        /// <summary> The identity that last modified the resource. </summary>
        public string LastModifiedBy { get; }
        /// <summary> The type of identity that last modified the resource. </summary>
        public LastModifiedByType? LastModifiedByType { get; }
    }
}
