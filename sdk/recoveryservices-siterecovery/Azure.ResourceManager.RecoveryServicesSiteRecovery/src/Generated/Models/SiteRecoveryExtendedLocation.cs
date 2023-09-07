// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Extended location of the resource. </summary>
    public partial class SiteRecoveryExtendedLocation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryExtendedLocation"/>. </summary>
        /// <param name="name"> The name of the extended location. </param>
        /// <param name="extendedLocationType"> The extended location type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SiteRecoveryExtendedLocation(string name, SiteRecoveryExtendedLocationType extendedLocationType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ExtendedLocationType = extendedLocationType;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryExtendedLocation"/>. </summary>
        /// <param name="name"> The name of the extended location. </param>
        /// <param name="extendedLocationType"> The extended location type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryExtendedLocation(string name, SiteRecoveryExtendedLocationType extendedLocationType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ExtendedLocationType = extendedLocationType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryExtendedLocation"/> for deserialization. </summary>
        internal SiteRecoveryExtendedLocation()
        {
        }

        /// <summary> The name of the extended location. </summary>
        public string Name { get; set; }
        /// <summary> The extended location type. </summary>
        public SiteRecoveryExtendedLocationType ExtendedLocationType { get; set; }
    }
}
