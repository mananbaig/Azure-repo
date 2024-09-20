// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Match Variable. </summary>
    public readonly partial struct RulesEngineMatchVariable : IEquatable<RulesEngineMatchVariable>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RulesEngineMatchVariable"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RulesEngineMatchVariable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IsMobileValue = "IsMobile";
        private const string RemoteAddrValue = "RemoteAddr";
        private const string RequestMethodValue = "RequestMethod";
        private const string QueryStringValue = "QueryString";
        private const string PostArgsValue = "PostArgs";
        private const string RequestUriValue = "RequestUri";
        private const string RequestPathValue = "RequestPath";
        private const string RequestFilenameValue = "RequestFilename";
        private const string RequestFilenameExtensionValue = "RequestFilenameExtension";
        private const string RequestHeaderValue = "RequestHeader";
        private const string RequestBodyValue = "RequestBody";
        private const string RequestSchemeValue = "RequestScheme";

        /// <summary> IsMobile. </summary>
        public static RulesEngineMatchVariable IsMobile { get; } = new RulesEngineMatchVariable(IsMobileValue);
        /// <summary> RemoteAddr. </summary>
        public static RulesEngineMatchVariable RemoteAddr { get; } = new RulesEngineMatchVariable(RemoteAddrValue);
        /// <summary> RequestMethod. </summary>
        public static RulesEngineMatchVariable RequestMethod { get; } = new RulesEngineMatchVariable(RequestMethodValue);
        /// <summary> QueryString. </summary>
        public static RulesEngineMatchVariable QueryString { get; } = new RulesEngineMatchVariable(QueryStringValue);
        /// <summary> PostArgs. </summary>
        public static RulesEngineMatchVariable PostArgs { get; } = new RulesEngineMatchVariable(PostArgsValue);
        /// <summary> RequestUri. </summary>
        public static RulesEngineMatchVariable RequestUri { get; } = new RulesEngineMatchVariable(RequestUriValue);
        /// <summary> RequestPath. </summary>
        public static RulesEngineMatchVariable RequestPath { get; } = new RulesEngineMatchVariable(RequestPathValue);
        /// <summary> RequestFilename. </summary>
        public static RulesEngineMatchVariable RequestFilename { get; } = new RulesEngineMatchVariable(RequestFilenameValue);
        /// <summary> RequestFilenameExtension. </summary>
        public static RulesEngineMatchVariable RequestFilenameExtension { get; } = new RulesEngineMatchVariable(RequestFilenameExtensionValue);
        /// <summary> RequestHeader. </summary>
        public static RulesEngineMatchVariable RequestHeader { get; } = new RulesEngineMatchVariable(RequestHeaderValue);
        /// <summary> RequestBody. </summary>
        public static RulesEngineMatchVariable RequestBody { get; } = new RulesEngineMatchVariable(RequestBodyValue);
        /// <summary> RequestScheme. </summary>
        public static RulesEngineMatchVariable RequestScheme { get; } = new RulesEngineMatchVariable(RequestSchemeValue);
        /// <summary> Determines if two <see cref="RulesEngineMatchVariable"/> values are the same. </summary>
        public static bool operator ==(RulesEngineMatchVariable left, RulesEngineMatchVariable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RulesEngineMatchVariable"/> values are not the same. </summary>
        public static bool operator !=(RulesEngineMatchVariable left, RulesEngineMatchVariable right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RulesEngineMatchVariable"/>. </summary>
        public static implicit operator RulesEngineMatchVariable(string value) => new RulesEngineMatchVariable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RulesEngineMatchVariable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RulesEngineMatchVariable other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
