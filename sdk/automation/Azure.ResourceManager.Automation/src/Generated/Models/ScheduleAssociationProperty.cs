// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The schedule property associated with the entity. </summary>
    public partial class ScheduleAssociationProperty
    {
        /// <summary> Initializes a new instance of ScheduleAssociationProperty. </summary>
        public ScheduleAssociationProperty()
        {
        }

        /// <summary> Initializes a new instance of ScheduleAssociationProperty. </summary>
        /// <param name="name"> Gets or sets the name of the Schedule. </param>
        internal ScheduleAssociationProperty(string name)
        {
            Name = name;
        }

        /// <summary> Gets or sets the name of the Schedule. </summary>
        public string Name { get; set; }
    }
}
