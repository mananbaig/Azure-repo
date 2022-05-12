// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The DocumentError. </summary>
    internal partial class DocumentError
    {
        /// <summary> Initializes a new instance of DocumentError. </summary>
        /// <param name="id"> Document Id. </param>
        /// <param name="error"> Document Error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="error"/> is null. </exception>
        public DocumentError(string id, Error error)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Id = id;
            Error = error;
        }

        /// <summary> Document Id. </summary>
        public string Id { get; set; }
        /// <summary> Document Error. </summary>
        public Error Error { get; set; }
    }
}
