// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Specifies the lease action. Can be one of the available actions. </summary>
    public readonly partial struct LeaseContainerAction : IEquatable<LeaseContainerAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LeaseContainerAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LeaseContainerAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcquireValue = "Acquire";
        private const string RenewValue = "Renew";
        private const string ChangeValue = "Change";
        private const string ReleaseValue = "Release";
        private const string BreakValue = "Break";

        /// <summary> Acquire. </summary>
        public static LeaseContainerAction Acquire { get; } = new LeaseContainerAction(AcquireValue);
        /// <summary> Renew. </summary>
        public static LeaseContainerAction Renew { get; } = new LeaseContainerAction(RenewValue);
        /// <summary> Change. </summary>
        public static LeaseContainerAction Change { get; } = new LeaseContainerAction(ChangeValue);
        /// <summary> Release. </summary>
        public static LeaseContainerAction Release { get; } = new LeaseContainerAction(ReleaseValue);
        /// <summary> Break. </summary>
        public static LeaseContainerAction Break { get; } = new LeaseContainerAction(BreakValue);
        /// <summary> Determines if two <see cref="LeaseContainerAction"/> values are the same. </summary>
        public static bool operator ==(LeaseContainerAction left, LeaseContainerAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LeaseContainerAction"/> values are not the same. </summary>
        public static bool operator !=(LeaseContainerAction left, LeaseContainerAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LeaseContainerAction"/>. </summary>
        public static implicit operator LeaseContainerAction(string value) => new LeaseContainerAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LeaseContainerAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LeaseContainerAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
