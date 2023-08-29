// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Issue update Parameters. </summary>
    public partial class ApiIssuePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiIssuePatch"/>. </summary>
        public ApiIssuePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiIssuePatch"/>. </summary>
        /// <param name="createdOn"> Date and time when the issue was created. </param>
        /// <param name="state"> Status of the issue. </param>
        /// <param name="apiId"> A resource identifier for the API the issue was created for. </param>
        /// <param name="title"> The issue title. </param>
        /// <param name="description"> Text describing the issue. </param>
        /// <param name="userId"> A resource identifier for the user created the issue. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiIssuePatch(DateTimeOffset? createdOn, IssueState? state, ResourceIdentifier apiId, string title, string description, string userId, Dictionary<string, BinaryData> rawData)
        {
            CreatedOn = createdOn;
            State = state;
            ApiId = apiId;
            Title = title;
            Description = description;
            UserId = userId;
            _rawData = rawData;
        }

        /// <summary> Date and time when the issue was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Status of the issue. </summary>
        public IssueState? State { get; set; }
        /// <summary> A resource identifier for the API the issue was created for. </summary>
        public ResourceIdentifier ApiId { get; set; }
        /// <summary> The issue title. </summary>
        public string Title { get; set; }
        /// <summary> Text describing the issue. </summary>
        public string Description { get; set; }
        /// <summary> A resource identifier for the user created the issue. </summary>
        public string UserId { get; set; }
    }
}
