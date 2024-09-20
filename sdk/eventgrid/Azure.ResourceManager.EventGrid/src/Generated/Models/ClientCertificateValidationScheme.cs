// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The validation scheme used to authenticate the client. Default value is SubjectMatchesAuthenticationName. </summary>
    public readonly partial struct ClientCertificateValidationScheme : IEquatable<ClientCertificateValidationScheme>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClientCertificateValidationScheme"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClientCertificateValidationScheme(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SubjectMatchesAuthenticationNameValue = "SubjectMatchesAuthenticationName";
        private const string DnsMatchesAuthenticationNameValue = "DnsMatchesAuthenticationName";
        private const string UriMatchesAuthenticationNameValue = "UriMatchesAuthenticationName";
        private const string IPMatchesAuthenticationNameValue = "IpMatchesAuthenticationName";
        private const string EmailMatchesAuthenticationNameValue = "EmailMatchesAuthenticationName";
        private const string ThumbprintMatchValue = "ThumbprintMatch";

        /// <summary> SubjectMatchesAuthenticationName. </summary>
        public static ClientCertificateValidationScheme SubjectMatchesAuthenticationName { get; } = new ClientCertificateValidationScheme(SubjectMatchesAuthenticationNameValue);
        /// <summary> DnsMatchesAuthenticationName. </summary>
        public static ClientCertificateValidationScheme DnsMatchesAuthenticationName { get; } = new ClientCertificateValidationScheme(DnsMatchesAuthenticationNameValue);
        /// <summary> UriMatchesAuthenticationName. </summary>
        public static ClientCertificateValidationScheme UriMatchesAuthenticationName { get; } = new ClientCertificateValidationScheme(UriMatchesAuthenticationNameValue);
        /// <summary> IpMatchesAuthenticationName. </summary>
        public static ClientCertificateValidationScheme IPMatchesAuthenticationName { get; } = new ClientCertificateValidationScheme(IPMatchesAuthenticationNameValue);
        /// <summary> EmailMatchesAuthenticationName. </summary>
        public static ClientCertificateValidationScheme EmailMatchesAuthenticationName { get; } = new ClientCertificateValidationScheme(EmailMatchesAuthenticationNameValue);
        /// <summary> ThumbprintMatch. </summary>
        public static ClientCertificateValidationScheme ThumbprintMatch { get; } = new ClientCertificateValidationScheme(ThumbprintMatchValue);
        /// <summary> Determines if two <see cref="ClientCertificateValidationScheme"/> values are the same. </summary>
        public static bool operator ==(ClientCertificateValidationScheme left, ClientCertificateValidationScheme right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClientCertificateValidationScheme"/> values are not the same. </summary>
        public static bool operator !=(ClientCertificateValidationScheme left, ClientCertificateValidationScheme right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClientCertificateValidationScheme"/>. </summary>
        public static implicit operator ClientCertificateValidationScheme(string value) => new ClientCertificateValidationScheme(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClientCertificateValidationScheme other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClientCertificateValidationScheme other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
