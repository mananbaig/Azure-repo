// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The participant profile property reference. </summary>
    public partial class ParticipantProfilePropertyReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ParticipantProfilePropertyReference"/>. </summary>
        /// <param name="interactionPropertyName"> The source interaction property that maps to the target profile property. </param>
        /// <param name="profilePropertyName"> The target profile property that maps to the source interaction property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionPropertyName"/> or <paramref name="profilePropertyName"/> is null. </exception>
        public ParticipantProfilePropertyReference(string interactionPropertyName, string profilePropertyName)
        {
            Argument.AssertNotNull(interactionPropertyName, nameof(interactionPropertyName));
            Argument.AssertNotNull(profilePropertyName, nameof(profilePropertyName));

            InteractionPropertyName = interactionPropertyName;
            ProfilePropertyName = profilePropertyName;
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantProfilePropertyReference"/>. </summary>
        /// <param name="interactionPropertyName"> The source interaction property that maps to the target profile property. </param>
        /// <param name="profilePropertyName"> The target profile property that maps to the source interaction property. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ParticipantProfilePropertyReference(string interactionPropertyName, string profilePropertyName, Dictionary<string, BinaryData> rawData)
        {
            InteractionPropertyName = interactionPropertyName;
            ProfilePropertyName = profilePropertyName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantProfilePropertyReference"/> for deserialization. </summary>
        internal ParticipantProfilePropertyReference()
        {
        }

        /// <summary> The source interaction property that maps to the target profile property. </summary>
        public string InteractionPropertyName { get; set; }
        /// <summary> The target profile property that maps to the source interaction property. </summary>
        public string ProfilePropertyName { get; set; }
    }
}
