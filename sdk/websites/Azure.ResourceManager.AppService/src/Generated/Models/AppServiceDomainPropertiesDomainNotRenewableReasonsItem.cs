// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The AppServiceDomainPropertiesDomainNotRenewableReasonsItem. </summary>
    public readonly partial struct AppServiceDomainPropertiesDomainNotRenewableReasonsItem : IEquatable<AppServiceDomainPropertiesDomainNotRenewableReasonsItem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppServiceDomainPropertiesDomainNotRenewableReasonsItem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppServiceDomainPropertiesDomainNotRenewableReasonsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegistrationStatusNotSupportedForRenewalValue = "RegistrationStatusNotSupportedForRenewal";
        private const string ExpirationNotInRenewalTimeRangeValue = "ExpirationNotInRenewalTimeRange";
        private const string SubscriptionNotActiveValue = "SubscriptionNotActive";

        /// <summary> RegistrationStatusNotSupportedForRenewal. </summary>
        public static AppServiceDomainPropertiesDomainNotRenewableReasonsItem RegistrationStatusNotSupportedForRenewal { get; } = new AppServiceDomainPropertiesDomainNotRenewableReasonsItem(RegistrationStatusNotSupportedForRenewalValue);
        /// <summary> ExpirationNotInRenewalTimeRange. </summary>
        public static AppServiceDomainPropertiesDomainNotRenewableReasonsItem ExpirationNotInRenewalTimeRange { get; } = new AppServiceDomainPropertiesDomainNotRenewableReasonsItem(ExpirationNotInRenewalTimeRangeValue);
        /// <summary> SubscriptionNotActive. </summary>
        public static AppServiceDomainPropertiesDomainNotRenewableReasonsItem SubscriptionNotActive { get; } = new AppServiceDomainPropertiesDomainNotRenewableReasonsItem(SubscriptionNotActiveValue);
        /// <summary> Determines if two <see cref="AppServiceDomainPropertiesDomainNotRenewableReasonsItem"/> values are the same. </summary>
        public static bool operator ==(AppServiceDomainPropertiesDomainNotRenewableReasonsItem left, AppServiceDomainPropertiesDomainNotRenewableReasonsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppServiceDomainPropertiesDomainNotRenewableReasonsItem"/> values are not the same. </summary>
        public static bool operator !=(AppServiceDomainPropertiesDomainNotRenewableReasonsItem left, AppServiceDomainPropertiesDomainNotRenewableReasonsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppServiceDomainPropertiesDomainNotRenewableReasonsItem"/>. </summary>
        public static implicit operator AppServiceDomainPropertiesDomainNotRenewableReasonsItem(string value) => new AppServiceDomainPropertiesDomainNotRenewableReasonsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppServiceDomainPropertiesDomainNotRenewableReasonsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppServiceDomainPropertiesDomainNotRenewableReasonsItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
