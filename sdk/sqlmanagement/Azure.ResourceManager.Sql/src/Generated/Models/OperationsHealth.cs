// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Operations health status in a location. </summary>
    public partial class OperationsHealth : ProxyResource
    {
        /// <summary> Initializes a new instance of OperationsHealth. </summary>
        public OperationsHealth()
        {
        }

        /// <summary> Initializes a new instance of OperationsHealth. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="namePropertiesName"> Operation name for the service. </param>
        /// <param name="health"> Operation health status of the service. </param>
        /// <param name="description"> Health status description. </param>
        internal OperationsHealth(string id, string name, string type, string namePropertiesName, string health, string description) : base(id, name, type)
        {
            NamePropertiesName = namePropertiesName;
            Health = health;
            Description = description;
        }

        /// <summary> Operation name for the service. </summary>
        public string NamePropertiesName { get; }
        /// <summary> Operation health status of the service. </summary>
        public string Health { get; }
        /// <summary> Health status description. </summary>
        public string Description { get; }
    }
}
