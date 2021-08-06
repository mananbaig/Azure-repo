// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    internal partial class DocumentFilterInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix");
                writer.WriteStringValue(Prefix);
            }
            if (Optional.IsDefined(Suffix))
            {
                writer.WritePropertyName("suffix");
                writer.WriteStringValue(Suffix);
            }
            writer.WriteEndObject();
        }
    }
}
