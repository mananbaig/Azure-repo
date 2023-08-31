// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Identity.Models
{
    /// <summary> The Communication Services error. </summary>
    internal partial class CommunicationErrorResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/>. </summary>
        /// <param name="error"> The Communication Services error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal CommunicationErrorResponse(CommunicationError error)
        {
            Argument.AssertNotNull(error, nameof(error));

            Error = error;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/>. </summary>
        /// <param name="error"> The Communication Services error. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunicationErrorResponse(CommunicationError error, Dictionary<string, BinaryData> rawData)
        {
            Error = error;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CommunicationErrorResponse"/> for deserialization. </summary>
        internal CommunicationErrorResponse()
        {
        }

        /// <summary> The Communication Services error. </summary>
        public CommunicationError Error { get; }
    }
}
