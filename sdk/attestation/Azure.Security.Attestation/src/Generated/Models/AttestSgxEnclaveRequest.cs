// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.Attestation
{
    /// <summary> Attestation request for Intel SGX enclaves. </summary>
    internal partial class AttestSgxEnclaveRequest
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AttestSgxEnclaveRequest"/>. </summary>
        public AttestSgxEnclaveRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AttestSgxEnclaveRequest"/>. </summary>
        /// <param name="quote"> Quote of the enclave to be attested. </param>
        /// <param name="runtimeData"> Runtime data provided by the enclave at the time of quote generation. The MAA will verify that the first 32 bytes of the report_data field of the quote contains the SHA256 hash of the decoded "data" field of the runtime data. </param>
        /// <param name="initTimeData"> Initialization data provided when the enclave is created. MAA will verify that the init data was known to the enclave. Note that InitTimeData is invalid for CoffeeLake processors. </param>
        /// <param name="draftPolicyForAttestation"> Attest against the provided draft policy. Note that the resulting token cannot be validated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AttestSgxEnclaveRequest(byte[] quote, RuntimeData runtimeData, InitTimeData initTimeData, string draftPolicyForAttestation, Dictionary<string, BinaryData> rawData)
        {
            Quote = quote;
            RuntimeData = runtimeData;
            InitTimeData = initTimeData;
            DraftPolicyForAttestation = draftPolicyForAttestation;
            _rawData = rawData;
        }

        /// <summary> Quote of the enclave to be attested. </summary>
        public byte[] Quote { get; set; }
        /// <summary> Runtime data provided by the enclave at the time of quote generation. The MAA will verify that the first 32 bytes of the report_data field of the quote contains the SHA256 hash of the decoded "data" field of the runtime data. </summary>
        public RuntimeData RuntimeData { get; set; }
        /// <summary> Initialization data provided when the enclave is created. MAA will verify that the init data was known to the enclave. Note that InitTimeData is invalid for CoffeeLake processors. </summary>
        public InitTimeData InitTimeData { get; set; }
        /// <summary> Attest against the provided draft policy. Note that the resulting token cannot be validated. </summary>
        public string DraftPolicyForAttestation { get; set; }
    }
}
