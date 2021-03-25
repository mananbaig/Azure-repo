// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    internal static partial class EntityCertaintyExtensions
    {
        public static string ToSerialString(this EntityCertainty value) => value switch
        {
            EntityCertainty.Positive => "positive",
            EntityCertainty.PositivePossible => "positivePossible",
            EntityCertainty.NeutralPossible => "neutralPossible",
            EntityCertainty.NegativePossible => "negativePossible",
            EntityCertainty.Negative => "negative",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EntityCertainty value.")
        };

        public static EntityCertainty ToEntityCertainty(this string value)
        {
            if (string.Equals(value, "positive", StringComparison.InvariantCultureIgnoreCase)) return EntityCertainty.Positive;
            if (string.Equals(value, "positivePossible", StringComparison.InvariantCultureIgnoreCase)) return EntityCertainty.PositivePossible;
            if (string.Equals(value, "neutralPossible", StringComparison.InvariantCultureIgnoreCase)) return EntityCertainty.NeutralPossible;
            if (string.Equals(value, "negativePossible", StringComparison.InvariantCultureIgnoreCase)) return EntityCertainty.NegativePossible;
            if (string.Equals(value, "negative", StringComparison.InvariantCultureIgnoreCase)) return EntityCertainty.Negative;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EntityCertainty value.");
        }
    }
}
