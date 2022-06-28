// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The SplitContent. </summary>
    public partial class SplitContent
    {
        /// <summary> Initializes a new instance of SplitContent. </summary>
        public SplitContent()
        {
            Quantities = new ChangeTrackingList<int>();
        }

        /// <summary> List of the quantities in the new reservations to create. </summary>
        public IList<int> Quantities { get; }
        /// <summary> Resource id of the reservation to be split. Format of the resource id should be /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}. </summary>
        public string ReservationId { get; set; }
    }
}
