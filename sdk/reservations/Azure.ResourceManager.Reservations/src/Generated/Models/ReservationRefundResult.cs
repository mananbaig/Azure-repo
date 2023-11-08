// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The response of refund request containing refund information of reservation. </summary>
    public partial class ReservationRefundResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReservationRefundResult"/>. </summary>
        /// <param name="id"> Fully qualified identifier of the reservation being returned. </param>
        /// <param name="properties"> The refund properties of reservation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationRefundResult(string id, ReservationRefundResponseProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
