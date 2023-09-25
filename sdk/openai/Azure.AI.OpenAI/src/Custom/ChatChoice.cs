// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.AI.OpenAI
{
    public partial class ChatChoice
    {
        // Chat responses include "delta" objects as part of their SSE payloads when streaming is enabled.
        // This internal property facilitates proper deserialization of streamed chat messages.
        internal ChatMessage InternalStreamingDeltaMessage { get; }
    }
}
