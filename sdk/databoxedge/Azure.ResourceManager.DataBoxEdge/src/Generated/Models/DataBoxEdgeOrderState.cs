// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Status of the order as per the allowed status types. </summary>
    public readonly partial struct DataBoxEdgeOrderState : IEquatable<DataBoxEdgeOrderState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeOrderState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeOrderState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UntrackedValue = "Untracked";
        private const string AwaitingFulfillmentValue = "AwaitingFulfillment";
        private const string AwaitingPreparationValue = "AwaitingPreparation";
        private const string AwaitingShipmentValue = "AwaitingShipment";
        private const string ShippedValue = "Shipped";
        private const string ArrivingValue = "Arriving";
        private const string DeliveredValue = "Delivered";
        private const string ReplacementRequestedValue = "ReplacementRequested";
        private const string LostDeviceValue = "LostDevice";
        private const string DeclinedValue = "Declined";
        private const string ReturnInitiatedValue = "ReturnInitiated";
        private const string AwaitingReturnShipmentValue = "AwaitingReturnShipment";
        private const string ShippedBackValue = "ShippedBack";
        private const string CollectedAtMicrosoftValue = "CollectedAtMicrosoft";
        private const string AwaitingPickupValue = "AwaitingPickup";
        private const string PickupCompletedValue = "PickupCompleted";
        private const string AwaitingDropValue = "AwaitingDrop";

        /// <summary> Untracked. </summary>
        public static DataBoxEdgeOrderState Untracked { get; } = new DataBoxEdgeOrderState(UntrackedValue);
        /// <summary> AwaitingFulfillment. </summary>
        public static DataBoxEdgeOrderState AwaitingFulfillment { get; } = new DataBoxEdgeOrderState(AwaitingFulfillmentValue);
        /// <summary> AwaitingPreparation. </summary>
        public static DataBoxEdgeOrderState AwaitingPreparation { get; } = new DataBoxEdgeOrderState(AwaitingPreparationValue);
        /// <summary> AwaitingShipment. </summary>
        public static DataBoxEdgeOrderState AwaitingShipment { get; } = new DataBoxEdgeOrderState(AwaitingShipmentValue);
        /// <summary> Shipped. </summary>
        public static DataBoxEdgeOrderState Shipped { get; } = new DataBoxEdgeOrderState(ShippedValue);
        /// <summary> Arriving. </summary>
        public static DataBoxEdgeOrderState Arriving { get; } = new DataBoxEdgeOrderState(ArrivingValue);
        /// <summary> Delivered. </summary>
        public static DataBoxEdgeOrderState Delivered { get; } = new DataBoxEdgeOrderState(DeliveredValue);
        /// <summary> ReplacementRequested. </summary>
        public static DataBoxEdgeOrderState ReplacementRequested { get; } = new DataBoxEdgeOrderState(ReplacementRequestedValue);
        /// <summary> LostDevice. </summary>
        public static DataBoxEdgeOrderState LostDevice { get; } = new DataBoxEdgeOrderState(LostDeviceValue);
        /// <summary> Declined. </summary>
        public static DataBoxEdgeOrderState Declined { get; } = new DataBoxEdgeOrderState(DeclinedValue);
        /// <summary> ReturnInitiated. </summary>
        public static DataBoxEdgeOrderState ReturnInitiated { get; } = new DataBoxEdgeOrderState(ReturnInitiatedValue);
        /// <summary> AwaitingReturnShipment. </summary>
        public static DataBoxEdgeOrderState AwaitingReturnShipment { get; } = new DataBoxEdgeOrderState(AwaitingReturnShipmentValue);
        /// <summary> ShippedBack. </summary>
        public static DataBoxEdgeOrderState ShippedBack { get; } = new DataBoxEdgeOrderState(ShippedBackValue);
        /// <summary> CollectedAtMicrosoft. </summary>
        public static DataBoxEdgeOrderState CollectedAtMicrosoft { get; } = new DataBoxEdgeOrderState(CollectedAtMicrosoftValue);
        /// <summary> AwaitingPickup. </summary>
        public static DataBoxEdgeOrderState AwaitingPickup { get; } = new DataBoxEdgeOrderState(AwaitingPickupValue);
        /// <summary> PickupCompleted. </summary>
        public static DataBoxEdgeOrderState PickupCompleted { get; } = new DataBoxEdgeOrderState(PickupCompletedValue);
        /// <summary> AwaitingDrop. </summary>
        public static DataBoxEdgeOrderState AwaitingDrop { get; } = new DataBoxEdgeOrderState(AwaitingDropValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeOrderState"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeOrderState left, DataBoxEdgeOrderState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeOrderState"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeOrderState left, DataBoxEdgeOrderState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoxEdgeOrderState"/>. </summary>
        public static implicit operator DataBoxEdgeOrderState(string value) => new DataBoxEdgeOrderState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeOrderState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeOrderState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
