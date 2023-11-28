// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact agreement content. </summary>
    public partial class EdifactAgreementContent
    {
        /// <summary> Initializes a new instance of <see cref="EdifactAgreementContent"/>. </summary>
        /// <param name="receiveAgreement"> The EDIFACT one-way receive agreement. </param>
        /// <param name="sendAgreement"> The EDIFACT one-way send agreement. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiveAgreement"/> or <paramref name="sendAgreement"/> is null. </exception>
        public EdifactAgreementContent(EdifactOneWayAgreement receiveAgreement, EdifactOneWayAgreement sendAgreement)
        {
            Argument.AssertNotNull(receiveAgreement, nameof(receiveAgreement));
            Argument.AssertNotNull(sendAgreement, nameof(sendAgreement));

            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
        }

        /// <summary> The EDIFACT one-way receive agreement. </summary>
        public EdifactOneWayAgreement ReceiveAgreement { get; set; }
        /// <summary> The EDIFACT one-way send agreement. </summary>
        public EdifactOneWayAgreement SendAgreement { get; set; }
    }
}
