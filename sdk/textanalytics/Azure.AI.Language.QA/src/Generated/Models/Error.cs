// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.QA.Models
{
    /// <summary> The error object. As per Microsoft One API guidelines - https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        internal Error(ErrorCodeType code)
        {
            Code = code;
            Details = new ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="target"> The target of the error. </param>
        /// <param name="details"> An array of details about specific errors that led to this reported error. </param>
        /// <param name="innerError"> An object containing more specific information than the current object about the error. </param>
        internal Error(ErrorCodeType code, string message, string target, IReadOnlyList<Error> details, InnerErrorModel innerError)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            InnerError = innerError;
        }

        /// <summary> One of a server-defined set of error codes. </summary>
        public ErrorCodeType Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> The target of the error. </summary>
        public string Target { get; }
        /// <summary> An array of details about specific errors that led to this reported error. </summary>
        public IReadOnlyList<Error> Details { get; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public InnerErrorModel InnerError { get; }
    }
}
