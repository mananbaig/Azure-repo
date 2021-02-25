// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Communication.Pipeline;
using System.Linq;
using Azure.Communication.Sms.Models;
using System.Globalization;

namespace Azure.Communication.Sms
{
    /// <summary>
    /// The Azure Communication Services SMS client.
    /// </summary>
    public class SmsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal SmsRestClient RestClient { get; }

        #region public constructors - all arguments need null check

        /// <summary> Initializes a new instance of <see cref="SmsClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        public SmsClient(string connectionString)
            : this(
                ConnectionString.Parse(AssertNotNullOrEmpty(connectionString, nameof(connectionString))),
                new SmsClientOptions())
        { }

        /// <summary> Initializes a new instance of <see cref="SmsClient"/>.</summary>
        /// <param name="connectionString">Connection string acquired from the Azure Communication Services resource.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SmsClient(string connectionString, SmsClientOptions options)
            : this(
                ConnectionString.Parse(AssertNotNullOrEmpty(connectionString, nameof(connectionString))),
                options ?? new SmsClientOptions())
        { }

        /// <summary> Initializes a new instance of <see cref="SmsClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="keyCredential">The <see cref="AzureKeyCredential"/> used to authenticate requests.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SmsClient(Uri endpoint, AzureKeyCredential keyCredential, SmsClientOptions options = default)
            : this(
                AssertNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                AssertNotNull(keyCredential, nameof(keyCredential)),
                options ?? new SmsClientOptions())
        { }

        /// <summary> Initializes a new instance of <see cref="SmsClient"/>.</summary>
        /// <param name="endpoint">The URI of the Azure Communication Services resource.</param>
        /// <param name="tokenCredential">The TokenCredential used to authenticate requests, such as DefaultAzureCredential.</param>
        /// <param name="options">Client option exposing <see cref="ClientOptions.Diagnostics"/>, <see cref="ClientOptions.Retry"/>, <see cref="ClientOptions.Transport"/>, etc.</param>
        public SmsClient(Uri endpoint, TokenCredential tokenCredential, SmsClientOptions options = default)
            : this(
                AssertNotNull(endpoint, nameof(endpoint)).AbsoluteUri,
                AssertNotNull(tokenCredential, nameof(tokenCredential)),
                options ?? new SmsClientOptions())
        { }

        #endregion

        #region private constructors

        private SmsClient(ConnectionString connectionString, SmsClientOptions options)
            : this(connectionString.GetRequired("endpoint"), options.BuildHttpPipeline(connectionString), options)
        { }

        private SmsClient(string endpoint, TokenCredential tokenCredential, SmsClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(tokenCredential), options)
        { }

        private SmsClient(string endpoint, AzureKeyCredential keyCredential, SmsClientOptions options)
            : this(endpoint, options.BuildHttpPipeline(keyCredential), options)
        { }

        private SmsClient(string endpoint, HttpPipeline httpPipeline, SmsClientOptions options)
        {
            _clientDiagnostics = new ClientDiagnostics(options);
            RestClient = new SmsRestClient(_clientDiagnostics, httpPipeline, endpoint, options.ApiVersion);
        }

        #endregion

        /// <summary>Initializes a new instance of <see cref="SmsClient"/> for mocking.</summary>
        protected SmsClient()
        {
            _clientDiagnostics = null;
            RestClient = null;
        }

        /// <summary>
        /// Sends a SMS <paramref name="from"/> a phone number that is acquired by the authenticated account, <paramref name="to"/> another phone number.
        /// </summary>
        /// <param name="from">The sender's phone number that is owned by the authenticated account.</param>
        /// <param name="to">The recipient's phone number.</param>
        /// <param name="message">The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. If the message has more than 160 characters, the server will split it into multiple SMSs automatically.</param>
        /// <param name="options">Optional configuration for sending SMS messages.</param>
        /// <param name="cancellationToken">The cancellation token for the task.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="from"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="to"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="message"/> is null.</exception>
        public virtual async Task<Response<SmsSendResult>> SendAsync(string from, string to, string message, SmsSendOptions options = default, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(from, nameof(from));
            Argument.AssertNotNullOrEmpty(to, nameof(to));
            Response<IEnumerable<SmsSendResult>> allSmsSendResults = await SendAsync(from, new[] { to }, message, options, cancellationToken).ConfigureAwait(false);
            SmsSendResult sendSMSResult = allSmsSendResults.Value.FirstOrDefault();
            return Response.FromValue(sendSMSResult, allSmsSendResults.GetRawResponse());
        }

