// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Type of CommunicationIdentifierModel. </summary>
    internal readonly partial struct CommunicationIdentifierModelKindInternal : IEquatable<CommunicationIdentifierModelKindInternal>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommunicationIdentifierModelKindInternal"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationIdentifierModelKindInternal(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string CommunicationUserValue = "communicationUser";
        private const string PhoneNumberValue = "phoneNumber";
        private const string MicrosoftTeamsUserValue = "microsoftTeamsUser";

        /// <summary> unknown. </summary>
        public static CommunicationIdentifierModelKindInternal Unknown { get; } = new CommunicationIdentifierModelKindInternal(UnknownValue);
        /// <summary> communicationUser. </summary>
        public static CommunicationIdentifierModelKindInternal CommunicationUser { get; } = new CommunicationIdentifierModelKindInternal(CommunicationUserValue);
        /// <summary> phoneNumber. </summary>
        public static CommunicationIdentifierModelKindInternal PhoneNumber { get; } = new CommunicationIdentifierModelKindInternal(PhoneNumberValue);
        /// <summary> microsoftTeamsUser. </summary>
        public static CommunicationIdentifierModelKindInternal MicrosoftTeamsUser { get; } = new CommunicationIdentifierModelKindInternal(MicrosoftTeamsUserValue);
        /// <summary> Determines if two <see cref="CommunicationIdentifierModelKindInternal"/> values are the same. </summary>
        public static bool operator ==(CommunicationIdentifierModelKindInternal left, CommunicationIdentifierModelKindInternal right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationIdentifierModelKindInternal"/> values are not the same. </summary>
        public static bool operator !=(CommunicationIdentifierModelKindInternal left, CommunicationIdentifierModelKindInternal right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommunicationIdentifierModelKindInternal"/>. </summary>
        public static implicit operator CommunicationIdentifierModelKindInternal(string value) => new CommunicationIdentifierModelKindInternal(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationIdentifierModelKindInternal other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationIdentifierModelKindInternal other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
