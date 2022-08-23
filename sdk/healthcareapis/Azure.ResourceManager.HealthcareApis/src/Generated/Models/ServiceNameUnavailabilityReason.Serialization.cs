// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    internal static partial class ServiceNameUnavailabilityReasonExtensions
    {
        public static string ToSerialString(this ServiceNameUnavailabilityReason value) => value switch
        {
            ServiceNameUnavailabilityReason.Invalid => "Invalid",
            ServiceNameUnavailabilityReason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceNameUnavailabilityReason value.")
        };

        public static ServiceNameUnavailabilityReason ToServiceNameUnavailabilityReason(this string value)
        {
            if (string.Equals(value, "Invalid", StringComparison.InvariantCultureIgnoreCase)) return ServiceNameUnavailabilityReason.Invalid;
            if (string.Equals(value, "AlreadyExists", StringComparison.InvariantCultureIgnoreCase)) return ServiceNameUnavailabilityReason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServiceNameUnavailabilityReason value.");
        }
    }
}
