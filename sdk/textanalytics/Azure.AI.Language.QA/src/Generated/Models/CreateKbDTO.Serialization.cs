// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QA.Models
{
    internal partial class CreateKbDTO : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(QnaList))
            {
                writer.WritePropertyName("qnaList");
                writer.WriteStartArray();
                foreach (var item in QnaList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Urls))
            {
                writer.WritePropertyName("urls");
                writer.WriteStartArray();
                foreach (var item in Urls)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files");
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableHierarchicalExtraction))
            {
                writer.WritePropertyName("enableHierarchicalExtraction");
                writer.WriteBooleanValue(EnableHierarchicalExtraction.Value);
            }
            if (Optional.IsDefined(DefaultAnswerUsedForExtraction))
            {
                writer.WritePropertyName("defaultAnswerUsedForExtraction");
                writer.WriteStringValue(DefaultAnswerUsedForExtraction);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(EnableMultipleLanguages))
            {
                writer.WritePropertyName("enableMultipleLanguages");
                writer.WriteBooleanValue(EnableMultipleLanguages.Value);
            }
            if (Optional.IsDefined(DefaultAnswer))
            {
                writer.WritePropertyName("defaultAnswer");
                writer.WriteStringValue(DefaultAnswer);
            }
            writer.WriteEndObject();
        }
    }
}
