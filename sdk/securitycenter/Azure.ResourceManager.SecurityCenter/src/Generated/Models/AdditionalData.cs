// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// Details of the sub-assessment
    /// Please note <see cref="AdditionalData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContainerRegistryVulnerabilityProperties"/>, <see cref="ServerVulnerabilityProperties"/> and <see cref="SqlServerVulnerabilityProperties"/>.
    /// </summary>
    public abstract partial class AdditionalData
    {
        /// <summary> Initializes a new instance of AdditionalData. </summary>
        protected AdditionalData()
        {
        }

        /// <summary> Initializes a new instance of AdditionalData. </summary>
        /// <param name="assessedResourceType"> Sub-assessment resource type. </param>
        internal AdditionalData(AssessedResourceType assessedResourceType)
        {
            AssessedResourceType = assessedResourceType;
        }

        /// <summary> Sub-assessment resource type. </summary>
        internal AssessedResourceType AssessedResourceType { get; set; }
    }
}
