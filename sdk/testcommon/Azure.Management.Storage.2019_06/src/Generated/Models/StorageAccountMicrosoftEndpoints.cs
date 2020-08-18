// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing endpoint. </summary>
    public partial class StorageAccountMicrosoftEndpoints
    {
        /// <summary> Initializes a new instance of StorageAccountMicrosoftEndpoints. </summary>
        internal StorageAccountMicrosoftEndpoints()
        {
        }

        /// <summary> Initializes a new instance of StorageAccountMicrosoftEndpoints. </summary>
        /// <param name="blob"> Gets the blob endpoint. </param>
        /// <param name="queue"> Gets the queue endpoint. </param>
        /// <param name="table"> Gets the table endpoint. </param>
        /// <param name="file"> Gets the file endpoint. </param>
        /// <param name="web"> Gets the web endpoint. </param>
        /// <param name="dfs"> Gets the dfs endpoint. </param>
        internal StorageAccountMicrosoftEndpoints(string blob, string queue, string table, string file, string web, string dfs)
        {
            Blob = blob;
            Queue = queue;
            Table = table;
            File = file;
            Web = web;
            Dfs = dfs;
        }

        /// <summary> Gets the blob endpoint. </summary>
        public string Blob { get; }
        /// <summary> Gets the queue endpoint. </summary>
        public string Queue { get; }
        /// <summary> Gets the table endpoint. </summary>
        public string Table { get; }
        /// <summary> Gets the file endpoint. </summary>
        public string File { get; }
        /// <summary> Gets the web endpoint. </summary>
        public string Web { get; }
        /// <summary> Gets the dfs endpoint. </summary>
        public string Dfs { get; }
    }
}
