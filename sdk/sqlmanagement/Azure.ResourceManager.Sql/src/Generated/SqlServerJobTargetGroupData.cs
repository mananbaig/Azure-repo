// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerJobTargetGroup data model.
    /// A group of job targets.
    /// </summary>
    public partial class SqlServerJobTargetGroupData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlServerJobTargetGroupData"/>. </summary>
        public SqlServerJobTargetGroupData()
        {
            Members = new ChangeTrackingList<JobTarget>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerJobTargetGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="members"> Members of the target group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlServerJobTargetGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<JobTarget> members, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Members = members;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Members of the target group. </summary>
        public IList<JobTarget> Members { get; }
    }
}
