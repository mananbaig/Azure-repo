// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> A request chat message representing user input to the assistant. </summary>
    public partial class ChatRequestUserMessage : ChatRequestMessage
    {
        /// <summary> Initializes a new instance of <see cref="ChatRequestUserMessage"/>. </summary>
        /// <param name="role"> The chat role associated with this message. </param>
        /// <param name="content"> The contents of the user message, with available input types varying by selected model. </param>
        /// <param name="name"> An optional name for the participant. </param>
        internal ChatRequestUserMessage(ChatRole role, BinaryData content, string name) : base(role)
        {
            Content = content;
            Name = name;
        }
        /// <summary> An optional name for the participant. </summary>
        public string Name { get; set; }
    }
}
