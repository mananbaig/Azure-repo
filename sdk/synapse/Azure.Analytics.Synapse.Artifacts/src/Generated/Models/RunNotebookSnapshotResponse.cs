// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Run notebook snapshot response. </summary>
    public partial class RunNotebookSnapshotResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RunNotebookSnapshotResponse"/>. </summary>
        internal RunNotebookSnapshotResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RunNotebookSnapshotResponse"/>. </summary>
        /// <param name="message"> Response message. </param>
        /// <param name="result"> Run notebook snapshot result. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunNotebookSnapshotResponse(string message, RunNotebookSnapshotResult result, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            Result = result;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Response message. </summary>
        public string Message { get; }
        /// <summary> Run notebook snapshot result. </summary>
        public RunNotebookSnapshotResult Result { get; }
    }
}
