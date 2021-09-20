// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Security.ConfidentialLedger
{
    /// <summary> The ConfidentialLedger service client. </summary>
    public partial class ConfidentialLedgerClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }
        private HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ConfidentialLedgerRestClient _restClient;
        private readonly string[] AuthorizationScopes = { "https://confidential-ledger.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;

        /// <summary> Initializes a new instance of ConfidentialLedgerClient for mocking. </summary>
        protected ConfidentialLedgerClient()
        {
        }

        /// <summary> Initializes a new instance of ConfidentialLedgerClient. </summary>
        /// <param name="ledgerUri"> The Confidential Ledger URL, for example https://contoso.confidentialledger.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ConfidentialLedgerClient(Uri ledgerUri, TokenCredential credential, ConfidentialLedgerClientOptions options = null)
        {
            if (ledgerUri == null)
            {
                throw new ArgumentNullException(nameof(ledgerUri));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ConfidentialLedgerClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            _restClient = new ConfidentialLedgerRestClient(_clientDiagnostics, _pipeline, ledgerUri, options.Version);
        }

        /// <summary> The constitution is a script that assesses and applies proposals from consortium members. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   digest: string,
        ///   script: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetConstitutionAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetConstitution");
            scope.Start();
            try
            {
                return await _restClient.GetConstitutionAsync(options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The constitution is a script that assesses and applies proposals from consortium members. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   digest: string,
        ///   script: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetConstitution(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetConstitution");
            scope.Start();
            try
            {
                return _restClient.GetConstitution(options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Consortium members can manage the Confidential Ledger. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   members: [
        ///     {
        ///       certificate: string,
        ///       id: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetConsortiumMembersAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetConsortiumMembers");
            scope.Start();
            try
            {
                return await _restClient.GetConsortiumMembersAsync(options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Consortium members can manage the Confidential Ledger. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   members: [
        ///     {
        ///       certificate: string,
        ///       id: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetConsortiumMembers(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetConsortiumMembers");
            scope.Start();
            try
            {
                return _restClient.GetConsortiumMembers(options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A quote is an SGX enclave measurement that can be used to verify the validity of a node and its enclave. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   currentNodeId: string,
        ///   enclaveQuotes: Dictionary&lt;string, EnclaveQuote&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetEnclaveQuotesAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetEnclaveQuotes");
            scope.Start();
            try
            {
                return await _restClient.GetEnclaveQuotesAsync(options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A quote is an SGX enclave measurement that can be used to verify the validity of a node and its enclave. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   currentNodeId: string,
        ///   enclaveQuotes: Dictionary&lt;string, EnclaveQuote&gt;
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetEnclaveQuotes(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetEnclaveQuotes");
            scope.Start();
            try
            {
                return _restClient.GetEnclaveQuotes(options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   contents: string (required),
        ///   subLedgerId: string,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   subLedgerId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> PostLedgerEntryAsync(RequestContent content, string subLedgerId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.PostLedgerEntry");
            scope.Start();
            try
            {
                return await _restClient.PostLedgerEntryAsync(content, subLedgerId, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   contents: string (required),
        ///   subLedgerId: string,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   subLedgerId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response PostLedgerEntry(RequestContent content, string subLedgerId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.PostLedgerEntry");
            scope.Start();
            try
            {
                return _restClient.PostLedgerEntry(content, subLedgerId, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> To return older ledger entries, the relevant sections of the ledger must be read from disk and validated. To prevent blocking within the enclave, the response will indicate whether the entry is ready and part of the response, or if the loading is still ongoing. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   state: &quot;Loading&quot; | &quot;Ready&quot;,
        ///   entry: {
        ///     contents: string,
        ///     subLedgerId: string,
        ///     transactionId: string
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetLedgerEntryAsync(string transactionId, string subLedgerId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetLedgerEntry");
            scope.Start();
            try
            {
                return await _restClient.GetLedgerEntryAsync(transactionId, subLedgerId, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> To return older ledger entries, the relevant sections of the ledger must be read from disk and validated. To prevent blocking within the enclave, the response will indicate whether the entry is ready and part of the response, or if the loading is still ongoing. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   state: &quot;Loading&quot; | &quot;Ready&quot;,
        ///   entry: {
        ///     contents: string,
        ///     subLedgerId: string,
        ///     transactionId: string
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetLedgerEntry(string transactionId, string subLedgerId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetLedgerEntry");
            scope.Start();
            try
            {
                return _restClient.GetLedgerEntry(transactionId, subLedgerId, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a receipt certifying ledger contents at a particular transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   receipt: {
        ///     leaf: string,
        ///     nodeId: string,
        ///     proof: [
        ///       {
        ///         left: string,
        ///         right: string
        ///       }
        ///     ],
        ///     root: string,
        ///     signature: string
        ///   },
        ///   state: &quot;Loading&quot; | &quot;Ready&quot;,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetReceiptAsync(string transactionId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetReceipt");
            scope.Start();
            try
            {
                return await _restClient.GetReceiptAsync(transactionId, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a receipt certifying ledger contents at a particular transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   receipt: {
        ///     leaf: string,
        ///     nodeId: string,
        ///     proof: [
        ///       {
        ///         left: string,
        ///         right: string
        ///       }
        ///     ],
        ///     root: string,
        ///     signature: string
        ///   },
        ///   state: &quot;Loading&quot; | &quot;Ready&quot;,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetReceipt(string transactionId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetReceipt");
            scope.Start();
            try
            {
                return _restClient.GetReceipt(transactionId, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the status of an entry identified by a transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   state: &quot;Committed&quot; | &quot;Pending&quot;,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetTransactionStatusAsync(string transactionId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetTransactionStatus");
            scope.Start();
            try
            {
                return await _restClient.GetTransactionStatusAsync(transactionId, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the status of an entry identified by a transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   state: &quot;Committed&quot; | &quot;Pending&quot;,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetTransactionStatus(string transactionId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetTransactionStatus");
            scope.Start();
            try
            {
                return _restClient.GetTransactionStatus(transactionId, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   contents: string,
        ///   subLedgerId: string,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetCurrentLedgerEntryAsync(string subLedgerId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetCurrentLedgerEntry");
            scope.Start();
            try
            {
                return await _restClient.GetCurrentLedgerEntryAsync(subLedgerId, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A sub-ledger id may optionally be specified. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   contents: string,
        ///   subLedgerId: string,
        ///   transactionId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetCurrentLedgerEntry(string subLedgerId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetCurrentLedgerEntry");
            scope.Start();
            try
            {
                return _restClient.GetCurrentLedgerEntry(subLedgerId, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a user from the Confidential Ledger. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteUserAsync(string userId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.DeleteUser");
            scope.Start();
            try
            {
                return await _restClient.DeleteUserAsync(userId, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a user from the Confidential Ledger. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response DeleteUser(string userId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.DeleteUser");
            scope.Start();
            try
            {
                return _restClient.DeleteUser(userId, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a user. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   assignedRole: &quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot;,
        ///   userId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetUserAsync(string userId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetUser");
            scope.Start();
            try
            {
                return await _restClient.GetUserAsync(userId, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a user. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   assignedRole: &quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot;,
        ///   userId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetUser(string userId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetUser");
            scope.Start();
            try
            {
                return _restClient.GetUser(userId, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A JSON merge patch is applied for existing users. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   assignedRole: &quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot; (required),
        ///   userId: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   assignedRole: &quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot;,
        ///   userId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateUserAsync(string userId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.CreateOrUpdateUser");
            scope.Start();
            try
            {
                return await _restClient.CreateOrUpdateUserAsync(userId, content, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A JSON merge patch is applied for existing users. </summary>
        /// <param name="userId"> The user id, either an AAD object ID or certificate fingerprint. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   assignedRole: &quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot; (required),
        ///   userId: string
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   assignedRole: &quot;Administrator&quot; | &quot;Contributor&quot; | &quot;Reader&quot;,
        ///   userId: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdateUser(string userId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.CreateOrUpdateUser");
            scope.Start();
            try
            {
                return _restClient.CreateOrUpdateUser(userId, content, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A sub-ledger id may optionally be specified. Only entries in the specified (or default) sub-ledger will be returned. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="fromTransactionId"> Specify the first transaction ID in a range. </param>
        /// <param name="toTransactionId"> Specify the last transaction ID in a range. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   state: &quot;Loading&quot; | &quot;Ready&quot;,
        ///   @nextLink: string,
        ///   entries: [
        ///     {
        ///       contents: string,
        ///       subLedgerId: string,
        ///       transactionId: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> GetLedgerEntriesAsync(string subLedgerId = null, string fromTransactionId = null, string toTransactionId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            async Task<Page<BinaryData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetLedgerEntries");
                scope.Start();
                try
                {
                    Response response = await _restClient.GetLedgerEntriesAsync(subLedgerId, fromTransactionId, toTransactionId, options).ConfigureAwait(false);
                    return LowLevelPagableHelpers.BuildPageForResponse(response, "entries", "@nextLink");
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            async Task<Page<BinaryData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetLedgerEntries");
                scope.Start();
                try
                {
                    Response response = await _restClient.GetLedgerEntriesNextPageAsync(nextLink, subLedgerId, fromTransactionId, toTransactionId, options).ConfigureAwait(false);
                    return LowLevelPagableHelpers.BuildPageForResponse(response, "entries", "@nextLink");
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> A sub-ledger id may optionally be specified. Only entries in the specified (or default) sub-ledger will be returned. </summary>
        /// <param name="subLedgerId"> The sub-ledger id. </param>
        /// <param name="fromTransactionId"> Specify the first transaction ID in a range. </param>
        /// <param name="toTransactionId"> Specify the last transaction ID in a range. </param>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   state: &quot;Loading&quot; | &quot;Ready&quot;,
        ///   @nextLink: string,
        ///   entries: [
        ///     {
        ///       contents: string,
        ///       subLedgerId: string,
        ///       transactionId: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     innererror: ConfidentialLedgerErrorBody
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> GetLedgerEntries(string subLedgerId = null, string fromTransactionId = null, string toTransactionId = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            Page<BinaryData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetLedgerEntries");
                scope.Start();
                try
                {
                    Response response = _restClient.GetLedgerEntries(subLedgerId, fromTransactionId, toTransactionId, options);
                    return LowLevelPagableHelpers.BuildPageForResponse(response, "entries", "@nextLink");
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            Page<BinaryData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ConfidentialLedgerClient.GetLedgerEntries");
                scope.Start();
                try
                {
                    Response response = _restClient.GetLedgerEntriesNextPage(nextLink, subLedgerId, fromTransactionId, toTransactionId, options);
                    return LowLevelPagableHelpers.BuildPageForResponse(response, "entries", "@nextLink");
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }

            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
