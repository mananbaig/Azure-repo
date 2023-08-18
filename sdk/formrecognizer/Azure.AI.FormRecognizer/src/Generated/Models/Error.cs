// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Error info. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal Error(string code, string message)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new Core.ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="target"> Target of the error. </param>
        /// <param name="details"> List of detailed errors. </param>
        /// <param name="innererror"> Detailed error. </param>
        internal Error(string code, string message, string target, IReadOnlyList<Error> details, InnerError innererror)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Target of the error. </summary>
        public string Target { get; }
        /// <summary> List of detailed errors. </summary>
        public IReadOnlyList<Error> Details { get; }
        /// <summary> Detailed error. </summary>
        public InnerError Innererror { get; }
    }
}
