// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The type of the event channel which represents the direction flow of events. </summary>
    public readonly partial struct ChannelType : IEquatable<ChannelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChannelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChannelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PartnerTopicValue = "PartnerTopic";

        /// <summary> PartnerTopic. </summary>
        public static ChannelType PartnerTopic { get; } = new ChannelType(PartnerTopicValue);
        /// <summary> Determines if two <see cref="ChannelType"/> values are the same. </summary>
        public static bool operator ==(ChannelType left, ChannelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChannelType"/> values are not the same. </summary>
        public static bool operator !=(ChannelType left, ChannelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChannelType"/>. </summary>
        public static implicit operator ChannelType(string value) => new ChannelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChannelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChannelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
