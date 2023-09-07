// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Links relevant to the assessment. </summary>
    internal partial class AssessmentLinks
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AssessmentLinks"/>. </summary>
        internal AssessmentLinks()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AssessmentLinks"/>. </summary>
        /// <param name="azurePortalUri"> Link to assessment in Azure Portal. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssessmentLinks(Uri azurePortalUri, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzurePortalUri = azurePortalUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Link to assessment in Azure Portal. </summary>
        public Uri AzurePortalUri { get; }
    }
}