        /// <summary>
        /// Sends a SMS <paramref name="from"/> a phone number that is acquired by the authenticated account, <paramref name="to"/> another phone number.
        /// </summary>
        /// <param name="from">The sender's phone number that is owned by the authenticated account.</param>
        /// <param name="to">The recipient's phone number.</param>
        /// <param name="message">The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. If the message has more than 160 characters, the server will split it into multiple SMSs automatically.</param>
        /// <param name="options">Optional configuration for sending SMS messages.</param>
        /// <param name="cancellationToken">The cancellation token for the underlying request.</param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="from"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="to"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="message"/> is null.</exception>
        public virtual Response<SmsSendResult> Send(string from, string to, string message, SmsSendOptions options = default, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(from, nameof(from));
            Argument.AssertNotNullOrEmpty(to, nameof(to));
            Response<IEnumerable<SmsSendResult>> allSmsSendResults = Send(from, new[] { to }, message, options, cancellationToken);
            SmsSendResult sendSMSResult = allSmsSendResults.Value.FirstOrDefault();
            return Response.FromValue(sendSMSResult, allSmsSendResults.GetRawResponse());
        }

        /// <summary> Sends an SMS message from a phone number that belongs to the authenticated account. </summary>
        /// <param name="from"> The sender&apos;s phone number in E.164 format that is owned by the authenticated account. </param>
        /// <param name="to"> The recipient&apos;s phone number in E.164 format. In this version, up to 100 recipients in the list is supported. </param>
        /// <param name="message"> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </param>
        /// <param name="options"> Optional configuration for sending SMS messages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="from"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="to"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="message"/> is null.</exception>
        public virtual async Task<Response<IEnumerable<SmsSendResult>>> SendAsync(string from, IEnumerable<string> to, string message, SmsSendOptions options = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SmsClient)}.{nameof(Send)}");
            scope.Start();
            try
            {
                Argument.AssertNotNullOrEmpty(from, nameof(from));
                List<SmsRecipient> smsRecipients = new List<SmsRecipient>();
                foreach (string toPhoneNumber in to)
                {
                    Argument.AssertNotNullOrEmpty(toPhoneNumber, nameof(to));
                    SmsRecipient smsRecipient = new SmsRecipient(toPhoneNumber);
                    smsRecipient.RepeatabilityRequestId = Guid.NewGuid().ToString();
                    smsRecipient.RepeatabilityFirstSent = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                }

                Response<SmsSendResponse> response = await RestClient.SendAsync(from, smsRecipients, message, options, cancellationToken).ConfigureAwait(false);
                return Response.FromValue((IEnumerable<SmsSendResult>)response.Value.Value, response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary> Sends an SMS message from a phone number that belongs to the authenticated account. </summary>
        /// <param name="from"> The sender&apos;s phone number in E.164 format that is owned by the authenticated account. </param>
        /// <param name="to"> The recipient&apos;s phone number in E.164 format. In this version, up to 100 recipients in the list is supported. </param>
        /// <param name="message"> The contents of the message that will be sent to the recipient. The allowable content is defined by RFC 5724. </param>
        /// <param name="options"> Optional configuration for sending SMS messages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="RequestFailedException">The server returned an error. See <see cref="Exception.Message"/> for details returned from the server.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="from"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="to"/> is null.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="message"/> is null.</exception>
        public virtual Response<IEnumerable<SmsSendResult>> Send(string from, IEnumerable<string> to, string message, SmsSendOptions options = default, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(SmsClient)}.{nameof(Send)}");
            scope.Start();
            try
            {
                Argument.AssertNotNullOrEmpty(from, nameof(from));
                List<SmsRecipient> smsRecipients = new List<SmsRecipient>();
                foreach (string toPhoneNumber in to)
                {
                    Argument.AssertNotNullOrEmpty(toPhoneNumber, nameof(to));
                    SmsRecipient smsRecipient = new SmsRecipient(toPhoneNumber);
                    smsRecipient.RepeatabilityRequestId = Guid.NewGuid().ToString();
                    smsRecipient.RepeatabilityFirstSent = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                }

                Response<SmsSendResponse> response = RestClient.Send(from, smsRecipients, message, options, cancellationToken);
                return Response.FromValue((IEnumerable<SmsSendResult>)response.Value.Value, response.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        private static T AssertNotNull<T>(T argument, string argumentName)
            where T : class
        {
            Argument.AssertNotNull(argument, argumentName);
            return argument;
        }

        private static string AssertNotNullOrEmpty(string argument, string argumentName)
        {
            Argument.AssertNotNullOrEmpty(argument, argumentName);
            return argument;
        }
    }
}
