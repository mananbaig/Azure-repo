// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the move resource input type. </summary>
    public readonly partial struct MoverResourceInputType : IEquatable<MoverResourceInputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MoverResourceInputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MoverResourceInputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MoverResourceIdValue = "MoveResourceId";
        private const string MoverResourceSourceIdValue = "MoveResourceSourceId";

        /// <summary> MoveResourceId. </summary>
        public static MoverResourceInputType MoverResourceId { get; } = new MoverResourceInputType(MoverResourceIdValue);
        /// <summary> MoveResourceSourceId. </summary>
        public static MoverResourceInputType MoverResourceSourceId { get; } = new MoverResourceInputType(MoverResourceSourceIdValue);
        /// <summary> Determines if two <see cref="MoverResourceInputType"/> values are the same. </summary>
        public static bool operator ==(MoverResourceInputType left, MoverResourceInputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MoverResourceInputType"/> values are not the same. </summary>
        public static bool operator !=(MoverResourceInputType left, MoverResourceInputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MoverResourceInputType"/>. </summary>
        public static implicit operator MoverResourceInputType(string value) => new MoverResourceInputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MoverResourceInputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MoverResourceInputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
