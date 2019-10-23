﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Azure.Core.Pipeline;

namespace Azure.Core
{
    /// <summary>
    /// Represents an HTTP request. Use <see cref="HttpPipeline.CreateMessage"/> or <see cref="HttpPipeline.CreateRequest"/> to create an instance.
    /// </summary>
    public abstract class Request : IDisposable
    {
        /// <summary>
        /// Gets or sets and instance of <see cref="RequestUriBuilder"/> used to create the Uri.
        /// </summary>
        public virtual RequestUriBuilder Uri { get; set; } = new RequestUriBuilder();

        /// <summary>
        /// Gets or sets the request HTTP method.
        /// </summary>
        public virtual RequestMethod Method { get; set; }

        /// <summary>
        /// Gets or sets the request content.
        /// </summary>
        public virtual RequestContent? Content { get; set; }

        /// <summary>
        /// Adds a header value to the header collection.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <param name="value">The header value.</param>
        protected internal abstract void AddHeader(string name, string value);

        /// <summary>
        /// Returns header value if headers is stored in the collection. If header has multiple values they are going to be joined with a comma.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <param name="value">The reference to populate with value.</param>
        /// <returns><code>true</code> if the specified header is stored in the collection, otherwise. <code>false</code></returns>
        protected internal abstract bool TryGetHeader(string name, [NotNullWhen(true)] out string? value);

        /// <summary>
        /// Returns header values if headers is stored in the collection.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <param name="values">The reference to populate with values.</param>
        /// <returns><code>true</code> if the specified header is stored in the collection, otherwise. <code>false</code></returns>
        protected internal abstract bool TryGetHeaderValues(string name, [NotNullWhen(true)] out IEnumerable<string>? values);

        /// <summary>
        /// Returns if headers is stored in the collection.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <returns><code>true</code> if the specified header is stored in the collection, otherwise. <code>false</code></returns>
        protected internal abstract bool ContainsHeader(string name);

        /// <summary>
        /// Sets a header value the header collection.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <param name="value">The header value.</param>
        protected internal virtual void SetHeader(string name, string value)
        {
            RemoveHeader(name);
            AddHeader(name, value);
        }
        /// <summary>
        /// Removes the header from the collection.
        /// </summary>
        /// <param name="name">The header name.</param>
        protected internal abstract bool RemoveHeader(string name);

        /// <summary>
        /// Returns an iterator enumerating <see cref="HttpHeader"/> in the request.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{T}"/> enumerating <see cref="HttpHeader"/> in the response.</returns>
        protected internal abstract IEnumerable<HttpHeader> EnumerateHeaders();

        /// <summary>
        /// Gets or sets the client request id that was sent to the server as <c>x-ms-client-request-id</c> headers.
        /// </summary>
        public abstract string ClientRequestId { get; set; }

        /// <summary>
        /// Gets the response HTTP headers.
        /// </summary>
        public RequestHeaders Headers => new RequestHeaders(this);

        /// <summary>
        /// Frees resources held by this <see cref="Response"/> instance.
        /// </summary>
        public abstract void Dispose();
    }
}
