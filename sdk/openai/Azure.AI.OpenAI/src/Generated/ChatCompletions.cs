// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// Representation of the response data from a chat completions request.
    /// Completions support a wide variety of tasks and generate text that continues from or "completes"
    /// provided prompt data.
    /// </summary>
    public partial class ChatCompletions
    {
        /// <summary> Initializes a new instance of ChatCompletions. </summary>
        /// <param name="id"> A unique identifier associated with this chat completions response. </param>
        /// <param name="created">
        /// The first timestamp associated with generation activity for this completions response,
        /// represented as seconds since the beginning of the Unix epoch of 00:00 on 1 Jan 1970.
        /// </param>
        /// <param name="choices">
        /// The collection of completions choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </param>
        /// <param name="usage"> Usage information for tokens processed and generated as part of this completions operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="choices"/> or <paramref name="usage"/> is null. </exception>
        internal ChatCompletions(string id, DateTimeOffset created, IEnumerable<ChatChoice> choices, CompletionsUsage usage)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(choices, nameof(choices));
            Argument.AssertNotNull(usage, nameof(usage));

            Id = id;
            Created = created;
            Choices = choices.ToList();
            PromptFilterResults = new ChangeTrackingList<PromptFilterResult>();
            Usage = usage;
        }

        /// <summary> Initializes a new instance of ChatCompletions. </summary>
        /// <param name="id"> A unique identifier associated with this chat completions response. </param>
        /// <param name="created">
        /// The first timestamp associated with generation activity for this completions response,
        /// represented as seconds since the beginning of the Unix epoch of 00:00 on 1 Jan 1970.
        /// </param>
        /// <param name="choices">
        /// The collection of completions choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </param>
        /// <param name="promptFilterResults">
        /// Content filtering results for zero or more prompts in the request. In a streaming request,
        /// results for different prompts may arrive at different times or in different orders.
        /// </param>
        /// <param name="usage"> Usage information for tokens processed and generated as part of this completions operation. </param>
        internal ChatCompletions(string id, DateTimeOffset created, IReadOnlyList<ChatChoice> choices, IReadOnlyList<PromptFilterResult> promptFilterResults, CompletionsUsage usage)
        {
            Id = id;
            Created = created;
            Choices = choices;
            PromptFilterResults = promptFilterResults;
            Usage = usage;
        }

        /// <summary> A unique identifier associated with this chat completions response. </summary>
        public string Id { get; }
        /// <summary>
        /// The first timestamp associated with generation activity for this completions response,
        /// represented as seconds since the beginning of the Unix epoch of 00:00 on 1 Jan 1970.
        /// </summary>
        public DateTimeOffset Created { get; }
        /// <summary>
        /// The collection of completions choices associated with this completions response.
        /// Generally, `n` choices are generated per provided prompt with a default value of 1.
        /// Token limits and other settings may limit the number of choices generated.
        /// </summary>
        public IReadOnlyList<ChatChoice> Choices { get; }
        /// <summary>
        /// Content filtering results for zero or more prompts in the request. In a streaming request,
        /// results for different prompts may arrive at different times or in different orders.
        /// </summary>
        public IReadOnlyList<PromptFilterResult> PromptFilterResults { get; }
        /// <summary> Usage information for tokens processed and generated as part of this completions operation. </summary>
        public CompletionsUsage Usage { get; }
    }
}
