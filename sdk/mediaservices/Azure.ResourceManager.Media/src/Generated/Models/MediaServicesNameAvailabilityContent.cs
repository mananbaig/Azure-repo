// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The input to the check name availability request. </summary>
    public partial class MediaServicesNameAvailabilityContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MediaServicesNameAvailabilityContent"/>. </summary>
        public MediaServicesNameAvailabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaServicesNameAvailabilityContent"/>. </summary>
        /// <param name="name"> The account name. </param>
        /// <param name="resourceType"> The account type. For a Media Services account, this should be 'MediaServices'. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaServicesNameAvailabilityContent(string name, string resourceType, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> The account name. </summary>
        public string Name { get; set; }
        /// <summary> The account type. For a Media Services account, this should be 'MediaServices'. </summary>
        public string ResourceType { get; set; }
    }
}
