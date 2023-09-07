// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Security assessment on a resource. </summary>
    public partial class SecurityAssessmentCreateOrUpdateContent : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentCreateOrUpdateContent"/>. </summary>
        public SecurityAssessmentCreateOrUpdateContent()
        {
            AdditionalData = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="resourceDetails">
        /// Details of the resource that was assessed
        /// Please note <see cref="SecurityCenterResourceDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceDetails"/>, <see cref="OnPremiseResourceDetails"/> and <see cref="OnPremiseSqlResourceDetails"/>.
        /// </param>
        /// <param name="displayName"> User friendly display name of the assessment. </param>
        /// <param name="additionalData"> Additional data regarding the assessment. </param>
        /// <param name="links"> Links relevant to the assessment. </param>
        /// <param name="metadata"> Describes properties of an assessment metadata. </param>
        /// <param name="partnersData"> Data regarding 3rd party partner integration. </param>
        /// <param name="status"> The result of the assessment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAssessmentCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityCenterResourceDetails resourceDetails, string displayName, IDictionary<string, string> additionalData, AssessmentLinks links, SecurityAssessmentMetadataProperties metadata, SecurityAssessmentPartner partnersData, SecurityAssessmentStatus status, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ResourceDetails = resourceDetails;
            DisplayName = displayName;
            AdditionalData = additionalData;
            Links = links;
            Metadata = metadata;
            PartnersData = partnersData;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Details of the resource that was assessed
        /// Please note <see cref="SecurityCenterResourceDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureResourceDetails"/>, <see cref="OnPremiseResourceDetails"/> and <see cref="OnPremiseSqlResourceDetails"/>.
        /// </summary>
        public SecurityCenterResourceDetails ResourceDetails { get; set; }
        /// <summary> User friendly display name of the assessment. </summary>
        public string DisplayName { get; }
        /// <summary> Additional data regarding the assessment. </summary>
        public IDictionary<string, string> AdditionalData { get; }
        /// <summary> Links relevant to the assessment. </summary>
        internal AssessmentLinks Links { get; }
        /// <summary> Link to assessment in Azure Portal. </summary>
        public Uri LinksAzurePortalUri
        {
            get => Links?.AzurePortalUri;
        }

        /// <summary> Describes properties of an assessment metadata. </summary>
        public SecurityAssessmentMetadataProperties Metadata { get; set; }
        /// <summary> Data regarding 3rd party partner integration. </summary>
        public SecurityAssessmentPartner PartnersData { get; set; }
        /// <summary> The result of the assessment. </summary>
        public SecurityAssessmentStatus Status { get; set; }
    }
}
