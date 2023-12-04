// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Communication.MediaComposition;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> The Participant. </summary>
    public partial class ParticipantInput : MediaInput
    {
        /// <summary> Initializes a new instance of <see cref="ParticipantInput"/>. </summary>
        /// <param name="kind"> Kind of media input. </param>
        /// <param name="placeholderImageUri"> Image url to be used if participant has no video stream. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="serviceId"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </param>
        /// <param name="call"> The id of the teams meeting or call. </param>
        internal ParticipantInput(MediaInputType kind, string placeholderImageUri, IDictionary<string, BinaryData> serializedAdditionalRawData, CommunicationIdentifierModel serviceId, string call) : base(kind, placeholderImageUri, serializedAdditionalRawData)
        {
            ServiceId = serviceId;
            Call = call;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantInput"/> for deserialization. </summary>
        internal ParticipantInput()
        {
        }
        /// <summary> The id of the teams meeting or call. </summary>
        public string Call { get; set; }
    }
}
