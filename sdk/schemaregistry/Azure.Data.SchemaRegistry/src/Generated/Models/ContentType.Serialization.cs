// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.SchemaRegistry.Models
{
    internal static partial class ContentTypeExtensions
    {
        public static string ToSerialString(this ContentType value) => value switch
        {
            ContentType.ApplicationJsonSerializationAvro => "application/json; serialization=Avro",
            ContentType.ApplicationJsonSerializationJson => "application/json; serialization=json",
            ContentType.TextPlainCharsetUtf8 => "text/plain; charset=utf-8",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContentType value.")
        };

        public static ContentType ToContentType(this string value)
        {
            if (string.Equals(value, "application/json; serialization=Avro", StringComparison.InvariantCultureIgnoreCase)) return ContentType.ApplicationJsonSerializationAvro;
            if (string.Equals(value, "application/json; serialization=json", StringComparison.InvariantCultureIgnoreCase)) return ContentType.ApplicationJsonSerializationJson;
            if (string.Equals(value, "text/plain; charset=utf-8", StringComparison.InvariantCultureIgnoreCase)) return ContentType.TextPlainCharsetUtf8;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContentType value.");
        }
    }
}
