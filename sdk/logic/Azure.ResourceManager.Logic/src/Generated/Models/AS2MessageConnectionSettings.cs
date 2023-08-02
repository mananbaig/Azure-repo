// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The AS2 agreement message connection settings. </summary>
    public partial class AS2MessageConnectionSettings
    {
        /// <summary> Initializes a new instance of AS2MessageConnectionSettings. </summary>
        /// <param name="ignoreCertificateNameMismatch"> The value indicating whether to ignore mismatch in certificate name. </param>
        /// <param name="supportHttpStatusCodeContinue"> The value indicating whether to support HTTP status code 'CONTINUE'. </param>
        /// <param name="keepHttpConnectionAlive"> The value indicating whether to keep the connection alive. </param>
        /// <param name="unfoldHttpHeaders"> The value indicating whether to unfold the HTTP headers. </param>
        public AS2MessageConnectionSettings(bool ignoreCertificateNameMismatch, bool supportHttpStatusCodeContinue, bool keepHttpConnectionAlive, bool unfoldHttpHeaders)
        {
            IgnoreCertificateNameMismatch = ignoreCertificateNameMismatch;
            SupportHttpStatusCodeContinue = supportHttpStatusCodeContinue;
            KeepHttpConnectionAlive = keepHttpConnectionAlive;
            UnfoldHttpHeaders = unfoldHttpHeaders;
        }

        /// <summary> The value indicating whether to ignore mismatch in certificate name. </summary>
        public bool IgnoreCertificateNameMismatch { get; set; }
        /// <summary> The value indicating whether to support HTTP status code 'CONTINUE'. </summary>
        public bool SupportHttpStatusCodeContinue { get; set; }
        /// <summary> The value indicating whether to keep the connection alive. </summary>
        public bool KeepHttpConnectionAlive { get; set; }
        /// <summary> The value indicating whether to unfold the HTTP headers. </summary>
        public bool UnfoldHttpHeaders { get; set; }
    }
}
