// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckNameAvailabilitySpecifications. </summary>
    public partial class CheckNameAvailabilitySpecifications
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CheckNameAvailabilitySpecifications"/>. </summary>
        public CheckNameAvailabilitySpecifications()
        {
            ResourceTypesWithCustomValidation = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CheckNameAvailabilitySpecifications"/>. </summary>
        /// <param name="isDefaultValidationEnabled"></param>
        /// <param name="resourceTypesWithCustomValidation"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckNameAvailabilitySpecifications(bool? isDefaultValidationEnabled, IList<string> resourceTypesWithCustomValidation, Dictionary<string, BinaryData> rawData)
        {
            IsDefaultValidationEnabled = isDefaultValidationEnabled;
            ResourceTypesWithCustomValidation = resourceTypesWithCustomValidation;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the is default validation enabled. </summary>
        public bool? IsDefaultValidationEnabled { get; set; }
        /// <summary> Gets the resource types with custom validation. </summary>
        public IList<string> ResourceTypesWithCustomValidation { get; }
    }
}
