// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> An app cloneability criterion. </summary>
    public partial class SiteCloneabilityCriterion
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteCloneabilityCriterion"/>. </summary>
        internal SiteCloneabilityCriterion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteCloneabilityCriterion"/>. </summary>
        /// <param name="name"> Name of criterion. </param>
        /// <param name="description"> Description of criterion. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteCloneabilityCriterion(string name, string description, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of criterion. </summary>
        public string Name { get; }
        /// <summary> Description of criterion. </summary>
        public string Description { get; }
    }
}
