// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class RecordingStorageInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("recordingStorageKind"u8);
            writer.WriteStringValue(RecordingStorageKind.ToString());
            if (Optional.IsDefined(RecordingDestinationContainerUrl))
            {
                writer.WritePropertyName("recordingDestinationContainerUrl"u8);
                writer.WriteStringValue(RecordingDestinationContainerUrl.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
