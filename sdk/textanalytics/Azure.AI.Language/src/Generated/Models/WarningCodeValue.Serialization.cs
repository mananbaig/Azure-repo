// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.Language.Models
{
    internal static class WarningCodeValueExtensions
    {
        public static string ToSerialString(this WarningCodeValue value) => value switch
        {
            WarningCodeValue.LongWordsInDocument => "LongWordsInDocument",
            WarningCodeValue.DocumentTruncated => "DocumentTruncated",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WarningCodeValue value.")
        };

        public static WarningCodeValue ToWarningCodeValue(this string value)
        {
            if (string.Equals(value, "LongWordsInDocument", StringComparison.InvariantCultureIgnoreCase)) return WarningCodeValue.LongWordsInDocument;
            if (string.Equals(value, "DocumentTruncated", StringComparison.InvariantCultureIgnoreCase)) return WarningCodeValue.DocumentTruncated;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WarningCodeValue value.");
        }
    }
}
