// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> An app cloneability criterion. </summary>
    public partial class SiteCloneabilityCriterion
    {
        /// <summary> Initializes a new instance of <see cref="SiteCloneabilityCriterion"/>. </summary>
        internal SiteCloneabilityCriterion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteCloneabilityCriterion"/>. </summary>
        /// <param name="name"> Name of criterion. </param>
        /// <param name="description"> Description of criterion. </param>
        internal SiteCloneabilityCriterion(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <summary> Name of criterion. </summary>
        public string Name { get; }
        /// <summary> Description of criterion. </summary>
        public string Description { get; }
    }
}
