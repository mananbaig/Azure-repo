// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.ConfidentialLedger.Models
{
    /// <summary> A receipt certifying the transaction at the specified id. </summary>
    public partial class TransactionReceipt
    {
        /// <summary> Initializes a new instance of TransactionReceipt. </summary>
        /// <param name="state"> State of a ledger query. </param>
        /// <param name="transactionId"> A unique identifier for the state of the ledger. If returned as part of a LedgerEntry, it indicates the state from which the entry was read. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transactionId"/> is null. </exception>
        internal TransactionReceipt(ConfidentialLedgerQueryState state, string transactionId)
        {
            if (transactionId == null)
            {
                throw new ArgumentNullException(nameof(transactionId));
            }

            State = state;
            TransactionId = transactionId;
        }

        /// <summary> Initializes a new instance of TransactionReceipt. </summary>
        /// <param name="receipt"> A receipt certifying the transaction at the specified id. </param>
        /// <param name="state"> State of a ledger query. </param>
        /// <param name="transactionId"> A unique identifier for the state of the ledger. If returned as part of a LedgerEntry, it indicates the state from which the entry was read. </param>
        internal TransactionReceipt(ReceiptContents receipt, ConfidentialLedgerQueryState state, string transactionId)
        {
            Receipt = receipt;
            State = state;
            TransactionId = transactionId;
        }

        /// <summary> A receipt certifying the transaction at the specified id. </summary>
        public ReceiptContents Receipt { get; }
        /// <summary> State of a ledger query. </summary>
        public ConfidentialLedgerQueryState State { get; }
        /// <summary> A unique identifier for the state of the ledger. If returned as part of a LedgerEntry, it indicates the state from which the entry was read. </summary>
        public string TransactionId { get; }
    }
}
