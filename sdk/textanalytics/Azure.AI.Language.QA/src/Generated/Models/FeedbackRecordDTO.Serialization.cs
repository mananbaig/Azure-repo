// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QA.Models
{
    internal partial class FeedbackRecordDTO : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("userId");
                writer.WriteStringValue(UserId);
            }
            if (Optional.IsDefined(UserQuestion))
            {
                writer.WritePropertyName("userQuestion");
                writer.WriteStringValue(UserQuestion);
            }
            if (Optional.IsDefined(QnaId))
            {
                writer.WritePropertyName("qnaId");
                writer.WriteNumberValue(QnaId.Value);
            }
            writer.WriteEndObject();
        }
    }
}
