// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Human readable error code. </summary>
    internal readonly partial struct ErrorCodeType : IEquatable<ErrorCodeType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ErrorCodeType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ErrorCodeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BadArgumentValue = "BadArgument";
        private const string ForbiddenValue = "Forbidden";
        private const string NotFoundValue = "NotFound";
        private const string KbNotFoundValue = "KbNotFound";
        private const string UnauthorizedValue = "Unauthorized";
        private const string UnspecifiedValue = "Unspecified";
        private const string EndpointKeysErrorValue = "EndpointKeysError";
        private const string QuotaExceededValue = "QuotaExceeded";
        private const string QnaRuntimeErrorValue = "QnaRuntimeError";
        private const string SKULimitExceededValue = "SKULimitExceeded";
        private const string OperationNotFoundValue = "OperationNotFound";
        private const string ServiceErrorValue = "ServiceError";
        private const string ValidationFailureValue = "ValidationFailure";
        private const string ExtractionFailureValue = "ExtractionFailure";

        /// <summary> BadArgument. </summary>
        public static ErrorCodeType BadArgument { get; } = new ErrorCodeType(BadArgumentValue);
        /// <summary> Forbidden. </summary>
        public static ErrorCodeType Forbidden { get; } = new ErrorCodeType(ForbiddenValue);
        /// <summary> NotFound. </summary>
        public static ErrorCodeType NotFound { get; } = new ErrorCodeType(NotFoundValue);
        /// <summary> KbNotFound. </summary>
        public static ErrorCodeType KbNotFound { get; } = new ErrorCodeType(KbNotFoundValue);
        /// <summary> Unauthorized. </summary>
        public static ErrorCodeType Unauthorized { get; } = new ErrorCodeType(UnauthorizedValue);
        /// <summary> Unspecified. </summary>
        public static ErrorCodeType Unspecified { get; } = new ErrorCodeType(UnspecifiedValue);
        /// <summary> EndpointKeysError. </summary>
        public static ErrorCodeType EndpointKeysError { get; } = new ErrorCodeType(EndpointKeysErrorValue);
        /// <summary> QuotaExceeded. </summary>
        public static ErrorCodeType QuotaExceeded { get; } = new ErrorCodeType(QuotaExceededValue);
        /// <summary> QnaRuntimeError. </summary>
        public static ErrorCodeType QnaRuntimeError { get; } = new ErrorCodeType(QnaRuntimeErrorValue);
        /// <summary> SKULimitExceeded. </summary>
        public static ErrorCodeType SKULimitExceeded { get; } = new ErrorCodeType(SKULimitExceededValue);
        /// <summary> OperationNotFound. </summary>
        public static ErrorCodeType OperationNotFound { get; } = new ErrorCodeType(OperationNotFoundValue);
        /// <summary> ServiceError. </summary>
        public static ErrorCodeType ServiceError { get; } = new ErrorCodeType(ServiceErrorValue);
        /// <summary> ValidationFailure. </summary>
        public static ErrorCodeType ValidationFailure { get; } = new ErrorCodeType(ValidationFailureValue);
        /// <summary> ExtractionFailure. </summary>
        public static ErrorCodeType ExtractionFailure { get; } = new ErrorCodeType(ExtractionFailureValue);
        /// <summary> Determines if two <see cref="ErrorCodeType"/> values are the same. </summary>
        public static bool operator ==(ErrorCodeType left, ErrorCodeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ErrorCodeType"/> values are not the same. </summary>
        public static bool operator !=(ErrorCodeType left, ErrorCodeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ErrorCodeType"/>. </summary>
        public static implicit operator ErrorCodeType(string value) => new ErrorCodeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ErrorCodeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ErrorCodeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
