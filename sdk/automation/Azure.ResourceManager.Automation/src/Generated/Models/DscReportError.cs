// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the dsc node report error type. </summary>
    public partial class DscReportError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DscReportError"/>. </summary>
        internal DscReportError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DscReportError"/>. </summary>
        /// <param name="errorSource"> Gets or sets the source of the error. </param>
        /// <param name="resourceId"> Gets or sets the resource ID which generated the error. </param>
        /// <param name="errorCode"> Gets or sets the error code. </param>
        /// <param name="errorMessage"> Gets or sets the error message. </param>
        /// <param name="locale"> Gets or sets the locale of the error. </param>
        /// <param name="errorDetails"> Gets or sets the error details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DscReportError(string errorSource, string resourceId, string errorCode, string errorMessage, string locale, string errorDetails, Dictionary<string, BinaryData> rawData)
        {
            ErrorSource = errorSource;
            ResourceId = resourceId;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Locale = locale;
            ErrorDetails = errorDetails;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the source of the error. </summary>
        public string ErrorSource { get; }
        /// <summary> Gets or sets the resource ID which generated the error. </summary>
        public string ResourceId { get; }
        /// <summary> Gets or sets the error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Gets or sets the error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Gets or sets the locale of the error. </summary>
        public string Locale { get; }
        /// <summary> Gets or sets the error details. </summary>
        public string ErrorDetails { get; }
    }
}
