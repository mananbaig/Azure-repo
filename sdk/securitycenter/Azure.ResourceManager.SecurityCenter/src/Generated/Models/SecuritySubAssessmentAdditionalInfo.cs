// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// Details of the sub-assessment
    /// Please note <see cref="SecuritySubAssessmentAdditionalInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContainerRegistryVulnerabilityProperties"/>, <see cref="ServerVulnerabilityProperties"/> and <see cref="SqlServerVulnerabilityProperties"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownAdditionalData))]
    public abstract partial class SecuritySubAssessmentAdditionalInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecuritySubAssessmentAdditionalInfo"/>. </summary>
        protected SecuritySubAssessmentAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecuritySubAssessmentAdditionalInfo"/>. </summary>
        /// <param name="assessedResourceType"> Sub-assessment resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecuritySubAssessmentAdditionalInfo(AssessedResourceType assessedResourceType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssessedResourceType = assessedResourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sub-assessment resource type. </summary>
        internal AssessedResourceType AssessedResourceType { get; set; }
    }
}
