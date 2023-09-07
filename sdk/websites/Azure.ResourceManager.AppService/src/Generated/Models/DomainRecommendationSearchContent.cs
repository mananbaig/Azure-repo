// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Domain recommendation search parameters. </summary>
    public partial class DomainRecommendationSearchContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DomainRecommendationSearchContent"/>. </summary>
        public DomainRecommendationSearchContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DomainRecommendationSearchContent"/>. </summary>
        /// <param name="keywords"> Keywords to be used for generating domain recommendations. </param>
        /// <param name="maxDomainRecommendations"> Maximum number of recommendations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DomainRecommendationSearchContent(string keywords, int? maxDomainRecommendations, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Keywords = keywords;
            MaxDomainRecommendations = maxDomainRecommendations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Keywords to be used for generating domain recommendations. </summary>
        public string Keywords { get; set; }
        /// <summary> Maximum number of recommendations. </summary>
        public int? MaxDomainRecommendations { get; set; }
    }
}
